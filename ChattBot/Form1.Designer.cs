namespace ChattBot
{
    partial class FrmChatbot
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            rtbChat = new RichTextBox();
            panel1 = new Panel();
            txtMessage = new TextBox();
            btnSend = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(rtbChat, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Size = new Size(1179, 820);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rtbChat
            // 
            rtbChat.BackColor = Color.Red;
            rtbChat.Dock = DockStyle.Fill;
            rtbChat.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rtbChat.ForeColor = Color.Yellow;
            rtbChat.Location = new Point(4, 4);
            rtbChat.Margin = new Padding(4, 4, 4, 4);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(1171, 710);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMessage);
            panel1.Controls.Add(btnSend);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 722);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(7, 7, 7, 7);
            panel1.Size = new Size(1171, 94);
            panel1.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtMessage.Location = new Point(0, 0);
            txtMessage.Margin = new Padding(4, 4, 4, 4);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(1055, 93);
            txtMessage.TabIndex = 1;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // btnSend
            // 
            btnSend.Cursor = Cursors.Hand;
            btnSend.Dock = DockStyle.Right;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Location = new Point(1064, 7);
            btnSend.Margin = new Padding(4, 4, 4, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 80);
            btnSend.TabIndex = 0;
            btnSend.Text = "GÖNDER";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // FrmChatbot
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 820);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmChatbot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AI Chatbot";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
    }
}
