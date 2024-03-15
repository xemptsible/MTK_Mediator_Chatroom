using MediatorPattern.Mediator;
using System;
using System.CodeDom;
using System.Collections;
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
        User nguoiDung;
        List<User> cacNguoiDung = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (rtb_message.Text != "")
            {
                GuiNhanTin(rtb_message.Text, nguoiDung);
                rtb_message.Clear();
                foreach (User u in cacNguoiDung)
                {
                    Debug.WriteLine(u.Username + " " + u.ChatRoom);
                }
            }
            else return;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (tb_username.Text.Length == 0)
            {
                list_messages.Items.Add("Please enter your username.");
            }
            else
            {
                KetNoi(ChatRoom, tb_username.Text.Trim());
                ThemVaoDanhSach(tb_username.Text.Trim());
/*                foreach (User u in cacNguoiDung)
                {
                    Debug.WriteLine("Danh sách người dùng sau khi đăng ký: " + u.Username + " " + u.ChatRoom);
                }*/
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (cacNguoiDung.Count == 0 || tb_username.Text.Length == 0)
            {
                list_messages.Items.Add("No username found.");
                return;
            }
            else
            {
                for (int i = list_users.Items.Count - 1; i >= 0; i--)
                {
                    if (list_users.Items[i].ToString().Equals(nguoiDung.Username))
                    {
                        list_users.Items.RemoveAt(i);
                        list_messages.Items.Add($"{nguoiDung.Username} has left the chatroom.");
                        cacNguoiDung.Remove(cacNguoiDung[i]);
                    }
                }
                nguoiDung = null;
            }


            foreach (User u in cacNguoiDung)
            {
                Debug.WriteLine("Danh sách người dùng sau khi thoát: " + u.Username);
            }
        }

        public void KetNoi(IPhongChat chatroom, string username)
        {
            // Kiểm tra nếu có người dùng rồi kiểm người dùng mới có trùng tên không
            if (!cacNguoiDung.Any(s => tb_username.Text.Equals(s.Username)))
            {
                nguoiDung = new ThanhVien(ChatRoom, tb_username.Text);
                cacNguoiDung.Add(nguoiDung);
                ChatRoom.DangKy(nguoiDung);
                list_messages.Items.Clear();
                list_messages.Items.Add($"Connected as {tb_username.Text}.");
                list_messages.Items.Add($"Joined a chatroom called {ChatRoom}.");
            }
            else if (cacNguoiDung.Any(s => tb_username.Text.Equals(s.Username)))
            {
                MessageBox.Show("Duplicate name!", "Failed to connect");
                Debug.WriteLine("Tên trùng!");
            }

        }

        public void GuiNhanTin(string message, User user)
        {
            if (user != null)
            {
                user.Send(message);
                list_messages.Items.Add($">>{user.Username}: " + message);
            }
            else
            {
                MessageBox.Show("Oh, I'm sorry. I just noticed that you are nameless", "What's your name?");
            }
        }

        public void ThemVaoDanhSach(string user)
        {
            cacNguoiDung.ForEach(u => {
                if (user.Equals(u.Username) && !list_users.Items.Contains(u.Username))
                    list_users.Items.Add(u.Username);
            });
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            list_messages.Items.Clear();
        }

        private void list_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser;
            if (list_users.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                selectedUser = list_users.SelectedItem.ToString();
            }

            int index = list_users.FindString(selectedUser);

            nguoiDung = (ThanhVien)cacNguoiDung[index];
            //list_messages.Items.Add($"Switched to {nguoiDung.Username}.");
            Debug.WriteLine($"Selected another user as {nguoiDung.Username}.");
        }
    }
}
