using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Table
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public Table(int iD, string status)
        {
            this.ID = iD;
            this.Status = status;
        }
    }
}
