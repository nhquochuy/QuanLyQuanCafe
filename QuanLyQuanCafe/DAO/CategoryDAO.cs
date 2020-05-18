using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class CategoryDAO
    {
        private static CategoryDAO instance;

        internal static CategoryDAO Instance 
        { 
            get => (instance == null)? new CategoryDAO() : instance; 
            private set => instance = value; 
        }

        public List<Category> GetCategory()
        {
            List<Category> categories = new List<Category>();

            string query = "exec S_GetCategoryList";

            DataTable dt = DataProvider.Intstance.ExcuteQuery(query);

            foreach(DataRow dr in dt.Rows)
            {
                Category category = new Category(dr);
                categories.Add(category);
            }

            return categories;
        }

        public Category GetCategoryIDByID(int pID)
        {
            string query = "Select * from FoodCategory where ID = " + pID;

            DataTable dt = DataProvider.Intstance.ExcuteQuery(query);
            Category category = new Category(dt.Rows[0]);
            return category;
        }
    }
}
