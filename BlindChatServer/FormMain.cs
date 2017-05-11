using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BlindChat;

namespace BlindChatServer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UDPSocketServer.GetInstance().BeginListen();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            UDPSocketServer.GetInstance().Dispose();
        }
    }
}
