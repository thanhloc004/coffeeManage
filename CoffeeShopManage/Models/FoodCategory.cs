using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FoodCategory
    {
        public long  ID { get; set; }
        public string NameCategory { get; set; }
        public FoodCategory(long iD,string nameCategory)
        {
            this.ID = iD;
            this.NameCategory = nameCategory;
        }
    }
}
