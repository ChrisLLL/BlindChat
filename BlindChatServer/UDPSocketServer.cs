using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using BlindChatServer;

namespace BlindChat
{
    public sealed class UDPSocketServer : IDisposable
    {
        #region 单例模式实现
        private static readonly UDPSocketServer m_ServerInstance = new UDPSocketServer();
        public static UDPSocketServer GetInstance() { return m_ServerInstance; }
        #endregion

        private byte[] m_Buffer = new byte[1024];
        private EndPoint m_CommunicatePoint = null;
        private EndPoint m_ListenPoint = (EndPoint)new IPEndPoint(IPAddress.Any, 0);
        private IPEndPoint m_ServerPoint = new IPEndPoint(IPAddress.Any, Config.ServerPort);
        private Socket m_ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        #region Constructor

        private UDPSocketServer()
        {
            m_ServerSocket.Bind(m_ServerPoint);
        }

        #endregion

        #region  Destructor

        ~UDPSocketServer()
        {
            this.m_ServerSocket.Shutdown(SocketShutdown.Both);
            this.m_ServerSocket.Close();
        }

        public void Dispose()
        {
            this.m_ServerSocket.Shutdown(SocketShutdown.Both);
            this.m_ServerSocket.Close();
        }

        #endregion

        public void BeginListen()
        {
            m_ServerSocket.BeginReceiveFrom(m_Buffer, 0, m_Buffer.Length, SocketFlags.None, ref m_ListenPoint, new AsyncCallback(ReciveData), null);
        }

        private void ReciveData(IAsyncResult result)
        {
            int length = 0;

            try
            {
                length = m_ServerSocket.EndReceiveFrom(result, ref m_ListenPoint);
                //将接收到的信息转化为自定义的数据报类
                Datagram recviceData = Datagram.Convert(m_Buffer, length);
                //数据解析
                Analysis(recviceData);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                BeginListen();
            }
        }

        private void Analysis(Datagram data)
        {
            switch (data.MessageType)
            {
                case DataType.Chat:
                    break;
                case DataType.OnLine:
                    break;
                case DataType.OffLine:
                    break;
            }
        }

        private void BeginSend(string msg)
        {
            byte[] data = Encoding.Default.GetBytes(msg);

            try
            {
                m_ServerSocket.BeginSendTo(data, 0, data.Length, SocketFlags.None, m_CommunicatePoint, new AsyncCallback(SendData), m_ServerSocket);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void SendData(IAsyncResult result)
        {
            m_ServerSocket.EndSend(result);
        }
    }
}
