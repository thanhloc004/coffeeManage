using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManage
{
    public class Menu
    {
        public void Menustaff()
        {
            Console.WriteLine("1. Oder");
            Console.WriteLine("2. Show Food");
        }
        
        public void MenuAdmin()
        {
            Console.WriteLine("1.Quan ly nhan vien");
            Console.WriteLine("2.Quan ly hoa don");
            Console.WriteLine("3.Quan ly Food");
            Console.WriteLine("4.Quan ly tai khoan");
        }
        public void MenuQLNV()
        {
            Console.WriteLine("1. Create Staff");
            Console.WriteLine("2. Update Satff");
            Console.WriteLine("3. Show List All Staff");
            Console.WriteLine("4. Delete Staff");
            Console.WriteLine("5. Search Staff");
        }
        public void MenuHoaDon()
        {
            Console.WriteLine("1. Show Bill");
            Console.WriteLine("2. Delete Bill");
            Console.WriteLine("3. Update Bill");
            Console.WriteLine("4. Analyze Bill");
        }
        public void MenuFood()
        {
            Console.WriteLine("1. Show Food");
            Console.WriteLine("2. Delete Food");
            Console.WriteLine("3. Update Food");
            Console.WriteLine("4. Analyze");
        }
        public void MenuAccount()
        {
            Console.WriteLine("Create Account");
            Console.WriteLine("Update Account");
            Console.WriteLine("Delete Account");
            Console.WriteLine("Show List Account");
        }
    }
}
