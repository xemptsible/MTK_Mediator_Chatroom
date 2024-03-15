using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class NhomChat : IPhongChat
    {
        private List<User> _users = new List<User>();
        public void DangKy(User user)
        {
            /*
             Gán phòng chat với người dùng khi sử dụng phương thức DangKy
             user.ChatRoom = this;

             Có thể gán thay trong lớp User trong khởi tạo nếu có nhiều PhongChat được triển khai ngoài NhomChat
            */

            _users.Add(user);
        }

        public void DangKyNhieuUser(params User[] users)
        {
            foreach (var newUser in _users)
            {
                DangKy(newUser);
            }
        }

        public void GuiNhanTin(string from, string message)
        {
            _users.ForEach(user => user.Notify(from, message));
        }
    }
}
