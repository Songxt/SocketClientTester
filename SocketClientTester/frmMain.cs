using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketClientTester
{
    public partial class frmMain
    {
        private readonly ConcurrentDictionary<string, StateObject> Clients =
            new ConcurrentDictionary<string, StateObject>();
        private long startNum = 202201010001;
        private int clientNum = 1;
        private int count;
        private string tcpserverip = "127.0.0.1";
        private string tcpserverport = "1024";

        public frmMain()
        {
            InitializeComponent();
            cbo_clientnum.SelectedIndex = 0;
            //CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            //btn_conn.Enabled = false;
            clientNum = int.Parse(cbo_clientnum.Text);
            startNum = Convert.ToInt64(txt_startnum.Text) - 1;
            tcpserverip = txt_sip.Text.Trim();
            tcpserverport = txt_sport.Text.Trim();

            if (!(tcpserverip == "") && !(tcpserverport == ""))
            {
                var address = IPAddress.Parse(tcpserverip);
                var remoteEP = new IPEndPoint(address, int.Parse(tcpserverport));
                var TaskList = new Task[clientNum];

                for (var i = 0; i < TaskList.Length; i++)
                {
                    TaskList[i] = new Task(() =>
                    {
                        var flag = false;
                        loop:
                        {
                            try
                            {
                                var client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                                client.Connect(remoteEP);
                                Interlocked.Increment(ref startNum);
                                Receive(client, startNum.ToString());

                                flag = true;
                            }
                            catch
                            {
                                flag = false;
                            }
                        }
                        if (!flag) goto loop;
                    });

                    TaskList[i].Start();
                }

                //btn_disconn.Enabled = true;
            }
        }

        private void Receive(Socket client, string num)
        {
            var state = new StateObject();
            state.workSocket = client;
            state.Key = client.LocalEndPoint.ToString();
            state.value = num;
            client.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, ReceiveCallback, state);
            Interlocked.Increment(ref count);
            Clients.TryAdd(state.Key, state);
            Invoke(new Action(() =>
            {
                llb_sendNum.Text = count.ToString();
                ListViewItem lvi = new ListViewItem(state.Key);
                lvi.SubItems.Add(state.value);
                lsClients.Items.Add(lvi);
            }));
            ShowMsg(state.Key + " 连接成功！");
        }

        public void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                var state = ar.AsyncState as StateObject;
                var client = state.workSocket;
                var length = client.EndReceive(ar);
                var recdata = new byte[length];
                Array.Copy(state.buffer, recdata, length);
                ShowMsg(state.Key + " <= ", recdata);
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, ReceiveCallback, state);
            }
            catch
            {
                
            }

        }

        private void ShowMsg(string text)
        {
            try
            {
                text = $"{DateTime.Now.ToString("HH:mm:ss fff")} {text} {Environment.NewLine}";
                Invoke(new Action(() =>
                {
                    if (!chk_stopRecv.Checked)
                    {
                        txt_recvc.AppendText(text);
                        txt_recvc.Focus();
                        txt_recvc.Select(txt_recvc.TextLength, 0);
                        txt_recvc.ScrollToCaret();
                    }

                    Application.DoEvents();
                }));
            }
            catch (Exception ex)
            {
                tlb_tip.Text = ex.Message;
            }
        }

        private void ShowMsg(string name, byte[] dataBytes)
        {
            try
            {
                var text = "";
                if (chk_recvhex.Checked)
                {
                     text = BitConverter.ToString(dataBytes).Replace("-", "");
                }
                else
                {
                    text = Encoding.UTF8.GetString(dataBytes);
                }

                text = $"{DateTime.Now.ToString("HH:mm:ss fff")} {name} {text} {Environment.NewLine}";

                Invoke(new Action(() =>
                {
                    if (!chk_stopRecv.Checked)
                    {
                        txt_recvc.AppendText(text);
                        txt_recvc.Focus();
                        txt_recvc.Select(txt_recvc.TextLength, 0);
                        txt_recvc.ScrollToCaret();
                    }

                    Application.DoEvents();
                }));
            }
            catch (Exception ex)
            {
                tlb_tip.Text = ex.Message;
            }
        }

        public static byte[] HexStringToBytes(string hexStr)
        {
            var str = hexStr.Replace("-", string.Empty).Replace(" ", string.Empty);
            if (str.Length % 2 != 0) throw new ArgumentException("传入的 16 进制字符串长度不对。");
            if (!new Regex(@"[A-Fa-f0-9]+$").IsMatch(str)) throw new ArgumentException("传入的 16 进制字符串数据不符合规范。");
            return Enumerable.Range(0, str.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(str.Substring(x, 2), 16))
                .ToArray();
        }

        private void btn_sendto_Click(object sender, EventArgs e)
        {
            var text = txt_sendc.Text.Trim();
            byte[] array;
            if (chk_sendhex.Checked)
                array = HexStringToBytes(text);
            else
                array = Encoding.UTF8.GetBytes(text);
            try
            {
                foreach (ListViewItem item in lsClients.SelectedItems)
                {
                    var clientname = item.Text;
                    var ret = Clients.TryGetValue(clientname, out var client);
                    if (ret) client.Send(array);
                    ShowMsg(clientname + " => ", array);
                }
            }
            catch (Exception ex)
            {
                ShowMsg("发送错误|" + ex.Message);
            }
        }

        private void chk_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_auto.Checked)
            {
                var interval = int.Parse(txt_automsec.Text);
                timer2_send.Interval = interval;
                timer2_send.Enabled = true;
                tlb_tip.Text = "循环发送已启用...";
            }
            else
            {
                timer2_send.Enabled = false;
            }
        }

        private void btn_disconn_Click(object sender, EventArgs e)
        {
            foreach (var client in Clients)
            {
                client.Value.Close();
                Interlocked.Decrement(ref count);
                ShowMsg(client.Key + " 断开连接成功！");
                Invoke(new Action(() => { llb_sendNum.Text = count.ToString(); }));
            }

            Clients.Clear();
            lsClients.Items.Clear();
            Interlocked.Exchange(ref count, 0);
            //btn_disconn.Enabled = false;
            //btn_conn.Enabled = true;
            //chk_auto.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tlb_time.Text = string.Format("{0:yyyy年MM月dd日 HH:mm:ss}", DateTime.Now);
        }

        private void txt_sport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != '\r' && e.KeyChar != '\b') e.Handled = true;
        }

        private void txt_automsec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != '\r' && e.KeyChar != '\b') e.Handled = true;
        }

        private void txt_sip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != '.' && e.KeyChar != '\r' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txt_sip_DoubleClick(object sender, EventArgs e)
        {
            txt_sip.Text = "127.0.0.1";
        }

        private void timer2_send_Tick(object sender, EventArgs e)
        {
            try
            {
                btn_sendto_Click(sender, e);
            }
            catch
            {
                timer2_send.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_disconn_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_recvc.Text = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private class lsItem
        {
            public string Key { get; set; }

            public string Value { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var text = txt_sendc.Text.Trim();
            byte[] array;
            if (chk_sendhex.Checked)
                array = HexStringToBytes(text);
            else
                array = Encoding.UTF8.GetBytes(text);
            foreach (var client in Clients)
            {
                client.Value.Send(array);
                ShowMsg(client.Key + " => ", array);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lsClients.Items.Count.ToString());
        }
    }
}