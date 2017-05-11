using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using BlindChatClient;

namespace BlindChat
{
    public class UDPSocketClient
    {
        private EndPoint m_CommunicatePoint = null;
        private IPEndPoint m_BroadcastPoint = new IPEndPoint(IPAddress.Broadcast, Config.ServerPort);
        private Socket m_ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private Socket m_BroadcastSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        public UDPSocketClient(EndPoint point)
        {
            this.m_CommunicatePoint = point;
        }

        public void Broadcast(DataType type)
        {
            Datagram dataGram = new Datagram
            {
                MessageType = type,
                IPFrom = Config.LocalIPAddress,
                IPTo = "",
                Content = Dns.GetHostName()
            };

            this.m_BroadcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            this.m_BroadcastSocket.SendTo(Encoding.Default.GetBytes(dataGram.ToString()), m_BroadcastPoint);
        }

        private void BeginSend(string msg)
        {
            byte[] data = Encoding.Default.GetBytes(msg);

            try
            {
                m_ClientSocket.BeginSendTo(data, 0, data.Length, SocketFlags.None, m_CommunicatePoint, new AsyncCallback(SendData), m_ClientSocket);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void SendData(IAsyncResult result)
        {
            m_ClientSocket.EndSend(result);
        }
    }
}
