using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediatorPattern
{
    /*
     * Triển khai mẫu Mediator 
     * với một giai diện khai báo những phương thức cần thiết để giao tiếp với các Components/Colleagues
     */
    public interface IPhongChat
    {
        void DangKy(User user);
        void DangKyNhieuUser(params User[] users);
        void GuiNhanTin(string from, string message);
    }
}
