using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatUDP
{
    class Chat
    {
        string ipSend = "255.255.255.255";
        Socket socketSend;

        string ipReceive = "0.0.0.0";
        Socket socketReceive;
        IPAddress ipAddrSend;
        IPEndPoint iPEndPointSend;


        IPAddress ipAddrRecv;
        IPEndPoint iPEndPointRecv;
        public Chat()
        {
            ipAddrSend = IPAddress.Parse(ipSend);
            iPEndPointSend = new IPEndPoint(ipAddrSend, 4444);
            ipAddrRecv = IPAddress.Parse(ipReceive);
            iPEndPointRecv = new IPEndPoint(ipAddrRecv, 4444);
            socketReceive = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            socketReceive.Bind(iPEndPointRecv);

        }

        public Task<MSG> Receive()
        {
            Task<MSG> t = new Task<MSG>(() =>
            {
                byte[] bytes = new byte[255];
                socketReceive.Receive(bytes);
                return new MSG() { Message = Encoding.Default.GetString(bytes).Split('&')[0] };
            });
            t.Start();
            return t;

        }

        public void Send(string message, bool isActive)
        {
            if (isActive)
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
                socketSend.Connect(iPEndPointSend);

                byte[] bytes = Encoding.Default.GetBytes($"{message}&");
                socketSend.Send(bytes);
            }
            else
            {
                MessageBox.Show("Join the Chat!");
            }
        }

        ~Chat()
        {

            socketReceive.Close();
            socketSend.Close();
        }
    }
}
