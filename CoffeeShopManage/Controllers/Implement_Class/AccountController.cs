using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Controllers.Implement_Class
{
    public class AccountController : SuperClass<Account>
    {
        private static AccountController instance;
        public static AccountController Instance
        {
            get { if (instance == null) instance = new AccountController(); return instance; }
            private set { AccountController.instance = value; }
        }
        private AccountController() { }
        List<Account> accounts = new List<Account>()
        {
            new Account(1,"0372249905","thanhloc","Admin")
        };

        public override void Create(Account model)
        {
            accounts.Add(model);
        }
        public bool Login(string userName,string passWord)
        {
            var result = accounts.Find(x=>x.UserName == userName && x.PassWord == passWord);
           if(result != null)
            {
                Const.LoaiTaiKhoan = result.Power;
                
                return true;
            }
            return false;
        }
        public bool CheckUserName(string name)
        {
            return accounts.Where(x=>x.UserName == name).Any();
        }
        public override bool Update(Account model, int ID)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
