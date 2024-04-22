using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaughns_business.Classes
{
    public class StaffLogin
    {
        private int _userId;
        private string _userName;
        private string _passWord;
        public StaffLogin(int userId, string userName, string passWord)
        {
            _userId = userId;
            _userName = userName;
            _passWord = passWord;
        }
        public int UserId { get => _userId; set => _userId = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string PassWord { get => _passWord; set => _passWord = value; }
    }
}
