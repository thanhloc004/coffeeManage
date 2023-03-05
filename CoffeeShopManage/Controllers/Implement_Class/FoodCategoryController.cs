using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers.Implement_Class
{
    public class FoodCategoryController
    {
        private static FoodCategoryController instance;
        public static FoodCategoryController Instance
        {
            get { if (instance == null) instance = new FoodCategoryController(); return instance; }
            private set { FoodCategoryController.instance = value; }
        }
        private FoodCategoryController() { }
        List<FoodCategory> listCategory = new List<FoodCategory>()
        {
            new FoodCategory (000001,"nong"),
            new FoodCategory (000002,"lanh"),
            new FoodCategory (000002,"coffee"),
            new FoodCategory (000002,"tra sua"),
        };
        public List<FoodCategory> GetByListCategorAll()
        {
            return listCategory;
        }
        public FoodCategory GetByName(string name)
        {
            return listCategory.Find(x =>x.NameCategory == name);
        }
    }
}
