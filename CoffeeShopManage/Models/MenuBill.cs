﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MenuBill
    {
        public long IDbill { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public MenuBill(long id,string name,decimal price,int count,decimal totalPrice=0)
        {
            this.IDbill = id;
            this.FoodName = name;
            this.Price = price;
            this.Count = count;
            this.TotalPrice = totalPrice;
        }

    }
    
}
