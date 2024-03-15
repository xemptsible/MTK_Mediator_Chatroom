using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    // Lớp 
    public abstract class User
    {
        public string Username { get; }
        public IPhongChat ChatRoom { get; set; }


        //Gán phòng chat trong khởi tạo User

        protected User(IPhongChat chatroom, string username)
        {
            Username = username;
            ChatRoom = chatroom;
        }

        public void GanChatRoom(IPhongChat chatRoom)
        {
            ChatRoom = chatRoom;
        }

        public void Send(string message)
        {
            ChatRoom.GuiNhanTin(Username, message);
        }

        public virtual void Notify(string user, string message)
        {
            Debug.WriteLine($"{Username} nhận {message} trong {ChatRoom} từ {user}");
        }
    }
}
