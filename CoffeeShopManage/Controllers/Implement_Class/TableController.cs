using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Implement_Class
{
    public class TableController
    {
        private static TableController instance;
        public static TableController Instance
        {
            get { if (instance == null) instance = new TableController(); return instance; }
            private set { TableController instance = value; }
        }
        private TableController() {}
        List<Table> tableList = new List<Table>()
        {
                new Table (1,"trong"),
                new Table (2,"trong"),
                new Table (3,"trong"),
                new Table (4,"trong"),
                new Table (5,"trong"),
                new Table (6,"trong"),
                new Table (7,"trong"),
                new Table (8,"trong"),
                new Table (9,"trong"),
                new Table (10,"trong"),
        };
        public List<Table> GetByListTableAll()
        {
            return tableList;
        }
        public Table GetByID(int iD)
        {
            return tableList.Find(x => x.ID == iD);
        }
        public bool GetByIDTanleBill(int iD)
        {
            return tableList.Where(x => x.ID == iD).Any();
        }
        public List<Table> GetByTableDrum()
        {
            return tableList.Where(x => x.Status == "trong").ToList();
        }
        public bool checkDrum(int iD)
        {
            return tableList.Where(x=>x.ID ==iD).Any();
        }
        public List<Table> GetByListTablePeople()
        {
            return tableList.Where(x => x.Status == "co nguoi").ToList();
        }
        public bool CheckByIDPeople(int iD)
        {
            return tableList.Where(x=>x.Status == "co nguoi").Any();
        }
    }
}
