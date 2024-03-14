using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Mediator
{
    // Triển khai lớp bê tông/cứng (Concrete class) với những phương pháp kế thừa từ lớp trừu tượng
    public class User : IUser
    {
        public User(string username) : base(username)
        {
        }
    }
}
