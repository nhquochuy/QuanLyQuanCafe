using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get => (instance == null)? new TableDAO() : instance;
            private set => instance = value;
        }

        public List<Table> ListTable()
        {
            List<Table> tables = new List<Table> ();

            DataTable dataTable = new DataTable();

            string strQuery = "exec S_GetTableList";
            dataTable = DataProvider.Intstance.ExcuteQuery(strQuery);

            foreach(DataRow dr in dataTable.Rows)
            {
                Table drTable = new Table(dr);
                tables.Add(drTable);
            }
            return tables;
        }

        public void CheckIn(int TableID)
        {
            string query = "Update TableFood set IsType = 1 where ID = " + TableID.ToString();

            DataProvider.Intstance.ExcuteNonQuery(query);
        }

        public void CheckOut(int TableID, int BillInfoID)
        {
            string query = "Update TableFood set IsType = 0 where ID = " + TableID.ToString();
            DataProvider.Intstance.ExcuteNonQuery(query);

            string query2 = "Update BillInfo set Status = 1 where ID = " + BillInfoID.ToString();
            DataProvider.Intstance.ExcuteNonQuery(query2);
        }

        public void ChangeTable(int FromTable_ID, int ToTable_ID)
        {
            string query = "exec S_ChangeTable @FromTable_ID, @ToTable_ID";
            DataProvider.Intstance.ExcuteNonQuery(query, new object[] { FromTable_ID, ToTable_ID });
        }

        public void MergeTable(int FromTable_ID, int ToTable_ID)
        {
            string query = "exec S_MergeTable @FromTable_ID, @ToTable_ID";
            DataProvider.Intstance.ExcuteNonQuery(query, new object[] { FromTable_ID, ToTable_ID });
        }
    }
}
