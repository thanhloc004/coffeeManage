using Controllers.Implement_Class;
using Microsoft.Win32.SafeHandles;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManage
{
    public class BillDAO
    {
        public void Menu()
        {
            int choose = 0;
            do
            {
                MenuBill();
                Console.Write("Enter choose option: "); choose = int.Parse(Console.ReadLine());
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
                            Case5();
                            break;
                        }
                        
                }
            } while (choose != 0);
        }
        void MenuBill()
        {
            Console.WriteLine("1. Oder");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Search Bill");
            Console.WriteLine("5. Analyze Bill");
        }
        void Case1()
        {
            
            // hien thi danh sach ban trong
            var listTable = TableController.Instance.GetByTableDrum();
            Console.WriteLine("Danh sach ban con trong");
            Console.WriteLine("|---------------------|");
            Console.WriteLine("|STT | Ban | status   |");
            Console.WriteLine("|---------------------|");
            listTable.ToList().ForEach(x =>
            {
                Console.WriteLine($"|{x.ID,-4}|{x.ID,-5}|{x.Status,-10}|");
            });
            Console.WriteLine("|---------------------|");
            // chon ban de oder
            Console.Write("Enter Table name: ");
            int iDTable = int.Parse(Console.ReadLine());
            if(TableController.Instance.checkDrum(iDTable)== true) // ban trong thi oder
            {
                Bill bill = new Bill();
                bill.IDTable = iDTable;
                bill.ID = ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds(); 
                
                bill.DateCheckIn = DateTime.Now;
                char c;
                do
                {
                    Console.Write("Enter Food name: "); string foodName = Console.ReadLine(); // search food name
                    var resultFoodName = FoodController.Instance.GetByName(foodName);
                    var count = resultFoodName.Count();
                    if (--count >= 0)
                    {
                        Console.WriteLine("|--- |-- |---------------|");
                        Console.WriteLine("|STT |ID | Food Name     |");
                        Console.WriteLine("|------------------------|");
                        resultFoodName.ToList().ForEach(x =>
                        {
                            int i = 0;
                            Console.WriteLine($"|{++i,-4}|{x.ID,-3}|{x.FoodName,-15}|");
                        });
                        Console.WriteLine("|------------------------|");
                        
                        int idFood;
                        do
                        {
                            Console.Write("Enter ID food: ");
                            idFood = int.Parse(Console.ReadLine());
                            if (FoodController.Instance.GetByID(idFood) == true) // dung ID food thi khoi tao BillInfo
                            {
                                Console.Clear();
                                BillInfo info = new BillInfo();
                                info.IDBill = bill.ID;
                                info.IDFood = idFood;
                                Console.Write("Enter quantity number: ");
                                info.Count = Convert.ToInt32(Console.ReadLine());
                                BillInfoController.Instance.Create(info);
                            }
                            else
                            {
                                Console.WriteLine("ban nhap sai ID food!!!");
                            }
                        } while (FoodController.Instance.GetByID(idFood) != true);
                    }
                    else
                    {
                        Console.WriteLine("khong tim thay mon an");
                    }
                    Console.Write("Ban co muon them mon khong ? (y/n): ");
                    c = char.Parse(Console.ReadLine());
                } while (c != 'n');
                BillContrloller.Instance.Create(bill);
                var table = TableController.Instance.GetByID(iDTable);
                table.Status = "co nguoi";
                Console.WriteLine("them hoa don thanh cong!");
            }
            else
            {
                Console.WriteLine("Ban nay da co nguoi!!!");
            }
        }// ket thuc Case1
        void Case2() // Update Bill
        {
            var listTablePeople = TableController.Instance.GetByListTablePeople();
            Console.WriteLine("Danh sach ban co nguoi");
            Console.WriteLine("|---------------------|");
            Console.WriteLine("|STT | Ban | status   |");
            Console.WriteLine("|---------------------|");
            listTablePeople.ToList().ForEach(x =>
            {
                Console.WriteLine($"|{x.ID,-4}|{x.ID,-5}|{x.Status,-10}|");
            });
            Console.WriteLine("|---------------------|");
            Console.Write("nhap ID ban can sua hoa don: ");
            int idTable = Convert.ToInt32(Console.ReadLine());
            if (TableController.Instance.CheckByIDPeople(idTable) == true)
            {
                int i = 0;
                var menuBill = MenuBilController.Instance.GetByMenuBill(idTable);
                Console.WriteLine("|---|---------------|----------|------|");
                Console.WriteLine("|STT| Food Name     | Price    | Count|");
                Console.WriteLine("|-------------------------------------|");
                foreach (var item in menuBill)
                {
                    Console.WriteLine($"|{++i,-3}|{item.FoodName,-15}|{item.Price,-10}|{item.Count,-6}|");
                }
                int choose = 0;
                switch(choose)
                {
                    case 1:
                        {
                            int idFood = int.Parse(Console.ReadLine());
                            if (FoodController.Instance.GetByID(idFood) == true)
                            {
                                BillInfoController.Instance.Delete(idFood);
                            }
                            break;
                        }
                        case 2:
                        {
                            var result = BillContrloller.Instance.GetByIDYable(idTable);
                            char c;
                            do
                            {
                                Console.Write("Enter Food name: "); string foodName = Console.ReadLine(); // search food name
                                var resultFoodName = FoodController.Instance.GetByName(foodName);
                                var count = resultFoodName.Count();
                                if (--count >= 0)
                                {
                                    Console.WriteLine("|--- |-- |---------------|");
                                    Console.WriteLine("|STT |ID | Food Name     |");
                                    Console.WriteLine("|------------------------|");
                                    resultFoodName.ToList().ForEach(x =>
                                    {
                                        int i = 0;
                                        Console.WriteLine($"|{++i,-4}|{x.ID,-3}|{x.FoodName,-15}|");
                                    });
                                    Console.WriteLine("|------------------------|");
                                    int idFood;
                                    do
                                    {
                                        Console.Write("Enter ID food: ");
                                        idFood = int.Parse(Console.ReadLine());
                                        if (FoodController.Instance.GetByID(idFood) == true) // dung ID food thi khoi tao BillInfo
                                        {
                                            Console.Clear();
                                            BillInfo info = new BillInfo();
                                            info.IDBill = result.ID;
                                            info.IDFood = idFood;
                                            Console.Write("Enter quantity number: ");
                                            info.Count = Convert.ToInt32(Console.ReadLine());
                                            BillInfoController.Instance.Create(info);
                                        }
                                        else
                                        {
                                            Console.WriteLine("ban nhap sai ID food!!!");
                                        }
                                    } while (FoodController.Instance.GetByID(idFood) != true);
                                }
                                else
                                {
                                    Console.WriteLine("khong tim thay mon an");
                                }
                                Console.Write("Ban co muon them mon khong ? (y/n): ");
                                c = char.Parse(Console.ReadLine());
                            } while (c != 'n');
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Ban chua co nguoi or khong ton tai");
            }
        }
       /* void Case3()
        {
            Console.Write("Nhap ID Bill Can xoa: ");
            long iDBill = long.Parse(Console.ReadLine());
            if(BillContrloller.Instance.Delete(iDBill) == true)
            {

                Console.WriteLine("xoa thanh cong ");
                return;
            }
            else
            {
                Console.WriteLine("khong tim thay ID");
            }

        }*/
        void Case5()
        {
            var listTablePeople = TableController.Instance.GetByListTablePeople();
            Console.WriteLine("Danh sach ban co nguoi");
            Console.WriteLine("|---------------------|");
            Console.WriteLine("|STT | Ban | status   |");
            Console.WriteLine("|---------------------|");
            listTablePeople.ToList().ForEach(x =>
            {
                Console.WriteLine($"|{x.ID,-4}|{x.ID,-5}|{x.Status,-10}|");
            });
            Console.WriteLine("|---------------------|");
            Console.Write("nhap ID ban: ");
            int idTable = Convert.ToInt32(Console.ReadLine());
            List <MenuBill> listMenu = MenuBilController.Instance.GetByMenuBill(idTable);
            decimal totalPrice = 0;
            Console.WriteLine("|----------------------------------------------------|");
            Console.WriteLine("|STT|     Food Name     | Price | Count | TotalPrice |");
            Console.WriteLine("|----------------------------------------------------|");
            int i = 0;
            decimal total = 0;
            foreach(var item in listMenu)
            {
                Console.WriteLine($"|{++i,-3}|{item.FoodName,-20}|{item.Price,-7}|{item.Count,-7}|{item.TotalPrice,-12}|");
                total += item.TotalPrice;
            }
            Console.WriteLine($"|>>>>>: Can phai thanh toan:{total}");
            Console.WriteLine("|----------------------------------------------------|");
        }
    }
}
