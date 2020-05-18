using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get => (instance == null)? new MenuDAO() : instance;
            private set => instance = value;
        }

        public MenuDAO() { }

        public List<Menu> GetMenuByTableID(int ID)
        {
            List<Menu> lstMenu = new List<Menu>();

            string strQuery = "exec S_GetBilItemlByTableID @TableID";
            DataTable dt = DataProvider.Intstance.ExcuteQuery(strQuery, new object[] { ID });

            foreach(DataRow dr in dt.Rows)
            {
                Menu menu = new Menu((int)dr["ID"], dr["FoodName"].ToString(),(int)dr["Qty"] ,(double)dr["Price"]);
                lstMenu.Add(menu);
            }
            return lstMenu;
        }
    }
}
