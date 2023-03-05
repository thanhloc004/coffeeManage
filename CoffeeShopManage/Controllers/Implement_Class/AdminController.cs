using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers.Implement_Class
{
    public class AdminController
    {
        private static AdminController instance;
        public static AdminController Instance
        {
            get { if (instance == null) instance = new AdminController(); return instance; }
            set { AdminController.instance = value; }
        }
        private AdminController() { }
        List<ADmin> Admin = new List<ADmin>() { new ADmin ("0372249905", "thanhloc", "Admin" ) };
        public bool Login(string username, string password)
        {
            return Admin.Where(x=>x.UserName == username&& x.PassWord == password).Any();
        }

    }
}
