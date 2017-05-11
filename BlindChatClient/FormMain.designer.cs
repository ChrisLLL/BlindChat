namespace BlindChat
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFriend = new System.Windows.Forms.GroupBox();
            this.lbContact = new System.Windows.Forms.ListBox();
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.gbFriend.SuspendLayout();
            this.gbChat.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFriend
            // 
            this.gbFriend.Controls.Add(this.lbContact);
            this.gbFriend.Location = new System.Drawing.Point(17, 16);
            this.gbFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFriend.Name = "gbFriend";
            this.gbFriend.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFriend.Size = new System.Drawing.Size(341, 921);
            this.gbFriend.TabIndex = 0;
            this.gbFriend.TabStop = false;
            this.gbFriend.Text = "联系人";
            // 
            // lbContact
            // 
            this.lbContact.FormattingEnabled = true;
            this.lbContact.ItemHeight = 15;
            this.lbContact.Location = new System.Drawing.Point(8, 25);
            this.lbContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(324, 889);
            this.lbContact.TabIndex = 0;
            // 
            // gbChat
            // 
            this.gbChat.Controls.Add(this.lbMessage);
            this.gbChat.Enabled = false;
            this.gbChat.Location = new System.Drawing.Point(368, 16);
            this.gbChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChat.Name = "gbChat";
            this.gbChat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChat.Size = new System.Drawing.Size(928, 660);
            this.gbChat.TabIndex = 1;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "聊天";
            // 
            // lbMessage
            // 
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.ItemHeight = 15;
            this.lbMessage.Location = new System.Drawing.Point(9, 26);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(909, 619);
            this.lbMessage.TabIndex = 0;
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.btnSend);
            this.gbMessage.Controls.Add(this.rtbMessage);
            this.gbMessage.Enabled = false;
            this.gbMessage.Location = new System.Drawing.Point(368, 685);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMessage.Size = new System.Drawing.Size(928, 252);
            this.gbMessage.TabIndex = 2;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "消息";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(820, 216);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 29);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessage.Location = new System.Drawing.Point(9, 26);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(911, 186);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 952);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.gbChat);
            this.Controls.Add(this.gbFriend);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "瞎聊客户端";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbFriend.ResumeLayout(false);
            this.gbChat.ResumeLayout(false);
            this.gbMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFriend;
        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.ListBox lbContact;
    }
}

