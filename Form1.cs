using MediatorPattern.Mediator;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MediatorPattern
{
    public partial class Form1 : Form
    {
        IPhongChat ChatRoom = new NhomChat();

        IUser nguoiDung;
        List<IUser> cacNguoiDung = new List<IUser>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (rtb_message.Text != "")
            {
                GuiNhanTin(rtb_message.Text);
                rtb_message.Clear();
            }
            else return;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                list_messages.Items.Add("Please enter your username.");
            }
            else
            {
                list_messages.Items.Clear();
                KetNoi(tb_username.Text);
                ThemVaoDanhSach(tb_username.Text);
                list_messages.Items.Add($"Connected as {tb_username.Text}.");
                list_messages.Items.Add($"Joined a chatroom called {ChatRoom}.");
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (cacNguoiDung.Count == 0) return;
            else
            list_messages.Items.Add("Disconnected.");
            cacNguoiDung.Clear();
        }

        public void KetNoi(string username)
        {
            nguoiDung = new User(tb_username.Text);
            cacNguoiDung.Add(nguoiDung);
            ChatRoom.Register(nguoiDung);
        }

        public void GuiNhanTin(string message)
        {
            nguoiDung.Send(message);
            list_messages.Items.Add($">>{nguoiDung.Username}: " + message);
        }

        public void ThemVaoDanhSach(string user)
        {
            cacNguoiDung.ForEach(u => {
                if (user.Equals(u.Username) && !list_users.Items.Contains(u.Username))
                    list_users.Items.Add(u.Username);
            });
        }
    }
}
