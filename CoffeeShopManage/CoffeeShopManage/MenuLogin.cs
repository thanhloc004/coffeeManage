using Controllers.Implement_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManage
{
    public class MenuLogin
    {
        public bool _MenuLogin()
        {
            Console.Write("Tai khoan: ");
            string userName = Console.ReadLine();
            Console.Write("Mat khau: ");
            string passWord = Console.ReadLine();
            if(AccountController.Instance.Login(userName, passWord)==true)
            {
                return true;
            }
            return false;
        }
    }
}
