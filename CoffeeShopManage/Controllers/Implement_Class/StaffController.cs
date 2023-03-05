using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers.Implement_Class
{
    public class StaffController : SuperClass<Staff>
    {
        private static StaffController instance;
        public static StaffController Instance
        {
            get { if (instance == null) instance = new StaffController(); return instance; }
            set { StaffController.instance = value; }
        }
        private StaffController() { }

        List<Staff> listStaff = new List<Staff>();
        public bool Login(string userName,string passWord)
        {
            return listStaff.Where(x=>x.UserName == userName &&x.PassWord == passWord).Any();
        }
        public List<Staff> GetListAllSatff()
        {
            return listStaff;
        }

        public override void Create(Staff model)
        {
            listStaff.Add(model);
        }

        public override bool Update(Staff model, int ID)
        {
            var result = listStaff.SingleOrDefault(x=> x.ID == ID);
            int index = listStaff.IndexOf(result);
            listStaff[index] = model;
            return true;
        }

        public override bool Delete(int iD)
        {
            var result = listStaff.SingleOrDefault(x => x.ID == iD);
            if(result != null)
            {
                listStaff.Remove(result);
                return true;
            }
            return false;
        }
        public Staff GetByID(int iD)
        {
            return listStaff.SingleOrDefault(x => x.ID == iD);
        }
        public bool checkID(int iD)
        {
            return listStaff.Where(x=> x.ID == iD).Any();
        }
        public List<Staff> GetByName(string name)
        {
            return listStaff.Where(x=>x.Name == name).ToList();
        }
    }
}
