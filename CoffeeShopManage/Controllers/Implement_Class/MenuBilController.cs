using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers.Implement_Class
{
    public class MenuBilController
    {
        private static MenuBilController instance;
        public static MenuBilController Instance
        {
            get { if (instance == null) instance = new MenuBilController(); return instance; }
            private set { MenuBilController.instance = value; }
        }
        private MenuBilController() { }
        
        public List<MenuBill> GetByMenuBill(int iD)
        {
            List<MenuBill> listMenuBill = new List<MenuBill>();
            var listBill = BillContrloller.Instance.GetByListAllBill();
            var listInfo = BillInfoController.Instance.GetByListInfoAll();
            var listFood = FoodController.Instance.GetByListFoodAll();
            var result = from b in listBill
                         from bi in listInfo
                         from f in listFood
                         where bi.IDBill == b.ID && bi.IDFood == f.ID && b.IDTable == iD
                         select new
                         {
                             nameFood = f.FoodName,
                             price = f.Price,
                             Count = bi.Count,
                             totalPrice = f.Price * bi.Count
                         };

            result.ToList().ForEach(x =>
            {
                MenuBill menu = new MenuBill( x.nameFood, x.price, x.Count, x.totalPrice);
                listMenuBill.Add(menu);
            });
            return listMenuBill;
        }
        
    }
}
