using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SocketClientTester
{
    public class StateObject
    {
        public byte[] buffer = new byte[BufferSize];

        public Socket workSocket = null;

        public string Key = "";

        public string value = "";

        public const int BufferSize = 256;

        public void Send(byte[] data)
        {
            workSocket.Send(data);
        }

        public void Close()
        {
            if (workSocket != null)
            {
                try
                {
                    workSocket.Shutdown(SocketShutdown.Both);

                }
                finally
                {
                    workSocket.Close();
                    workSocket.Dispose();
                    workSocket = null;
                }
            }
        }
    }
}
