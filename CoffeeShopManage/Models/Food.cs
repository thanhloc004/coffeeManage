using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Food
    {
        public int ID {  get; set; }
        public string FoodName { get; set; }
        public long IDCategory { get; set; }
        public decimal Price { get; set; }
    }
}
