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
        private List<IUser> _users = new List<IUser>();
        public void Register(IUser user)
        {
            //If user hasn't joined this chatroom yet
            user.ChatRoom = this;
            _users.Add(user);
        }

        public  void RegisterMultiple(params IUser[] users)
        {
            foreach (var newUser in _users)
            {
                Register(newUser);
            }
        }

        public  void Send(string from, string message)
        {
            _users.ForEach(user => user.Notify(from, message));
        }
    }
}
