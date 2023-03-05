using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManage
{
    public class Adminf
    {
        public void Menu()
        {
            int choose = 0;
            do
            {
                MenuAmin();
                Console.Write("Enter choose option: "); choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        {
                            break;
                        }
                }
            }while (choose != 0);
        }
        void MenuAmin()
        {
            Console.WriteLine("1. Quan Ly Nhan Vien");
            Console.WriteLine("2. Quan Ly Hoa Don");
            Console.WriteLine("3. Quan ly ban");
            Console.WriteLine("4. Quan ly luong nhan vien");
        }
    }
}
