using Controllers.Implement_Class;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace CoffeeShopManage
{
    public class LoginDAO
    {
        void Menu()
        {
            int choose = 0;
            do
            {
                Console.Write("Enter Choose Option: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    
                }
            }while(choose !=0);
            
        }
        void Case1()
        {
            Account account = new Account();
            account.ID = ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
            Console.Write("Tai Khoan: ");
            account.UserName = Console.ReadLine();
            Console.Write("Mat khau: ");
            account.PassWord = Console.ReadLine();
            account.Power = "nhan vien";
            AccountController.Instance.Create(account);
        }
        void Login()
        {
            Console.Write("UserName: ");
            string userName = Console.ReadLine();
            Console.Write("PassWord: ");
            string passWord = Console.ReadLine();
            AccountController.Instance.Login(userName, passWord);
        }

    }
}
