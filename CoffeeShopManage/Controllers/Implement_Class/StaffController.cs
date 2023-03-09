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

        public override void Create(Staff model)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Staff model, int ID)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int ID)
        {
            throw new NotImplementedException();
        }
    }
    


}
