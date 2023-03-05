using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Interface
{
    public interface ISuper<T>
    {
        List<T> GetByName(string name);
    }
}
