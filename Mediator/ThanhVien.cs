using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Mediator
{
    // Những lớp Components/ConcreteColleagues dùng để giao tiếp
    public class ThanhVien : User
    {

        public ThanhVien(IPhongChat chatroom, string username) : base(chatroom, username)
        {
        }
    }
}
