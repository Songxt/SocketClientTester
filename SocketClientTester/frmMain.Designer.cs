namespace SocketClientTester
{
	public partial class frmMain : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btn_conn = new System.Windows.Forms.Button();
            this.txt_sip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_startnum = new System.Windows.Forms.TextBox();
            this.llb_sendNum = new System.Windows.Forms.LinkLabel();
            this.btn_disconn = new System.Windows.Forms.Button();
            this.cbo_clientnum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_recvc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chk_stopRecv = new System.Windows.Forms.CheckBox();
            this.chk_recvhex = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chk_sendhex = new System.Windows.Forms.CheckBox();
            this.txt_automsec = new System.Windows.Forms.TextBox();
            this.chk_auto = new System.Windows.Forms.CheckBox();
            this.btn_sendto = new System.Windows.Forms.Button();
            this.txt_sendc = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlb_localip = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlb_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlb_tip = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2_send = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lsClients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(210, 27);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(64, 23);
            this.btn_conn.TabIndex = 3;
            this.btn_conn.Text = "连接";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // txt_sip
            // 
            this.txt_sip.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_sip.Location = new System.Drawing.Point(77, 27);
            this.txt_sip.MaxLength = 15;
            this.txt_sip.Name = "txt_sip";
            this.txt_sip.Size = new System.Drawing.Size(116, 21);
            this.txt_sip.TabIndex = 0;
            this.txt_sip.Text = "127.0.0.1";
            this.toolTip1.SetToolTip(this.txt_sip, "服务器IP地址");
            this.txt_sip.DoubleClick += new System.EventHandler(this.txt_sip_DoubleClick);
            this.txt_sip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sip_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器地址";
            // 
            // txt_sport
            // 
            this.txt_sport.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_sport.Location = new System.Drawing.Point(77, 67);
            this.txt_sport.MaxLength = 5;
            this.txt_sport.Name = "txt_sport";
            this.txt_sport.Size = new System.Drawing.Size(116, 21);
            this.txt_sport.TabIndex = 1;
            this.txt_sport.Text = "1024";
            this.toolTip1.SetToolTip(this.txt_sport, "服务器端口号");
            this.txt_sport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "服务器端口";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_startnum);
            this.groupBox1.Controls.Add(this.llb_sendNum);
            this.groupBox1.Controls.Add(this.btn_disconn);
            this.groupBox1.Controls.Add(this.cbo_clientnum);
            this.groupBox1.Controls.Add(this.btn_conn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sip);
            this.groupBox1.Controls.Add(this.txt_sport);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置连接参数及客户端数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "起始编号";
            // 
            // txt_startnum
            // 
            this.txt_startnum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_startnum.Location = new System.Drawing.Point(77, 144);
            this.txt_startnum.MaxLength = 5;
            this.txt_startnum.Name = "txt_startnum";
            this.txt_startnum.Size = new System.Drawing.Size(116, 21);
            this.txt_startnum.TabIndex = 7;
            this.txt_startnum.Text = "202201010001";
            this.toolTip1.SetToolTip(this.txt_startnum, "服务器端口号");
            // 
            // llb_sendNum
            // 
            this.llb_sendNum.Location = new System.Drawing.Point(199, 110);
            this.llb_sendNum.Name = "llb_sendNum";
            this.llb_sendNum.Size = new System.Drawing.Size(64, 12);
            this.llb_sendNum.TabIndex = 5;
            this.llb_sendNum.TabStop = true;
            this.llb_sendNum.Text = "0";
            this.llb_sendNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.llb_sendNum, "统计发送次数(点击重置)");
            // 
            // btn_disconn
            // 
            this.btn_disconn.Location = new System.Drawing.Point(210, 65);
            this.btn_disconn.Name = "btn_disconn";
            this.btn_disconn.Size = new System.Drawing.Size(64, 23);
            this.btn_disconn.TabIndex = 4;
            this.btn_disconn.Text = "断开";
            this.btn_disconn.UseVisualStyleBackColor = true;
            this.btn_disconn.Click += new System.EventHandler(this.btn_disconn_Click);
            // 
            // cbo_clientnum
            // 
            this.cbo_clientnum.FormattingEnabled = true;
            this.cbo_clientnum.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "500",
            "1000",
            "2000",
            "5000"});
            this.cbo_clientnum.Location = new System.Drawing.Point(77, 107);
            this.cbo_clientnum.Name = "cbo_clientnum";
            this.cbo_clientnum.Size = new System.Drawing.Size(116, 20);
            this.cbo_clientnum.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbo_clientnum, "新建客户端的数量（1-65535之间)");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "并发数量";
            // 
            // txt_recvc
            // 
            this.txt_recvc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_recvc.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_recvc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_recvc.Location = new System.Drawing.Point(8, 43);
            this.txt_recvc.Multiline = true;
            this.txt_recvc.Name = "txt_recvc";
            this.txt_recvc.ReadOnly = true;
            this.txt_recvc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_recvc.Size = new System.Drawing.Size(667, 142);
            this.txt_recvc.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.chk_stopRecv);
            this.groupBox2.Controls.Add(this.chk_recvhex);
            this.groupBox2.Controls.Add(this.txt_recvc);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 191);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "清屏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_stopRecv
            // 
            this.chk_stopRecv.AutoSize = true;
            this.chk_stopRecv.Location = new System.Drawing.Point(89, 21);
            this.chk_stopRecv.Name = "chk_stopRecv";
            this.chk_stopRecv.Size = new System.Drawing.Size(72, 16);
            this.chk_stopRecv.TabIndex = 5;
            this.chk_stopRecv.Text = "停止接收";
            this.chk_stopRecv.UseVisualStyleBackColor = true;
            // 
            // chk_recvhex
            // 
            this.chk_recvhex.AutoSize = true;
            this.chk_recvhex.Checked = true;
            this.chk_recvhex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_recvhex.Location = new System.Drawing.Point(17, 20);
            this.chk_recvhex.Name = "chk_recvhex";
            this.chk_recvhex.Size = new System.Drawing.Size(66, 16);
            this.chk_recvhex.TabIndex = 2;
            this.chk_recvhex.Text = "HEX显示";
            this.chk_recvhex.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.chk_sendhex);
            this.groupBox3.Controls.Add(this.txt_automsec);
            this.groupBox3.Controls.Add(this.chk_auto);
            this.groupBox3.Controls.Add(this.btn_sendto);
            this.groupBox3.Controls.Add(this.txt_sendc);
            this.groupBox3.Location = new System.Drawing.Point(305, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 213);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "心跳测试";
            this.toolTip1.SetToolTip(this.button3, "立即发送");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "全部发送(&S)";
            this.toolTip1.SetToolTip(this.button2, "立即发送");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chk_sendhex
            // 
            this.chk_sendhex.AutoSize = true;
            this.chk_sendhex.Checked = true;
            this.chk_sendhex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_sendhex.Location = new System.Drawing.Point(128, 56);
            this.chk_sendhex.Name = "chk_sendhex";
            this.chk_sendhex.Size = new System.Drawing.Size(42, 16);
            this.chk_sendhex.TabIndex = 10;
            this.chk_sendhex.Text = "HEX";
            this.toolTip1.SetToolTip(this.chk_sendhex, "16进制发送");
            this.chk_sendhex.UseVisualStyleBackColor = true;
            // 
            // txt_automsec
            // 
            this.txt_automsec.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_automsec.Location = new System.Drawing.Point(64, 54);
            this.txt_automsec.MaxLength = 5;
            this.txt_automsec.Name = "txt_automsec";
            this.txt_automsec.Size = new System.Drawing.Size(58, 21);
            this.txt_automsec.TabIndex = 0;
            this.txt_automsec.Text = "1000";
            this.txt_automsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_automsec, "毫秒");
            this.txt_automsec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_automsec_KeyPress);
            // 
            // chk_auto
            // 
            this.chk_auto.Location = new System.Drawing.Point(16, 56);
            this.chk_auto.Name = "chk_auto";
            this.chk_auto.Size = new System.Drawing.Size(48, 16);
            this.chk_auto.TabIndex = 8;
            this.chk_auto.Text = "循环";
            this.toolTip1.SetToolTip(this.chk_auto, "启用循环发送");
            this.chk_auto.UseVisualStyleBackColor = true;
            this.chk_auto.CheckedChanged += new System.EventHandler(this.chk_auto_CheckedChanged);
            // 
            // btn_sendto
            // 
            this.btn_sendto.Location = new System.Drawing.Point(16, 20);
            this.btn_sendto.Name = "btn_sendto";
            this.btn_sendto.Size = new System.Drawing.Size(75, 23);
            this.btn_sendto.TabIndex = 3;
            this.btn_sendto.Text = "发送";
            this.toolTip1.SetToolTip(this.btn_sendto, "立即发送");
            this.btn_sendto.UseVisualStyleBackColor = true;
            this.btn_sendto.Click += new System.EventHandler(this.btn_sendto_Click);
            // 
            // txt_sendc
            // 
            this.txt_sendc.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_sendc.Location = new System.Drawing.Point(8, 80);
            this.txt_sendc.MaxLength = 1000;
            this.txt_sendc.Multiline = true;
            this.txt_sendc.Name = "txt_sendc";
            this.txt_sendc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_sendc.Size = new System.Drawing.Size(288, 127);
            this.txt_sendc.TabIndex = 2;
            this.txt_sendc.Text = "AA";
            this.toolTip1.SetToolTip(this.txt_sendc, "发送文本，双击清除显示");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlb_localip,
            this.tlb_time,
            this.tlb_tip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(937, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlb_localip
            // 
            this.tlb_localip.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tlb_localip.Name = "tlb_localip";
            this.tlb_localip.Size = new System.Drawing.Size(59, 17);
            this.tlb_localip.Text = "127.0.0.1";
            // 
            // tlb_time
            // 
            this.tlb_time.BackColor = System.Drawing.Color.Black;
            this.tlb_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tlb_time.Name = "tlb_time";
            this.tlb_time.Size = new System.Drawing.Size(126, 17);
            this.tlb_time.Text = "2019-01-15 08:08:08";
            // 
            // tlb_tip
            // 
            this.tlb_tip.AutoSize = false;
            this.tlb_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tlb_tip.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.tlb_tip.Name = "tlb_tip";
            this.tlb_tip.Size = new System.Drawing.Size(737, 17);
            this.tlb_tip.Spring = true;
            this.tlb_tip.Text = "欢迎使用";
            this.tlb_tip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2_send
            // 
            this.timer2_send.Interval = 1000;
            this.timer2_send.Tick += new System.EventHandler(this.timer2_send_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsClients);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(699, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 425);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "设备列表";
            // 
            // lsClients
            // 
            this.lsClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsClients.FullRowSelect = true;
            this.lsClients.GridLines = true;
            this.lsClients.HideSelection = false;
            this.lsClients.Location = new System.Drawing.Point(3, 17);
            this.lsClients.Name = "lsClients";
            this.lsClients.Size = new System.Drawing.Size(232, 405);
            this.lsClients.TabIndex = 14;
            this.lsClients.UseCompatibleStateImageBehavior = false;
            this.lsClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "地址";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "编号";
            this.columnHeader2.Width = 90;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 447);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocketClientTester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.Button btn_conn;

		private global::System.Windows.Forms.TextBox txt_sip;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TextBox txt_sport;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.ComboBox cbo_clientnum;

		private global::System.Windows.Forms.Button btn_disconn;

		private global::System.Windows.Forms.TextBox txt_recvc;

		private global::System.Windows.Forms.GroupBox groupBox2;

		private global::System.Windows.Forms.GroupBox groupBox3;

		private global::System.Windows.Forms.Button btn_sendto;

		private global::System.Windows.Forms.TextBox txt_sendc;

		private global::System.Windows.Forms.CheckBox chk_recvhex;

		private global::System.Windows.Forms.CheckBox chk_auto;

		private global::System.Windows.Forms.TextBox txt_automsec;

		private global::System.Windows.Forms.CheckBox chk_sendhex;

		private global::System.Windows.Forms.ToolTip toolTip1;

		private global::System.Windows.Forms.StatusStrip statusStrip1;

		private global::System.Windows.Forms.ToolStripStatusLabel tlb_localip;

		private global::System.Windows.Forms.ToolStripStatusLabel tlb_time;

		private global::System.Windows.Forms.ToolStripStatusLabel tlb_tip;

		private global::System.Windows.Forms.Timer timer1;

		private global::System.Windows.Forms.Timer timer2_send;

		private global::System.Windows.Forms.LinkLabel llb_sendNum;

		private global::System.Windows.Forms.CheckBox chk_stopRecv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_startnum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lsClients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
