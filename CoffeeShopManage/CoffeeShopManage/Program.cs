

using System.Security.Cryptography.X509Certificates;
using Models;
namespace CoffeeShopManage
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Menu menu = new Menu();
            MenuLogin login = new MenuLogin();
            SatffDAO staff = new SatffDAO();
            BillDAO bill = new BillDAO();
            FoodDAO food = new FoodDAO();
            MenuAccount account = new MenuAccount();
            if(login._MenuLogin() == true )
            {
                if(Const.LoaiTaiKhoan == "Admin")
                {
                    int choose = 0;
                    do
                    {
                        Console.Clear();
                        menu.MenuAdmin();
                        Console.Write("Enter Choose Option: "); choose = int.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 0:
                                {
                                    break;
                                }
                            case 1:
                                {
                                    //staff.Menu();
                                    break;
                                }
                            case 2:
                                {
                                    bill.Menu();
                                    break;
                                }
                            case 3:
                                {
                                    food.Menu();
                                    break;
                                }
                            case 4:
                                {
                                    account.Menu();
                                    break;
                                }
                        }
                    }while(choose !=0);
                }
                else if(Const.LoaiTaiKhoan == "nhan vien")
                {
                    int choose = 0;
                    do
                    {
                        menu.Menustaff();
                        switch(choose) {
                            case 0:
                                {
                                    break;
                                }
                            case 1:
                                {
                                    bill.Menu();
                                    break;
                                }
                        }
                    } while (choose != 0);
                }
            }
            
        }
       
        
    }
}
