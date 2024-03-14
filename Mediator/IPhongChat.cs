using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediatorPattern
{
    // Triển khai mẫu Mediator với một interface
    public interface IPhongChat
    {
        void Register(IUser user);
        void RegisterMultiple(params IUser[] users);
        void Send(string from, string message);
    }
}
