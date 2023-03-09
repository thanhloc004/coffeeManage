using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Controllers.Implement_Class;

namespace CoffeeShopManage
{
    public class MenuAccount
    {
        public void Menu()
        {
            int choose = 0;
            do
            {
                Console.Write("Nhap lua chon cua ban: ");
                choose = int.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        {
                            Account account = new Account();
                            account.ID = ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
                            string userName;
                            do
                            {
                                Console.Write("Tai khoan: ");
                                userName = Console.ReadLine();
                            }while(AccountController.Instance.CheckUserName(userName)==true);
                            account.UserName = userName;
                            Console.Write("Mat khau: ");
                            account.PassWord = Console.ReadLine();
                            account.Power = "nhan vien";
                            AccountController.Instance.Create(account);
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                }
            } while (choose != 0);
        }
      
    }
}
