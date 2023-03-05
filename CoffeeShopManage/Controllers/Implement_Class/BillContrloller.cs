using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers.Implement_Class
{
    public class BillContrloller : SuperClass<Bill>
    {
        private static BillContrloller instance;
        public static BillContrloller Instance
        {
            get { if (instance == null) instance = new BillContrloller(); return instance; }
            private set { BillContrloller.instance = value; }
        }
        private BillContrloller() { }
        List<Bill> listBill = new List<Bill>();
        public List<Bill> GetByListAllBill()
        {
            return listBill;
        }
        public override void Create(Bill model)
        {
            listBill.Add(model);
        }

        public override bool Update(Bill model, int ID)
        {
            throw new NotImplementedException();
        }

        /*public override bool Delete(long ID)
        {
            var result = listBill.Find(x => x.ID == ID);
            if(result != null)
            {
                listBill.Remove(result);
                return true;
            }
            else { return false; }
        }*/
        public Bill GetByID(int iD)
        {
            return listBill.Find(x => x.IDTable == iD);
        }
        public Bill GetByIDYable(int iD)
        {
            return listBill.Find(x => x.IDTable == iD);
        }

        public override bool Delete(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
