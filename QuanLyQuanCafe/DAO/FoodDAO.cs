using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class FoodDAO
    {
        private static FoodDAO instance;

        internal static FoodDAO Instance 
        { 
            get => (instance == null)? new FoodDAO() : instance; 
            private set => instance = value; 
        }

        public List<Food> GetFoodByCateforyID(int CateID)
        {
            List<Food> foods = new List<Food>();

            string query = "exec S_GetFoodByCategoryID @ID_Category";
            DataTable dt = DataProvider.Intstance.ExcuteQuery(query, new object[] { CateID});
            foreach(DataRow dr in dt.Rows)
            {
                Food food = new Food(dr);
                foods.Add(food);
            }

            return foods;
        }

        public List<Food> GetListFood()
        {
            List<Food> lstFood = new List<Food>();

            string query = "Select * from food";

            DataTable dt = DataProvider.Intstance.ExcuteQuery(query);

            foreach(DataRow dr in dt.Rows)
            {
                Food food = new Food(dr);
                lstFood.Add(food);
            }
            return lstFood;
        }
    }
}
