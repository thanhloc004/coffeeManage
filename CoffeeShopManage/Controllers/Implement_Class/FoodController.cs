using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Controllers.Interface;

namespace Controllers.Implement_Class
{
    public class FoodController : SuperClass<Food>,ISuper<Food>
    {
        private static FoodController instance;
        public static FoodController Instance
        {
            get { if (instance == null) instance = new FoodController(); return instance; }
            private set { FoodController.instance = value; }
        }
        private FoodController() {}
        List<Food> listFood = new List<Food>();
        public List<Food> GetByListFoodAll()
        {
            return listFood;
        }
        public bool GetByID(int iD)
        {
            return listFood.Where(x=>x.ID == iD).Any();
        }
        public override void Create(Food model)
        {
            listFood.Add(model);
        }

        public override bool Update(Food model, int ID)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int iD)
        {
            var result = listFood.SingleOrDefault(x=>x.ID == iD);
            if(result != null)
            {
                listFood.Remove(result);
                return true;
            }
            return false;
                            
        }

        public List<Food> GetByName(string name)
        {
            var result = from food in listFood
                         where food.FoodName.Contains(name)
                         select food;
            return result.ToList();
        }
    }
}
