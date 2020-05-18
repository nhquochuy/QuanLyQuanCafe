using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Account
    {
        private string userName;
        private string displayName;
        private string passWord;
        private int isType;

        public Account(string pUserName, string pDisplayName, int pIsType, string pPass = null)
        {
            this.UserName = pUserName;
            this.DisplayName = pDisplayName;
            this.PassWord = pPass;
            this.IsType = pIsType;
        }

        public Account(DataRow dr)
        {
            this.UserName = dr["UserName"].ToString();
            this.DisplayName = dr["DisplayName"].ToString();
            this.PassWord = dr["PassWord"].ToString();
            this.IsType = (int)dr["IsType"];
        }

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int IsType { get => isType; set => isType = value; }
    }
}
