using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    // Lớp 
    public abstract class IUser
    {
        public string Username { get; }
        public IPhongChat ChatRoom { get; set; }

        protected IUser(string username)
        {
            Username = username;
        }

        public void SetChatRoom(IPhongChat chatRoom)
        {
            ChatRoom = chatRoom;
        }

        public void Send(string message)
        {
            ChatRoom.Send(Username, message);
        }

        public virtual void Notify(string from, string message)
        {
             Debug.WriteLine($"{Username} received {message} from {ChatRoom}");
        }
    }
}
