using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Implement_Class
{
    public class BillInfoController : SuperClass<BillInfo>
    {
        private static BillInfoController instance;
        public static BillInfoController Instance
        {
            get { if (instance == null) instance = new BillInfoController(); return instance; }
            private set { BillInfoController.instance = value; }
        }
        private BillInfoController() { }
        List<BillInfo> listInfo = new List<BillInfo>();
        public List<BillInfo> GetByListInfoAll()
        {
            return listInfo;
        }

        public override void Create(BillInfo model)
        {
            listInfo.Add(model);
        }

        public override bool Update(BillInfo model, int ID)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
