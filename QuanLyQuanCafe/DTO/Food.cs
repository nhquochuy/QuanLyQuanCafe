using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    class Food
    {
        private int iD;
        private string name;
        private int iD_FoodCategory;
        private double price;

        public Food(int pID, string pName, int pID_Category, double pPrice)
        {
            this.iD = pID;
            this.name = pName;
            this.iD_FoodCategory = pID_Category;
            this.price = pPrice;
        }

        public Food(DataRow dr)
        {
            this.iD = (int)dr["ID"];
            this.name = dr["Name"].ToString();
            this.iD_FoodCategory = (int)dr["ID_FoodCategory"];
            this.price = (double)dr["Price"];
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int ID_FoodCategory { get => iD_FoodCategory; set => iD_FoodCategory = value; }
        public double Price { get => price; set => price = value; }
    }
}
