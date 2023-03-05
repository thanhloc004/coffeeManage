

namespace CoffeeShopManage
{
    public class Program
    {
        private static void Main(string[] args)
        {
            FoodDAO food = new FoodDAO();
            food.Menu();
            BillDAO dao = new BillDAO();
            dao.Menu();
            
        }
        void Login()
        {

        }
    }
}
