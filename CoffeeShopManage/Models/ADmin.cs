using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ADmin
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public ADmin(string userName,string passWord,string name) {
            this.Name = name;
            this.UserName = userName;
            this.PassWord = passWord;
        }
    }
}
