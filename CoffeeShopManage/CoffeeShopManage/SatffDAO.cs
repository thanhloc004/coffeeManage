using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.Implement_Class;

namespace CoffeeShopManage
{
    public class SatffDAO
    {
       /* public void Menu() {
            int choose = 0;
            do
            {
                Console.Write("Enter Choose Option: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        {

                            break;
                        }
                    case 1:
                        {
                            Case1();
                            break;
                        }
                    case 2:
                        {
                            Case2();
                            break;
                        }
                    case 3:
                        {
                            Case2();
                            break;
                        }
                }
            } while (choose != 0);
        }
        void Case1()
        {
            char c;
            do
            {
                Staff staff = new Staff();
                Console.Write("Nhap ten nhan vien: ");
                staff.Name = Console.ReadLine();
                int iDStaff;
                do
                {
                    Console.Write("Nhap ID Nhan vien: ");
                    iDStaff = int.Parse(Console.ReadLine());
                } while (StaffController.Instance.checkID(iDStaff) != true);
               staff.ID = iDStaff;
                Console.Write("Nhap CMND: ");
                staff.CMND = Console.ReadLine();
                staff.Status = "nhan vien";
                Console.Write("Ban co muon them nhan vien nua khong (y/n): ");
                c = char.Parse(Console.ReadLine());
            } while (c != 'n');
        }
        void Case2()
        {
            Console.Write("Nhap ten nhan vien: ");
            string name = Console.ReadLine();
            var result = StaffController.Instance.GetByName(name);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|STT|ID  |Name              |");
            Console.WriteLine("-----------------------------");
            int i = 0;
            foreach (var item in result)
            {
                Console.WriteLine($"|{++i,-3}|{item.ID,-5}|{item.Name,-19}|");
            }
            Console.WriteLine("-----------------------------");
            int iDStaff;
            do
            {
                iDStaff = int.Parse(Console.ReadLine());
                Console.Write("Nhap ID nhan vien can xoa: ");
                /*if (StaffController.Instance.checkID(iDStaff) == true)
                {
                    StaffController.Instance.Delete(iDStaff);
                    Console.WriteLine("xoa thanh cong nhan vien");
                }
                else Console.WriteLine("Khong tim thay ID nhan vien nay");
            }while(StaffController.Instance.checkID(iDStaff) != true);
        }
        void Case3()
        {
            Console.Write("Nhap ten nhan vien can sua: ");
            Console.Write("Nhap ten nhan vien: ");
            string name = Console.ReadLine();
            var result = StaffController.Instance.GetByName(name);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|STT|ID  |Name              |");
            Console.WriteLine("-----------------------------");
            int i = 0;
            foreach (var item in result)
            {
                Console.WriteLine($"|{++i,-3}|{item.ID,-5}|{item.Name,-19}|");
            }
            Console.WriteLine("-----------------------------");
            int iDStaff;
            do
            {
                iDStaff = int.Parse(Console.ReadLine());
                Console.Write("Nhap ID nhan vien can sua: ");
                if (StaffController.Instance.checkID(iDStaff) == true)
                {
                    Staff staff = new Staff();
                    Console.Write("nhap ten moi: ");
                    staff.Name = Console.ReadLine();
                    Console.Write("nhap cmnd moi: ");
                    staff.CMND = Console.ReadLine();
                }
                else Console.WriteLine("Khong tim thay ID nhan vien nay");
            } while (StaffController.Instance.checkID(iDStaff) != true);
        }*/
    }
}
