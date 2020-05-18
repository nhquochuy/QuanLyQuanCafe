using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    class Menu
    {
        private int iD;
        private string foodName;
        private int qty;
        private double price;
        private double amount;
        public Menu(int pID, string pFoodName, int pQty, double pPrice)
        {
            this.iD = pID;
            this.foodName = pFoodName;
            this.qty = pQty;
            this.price = pPrice;
            this.Amount = this.qty * this.price;
        }
        public Menu(DataRow dr)
        {
            this.iD = (int)dr["ID"];
            this.foodName = dr["FoodName"].ToString();
            this.qty = (int)dr["Qty"];
            this.price = (double)dr["Price"];
            this.Amount = this.qty * this.price;
        }


        public int ID { get => iD; set => iD = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int Qty { get => qty; set => qty = value; }
        public double Price { get => price; set => price = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
