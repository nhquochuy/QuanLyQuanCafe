using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class BillItemDAO
    {
        private static BillItemDAO instance;

        internal static BillItemDAO Instance 
        { 
            get => (instance == null)? new BillItemDAO() : instance; 
            private set => instance = value; 
        }

        public BillItemDAO() { }
        public void UpadteBillItem(int ID_BillInfo, int ID_Food, int Qty)
        {
            string query = "exec S_UpadteBillItem @ID_BillInfo, @ID_Food, @Qty";
            DataProvider.Intstance.ExcuteQuery(query, new object[] { ID_BillInfo, ID_Food, Qty });
        }
    }
}
