namespace MediatorPattern
{
    partial class Form1
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
            this.list_messages = new System.Windows.Forms.ListBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.list_users = new System.Windows.Forms.ListBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_messages
            // 
            this.list_messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.list_messages.FormattingEnabled = true;
            this.list_messages.ItemHeight = 18;
            this.list_messages.Location = new System.Drawing.Point(11, 53);
            this.list_messages.Name = "list_messages";
            this.list_messages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.list_messages.Size = new System.Drawing.Size(514, 184);
            this.list_messages.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameLabel.Location = new System.Drawing.Point(8, 15);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(161, 20);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Enter your username:";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(175, 15);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(351, 22);
            this.tb_username.TabIndex = 2;
            // 
            // rtb_message
            // 
            this.rtb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtb_message.Location = new System.Drawing.Point(12, 243);
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(513, 72);
            this.rtb_message.TabIndex = 3;
            this.rtb_message.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_send.Location = new System.Drawing.Point(531, 243);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(121, 66);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_connect.Location = new System.Drawing.Point(532, 13);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(88, 27);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // list_users
            // 
            this.list_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.list_users.FormattingEnabled = true;
            this.list_users.ItemHeight = 18;
            this.list_users.Location = new System.Drawing.Point(532, 53);
            this.list_users.Name = "list_users";
            this.list_users.Size = new System.Drawing.Size(188, 184);
            this.list_users.TabIndex = 6;
            this.list_users.SelectedIndexChanged += new System.EventHandler(this.list_users_SelectedIndexChanged);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_disconnect.Location = new System.Drawing.Point(626, 13);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(94, 27);
            this.btn_disconnect.TabIndex = 7;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(658, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.list_users);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.rtb_message);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.list_messages);
            this.Name = "Form1";
            this.Text = "Chatroom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_messages;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ListBox list_users;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button button1;
    }
}

