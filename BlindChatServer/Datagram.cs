using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlindChatServer
{
    public enum DataType { Chat, OnLine, OffLine, SendHostInfo }

    public class Datagram
    {
        public string IPTo { get; set; }
        public string IPFrom { get; set; }
        public int Length { get { return this.Content.Length; } }
        public string Content { get; set; }
        public DataType MessageType { get; set; }

        public static Datagram Convert(byte[] buffer, int length)
        {
            string message = Encoding.UTF8.GetString(buffer, 0, length);

            Datagram data = new Datagram();

            //前面不是CHAT主要是建立连接 取消连接等信号传送
            if (!message.StartsWith("CHAT"))
            {
                IDictionary<string, string> msgPairs = new Dictionary<string, string>();

                foreach (string msg in message.Split(','))
                {
                    msgPairs.Add(msg.Split('=')[0], msg.Split('=')[1]);
                }

                data.MessageType = (DataType)Enum.Parse(typeof(DataType), msgPairs["MessageType"]);
                data.IPFrom = msgPairs["IPFrom"];
                data.IPTo = msgPairs["IPTo"];
                data.Content = msgPairs["Content"];
            }
            else
            {
                data.MessageType = (DataType)Enum.Parse(typeof(DataType), "Chat");
                data.Content = message.Substring(4);
            }

            return data;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("MessageType={0},", this.MessageType.ToString());
            sb.AppendFormat("IPFrom={0},", this.IPFrom.ToString());
            sb.AppendFormat("IPTo={0},", this.IPTo.ToString());
            sb.AppendFormat("Content={0}", this.Content.ToString());
            return sb.ToString();
        }
    }
}
