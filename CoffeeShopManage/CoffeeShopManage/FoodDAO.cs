using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Controllers.Implement_Class;

namespace CoffeeShopManage
{
    public class FoodDAO
    {
        public void Menu()
        {
            Case1();
            //Case5();
        }
        void MenuFood()
        {
            Console.WriteLine("1. Add Food");
            Console.WriteLine("2. Delete Food");
            Console.WriteLine("3. Update Food");
            Console.WriteLine("4. Search Food");
            Console.WriteLine("5. Search Food by Category");
        }
        void Case1()
        {
            char character;
            do
            {
                char c;
                Console.Write("Nhap loai do uong ban muon them: ");
                string name = Console.ReadLine();
                var result = FoodCategoryController.Instance.GetByName(name);
                if(result !=null)
                {
                    do
                    {
                        Food food = new Food();
                        do
                        {
                            Console.Write("Enter ID food: ");
                            food.ID = Convert.ToInt32(Console.ReadLine());
                        } while (FoodController.Instance.GetByID(food.ID) == true);
                        food.IDCategory = result.ID;
                        Console.Write("Enter food name: ");
                        food.FoodName = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        food.Price = Convert.ToDecimal(Console.ReadLine());
                        FoodController.Instance.Create(food);
                        Console.Write("Ban co muon them nua khong ? (y/n)");
                        c = char.Parse(Console.ReadLine());
                    } while (c != 'n');
                
                }
                else
                {
                    Console.WriteLine("khong tim thay loai do uong nay !!!");
                    Console.WriteLine("Ban co muon nhap lai khong ? (Y / N)");
                }
                Console.Write("ban co muon nhap nua khong: ");
                character = char.Parse(Console.ReadLine());
            } while (character != 'n');
        }
        void Case2()
        {
            Console.Write("Enter ID food: ");
            int iD = Convert.ToInt32(Console.ReadLine());
            if (FoodController.Instance.Delete(iD) == true) {
                Console.WriteLine("xoa thanh cong!");
            } else  Console.WriteLine("khong tim thay ID");
        }
        void Case3()
        {
            Console.Write("Enter Food name: ");
            string name = Console.ReadLine();
            var result = FoodController.Instance.GetByName(name);
            var listFood = from food in result
                           select food;
            Console.WriteLine("|---|---------------|----------|");
            Console.WriteLine("|STT| Food Name     | Price    |");
            Console.WriteLine("--------------------------------");
            int i = 0;
            listFood.ToList().ForEach(x =>
            {
                Console.WriteLine($"|{++i,-3}|{x.FoodName,-15}|{x.Price,-10}|");
            });
        }
        void Case4()
        {
            Console.Write("Enter Food name: ");
            string name = Console.ReadLine();
            var result = FoodController.Instance.GetByName(name);
            Console.WriteLine("|---|---------------|----------|");
            Console.WriteLine("|STT| Food Name     | Price    |");
            Console.WriteLine("--------------------------------");
            int i = 0;
            result.ForEach(x =>
            {
                Console.WriteLine($"|{++i,-3}|{x.FoodName,-15}|{x.Price,-10}|");
            });
            Console.WriteLine("--------------------------------");
        }
        void Case5()
        {
            var categorys = FoodCategoryController.Instance.GetByListCategorAll();
            var foods = FoodController.Instance.GetByListFoodAll();
            Console.Write("Enter Category name: "); string name = Console.ReadLine();
            var result = from food in foods
                         join category in categorys on food.IDCategory equals category.ID
                         group food by category.NameCategory;
            int i = 0;
            result.ToList().ForEach(x =>
            {
                Console.WriteLine($"Food Category name: {x.Key}");
                Console.WriteLine("|---|---------------|----------|");
                Console.WriteLine("|STT|Food Name      |Price     |");
                Console.WriteLine("--------------------------------");
                x.ToList().ForEach(x =>
                {
                    Console.WriteLine($"|{++i,-3}|{x.FoodName,-15}|{x.Price,-10}|");
                });
                Console.WriteLine("--------------------------------");
            });

           
        }
    }
}
