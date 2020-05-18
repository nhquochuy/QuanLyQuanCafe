using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    class Table
    {
        private int iD;

        private string name;

        private string isType;

        public int TableW = 120;
        public int TableH = 120;
        public Table(int id, string name, string istype)
        {
            this.iD = id;
            this.name = name;
            this.isType = istype;
        }

        public Table(DataRow dtRow)
        {
            this.iD = (int)dtRow["ID"];
            this.name = dtRow["Name"].ToString();
            this.isType = dtRow["IsTypeValue"].ToString();
        }

        public int ID { get => iD;  set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string IsType { get => isType; set => isType = value; }
    }
}
