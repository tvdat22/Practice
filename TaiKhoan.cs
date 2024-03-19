using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class TaiKhoan
    {
        private string userName;
        private string passWord;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string v1, string v2)
        {
        }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        public override bool Equals(object obj)
        {
            return obj is TaiKhoan khoan &&
                   userName == khoan.userName &&
                   passWord == khoan.passWord;
        }
    }
}
