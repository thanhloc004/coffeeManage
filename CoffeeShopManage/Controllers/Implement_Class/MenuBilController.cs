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
        List<MenuBill> listMenuBill = new List<MenuBill>();
        public List<MenuBill> GetByMenuBill()
        {
            decimal total = 0;
            var listBill = BillContrloller.Instance.GetByListAllBill();
            var listInfo = BillInfoController.Instance.GetByListInfoAll();
            var listFood = FoodController.Instance.GetByListFoodAll();
            var result = from b in listBill
                         from bi in listInfo
                         from f in listFood
                         where bi.IDBill == b.ID && bi.IDFood == f.ID
                         select new
                         {
                             IDbill  = b.ID,
                             nameFood = f.FoodName,
                             price = f.Price * bi.Count,
                             Count = bi.Count,
                         };

            result.ToList().ForEach(x =>
            {
                MenuBill menu = new MenuBill(x.IDbill, x.nameFood, x.price, x.Count, total);
                listMenuBill.Add(menu);
            });
            return listMenuBill;
        }
    }
}
