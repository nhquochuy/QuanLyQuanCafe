using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class BillInfoDAO
    {
        private static BillInfoDAO instance;

        internal static BillInfoDAO Instance
        { 
            get => (instance == null)? new BillInfoDAO() : instance; 
            private set => instance = value; 
        }

        public BillInfoDAO() { }

        public int UpadteBillInfo(string UserName, int ID_TableFood, int Status)
        {
            string query = "exec S_UpadteBillInfo @UserName, @ID_TableFood, @Status";

            return Convert.ToInt32(DataProvider.Intstance.ExecuteScalar(query, new object[] { UserName, ID_TableFood, Status }));
        }

        public int GetBillInfoByTableID(int TableID)
        {
            string query = "exec S_GetBillInfoByTableID @TableID";
            object re = DataProvider.Intstance.ExecuteScalar(query, new object[] { TableID });

            return (re == null) ? 0 : (int)re; 
        }

        public DataTable GetRevenueReport(DateTime dtFromdate, DateTime dtTodate)
        {
            DataTable dt = new DataTable();
            string query = "exec S_RevenueReport @FromDate, @ToDate";
            return DataProvider.Intstance.ExcuteQuery(query, new object[] { dtFromdate, dtTodate });
        }
    }
}
