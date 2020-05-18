using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value;}
        }

        public bool Login(string username, string password)
        {
            string query = "select count(*) from Account where username = '" + username + "' and password = '" + password + "'" ;
           // int re = 0;
            if(int.TryParse(DataProvider.Intstance.ExecuteScalar(query).ToString(), out int re) && re > 0)
            {
                return true;
            }
            else
                return false;
        }

        public List<Account> GetAccountByUserName(string pUserName)
        {
            List<Account> accounts = new List<Account>();
            string query = "exec S_GetAccountByUsername @username";

            DataTable dataTable = DataProvider.Intstance.ExcuteQuery(query, new object[] { pUserName });

            foreach(DataRow dr in dataTable.Rows)
            {
                Account account = new Account(dr);
                accounts.Add(account);
            }
            return accounts;
        }

        public bool ChangePass(string username, string password)
        {
            string query = "exec S_ChangePassword @UserName, @NewPass";
            return DataProvider.Intstance.ExcuteNonQuery(query, new object[] { username, password }) > 0;
        }

        public void ChangeAccInfo(string username, string displayName, int isType)
        {
            string query = "exec S_ChangeAccountInfo @UserName, @DisplayName, @IsType";
            DataProvider.Intstance.ExcuteNonQuery(query, new object[] { username, displayName, isType });
        }
    }
}
