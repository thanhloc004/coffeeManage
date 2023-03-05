using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
     public class Account
    {
        public long ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Power { get; set; }
        public Account(int iD,string userName,string passWord,string power)
        {
            this.ID = iD;
            this.UserName = userName;
            this.PassWord = passWord;
            this.Power = power;
        }
        public Account() { }
    }
}
