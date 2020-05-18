using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    class Category
    {
        private int iD;
        private string name;
        public Category(int pID, string pName)
        {
            this.iD = pID;
            this.name = pName;
        }

        public Category(DataRow dr)
        {
            this.iD = (int)dr["ID"];
            this.name = dr["Name"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
