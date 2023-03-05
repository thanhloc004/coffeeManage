using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Temp
    {
        // Hien ra sanh sach ban con trong
       /* var tables = TableController.Instance.GetByListTableAll();
        var result = from table in tables
                     where table.Status == "trong"
                     select table;
        Console.WriteLine("Danh sach ban con trong");
            Console.WriteLine("|---------------------|");
            Console.WriteLine("|STT | Ban | status   |");
            Console.WriteLine("|---------------------|");
            result.ToList().ForEach(x =>
            {
            Console.WriteLine($"|{x.ID,-4}|{x.ID,-5}|{x.Status,-10}|");
        });
            Console.WriteLine("|---------------------|");
            char c;
        int i = 0;
            // Oder food
            do
            {
                Console.Write("Enter Table: ");int iDTable = int.Parse(Console.ReadLine());
                if (TableController.Instance.GetByIDTanleBill(iDTable) == true) // kiem tra xem ID ban da nhap dung chua
                {
                    Bill bill = new Bill(); // khoi tao bill
        bill.IDTable = iDTable;
                    bill.ID = ((DateTimeOffset) DateTime.Now).ToUnixTimeMilliseconds();
        bill.DateCheckIn = DateTime.Now;
                    do
                    {
                        // tim kiem food
                        Console.Write("Enter Food name: ");
                        string name = Console.ReadLine();
        var resultNameFood = FoodController.Instance.GetByName(name);
                        if (resultNameFood != null)
                        {
                            Console.WriteLine("|--- |-- |---------------|");
                            Console.WriteLine("|STT |ID | Food Name     |");
                            Console.WriteLine("|------------------------|");
                            resultNameFood.ToList().ForEach(x =>
                            {

            Console.WriteLine($"|{++i,-3}|{x.ID,-3}|{x.FoodName,-15}|");
        });
                            Console.WriteLine("|------------------------|");
                            
                            // khoi tao billinfo
                            do
                            {
                                Console.Write("Enter ID food: "); int iDFood = int.Parse(Console.ReadLine());
                                if (FoodController.Instance.GetByID(iDFood) == true) // kiem tra xem da nhap dung ID food chua 
                                {
                                    BillInfo info = new BillInfo();
        info.IDFood = iDFood;
                                    info.IDBill = bill.ID;
                                    Console.Write("Enter quantity: "); info.Count = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Nhap sai ID Food moi ban nhap lai");
                                }
                            }while (true) ;
                        }
                        Console.Write("ban co muon them nua khong (y/n)");
c = char.Parse(Console.ReadLine());
                    } while (c != 'n') ;
                } */
                    
    }
}
