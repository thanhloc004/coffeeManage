using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Implement_Class
{
    public abstract class SuperClass<T>
    {
        public abstract void Create(T model);
        public abstract bool Update(T model,int ID);
        public abstract bool Delete(int ID);
    }
}
