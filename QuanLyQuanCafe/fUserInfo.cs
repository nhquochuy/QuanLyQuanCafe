using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fUserInfo : Form
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public fUserInfo(Account acc)
        {
            InitializeComponent();
            this.Acc = acc;
            LoadControl();
        }

        public void LoadControl()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            txtUserName.Enabled = false;
            //panel4.Enabled = false;

            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;

            if (acc.IsType == 0) rbtAdmin.Checked = true;
            else rbtStaff.Checked = true;

            this.CancelButton = btnExit;

            this.AcceptButton = btnUpdateInfo;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            fChangePass fChangePass = new fChangePass(acc);
            fChangePass.ShowDialog();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            AccountDAO.Instance.ChangeAccInfo(txtUserName.Text, txtDisplayName.Text, (rbtAdmin.Checked) ? 0 : 1);
            EventHandler<EvArg_DisplayName> ev = (EventHandler<EvArg_DisplayName>)evList[lsEvent[(int)enEvent.UpdateDisplayName]];
            //if(ev != null)
            //{
                ev(this, new EvArg_DisplayName(AccountDAO.Instance.GetAccountByUserName(txtUserName.Text)[0]));
            //}
            //this.Close();

            EventHandler<EvArg_UpdateType> evUpdateType = (EventHandler<EvArg_UpdateType>)evList[lsEvent[(int)enEvent.UpdateType].ToString()];
            evUpdateType(this, new EvArg_UpdateType(AccountDAO.Instance.GetAccountByUserName(txtUserName.Text)[0]));
        }

        public EventHandlerList evList = new EventHandlerList();

        //private event EventHandler<EvArg_DisplayName> _EVUpdateDisplayName;
        public event EventHandler<EvArg_DisplayName> EVUpdateDisplayName
        {
            add => evList.AddHandler("UpdateDisplayName", value);
            remove => evList.RemoveHandler("UpdateDisplayName", value);
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            EventHandler<EvArg_UpdateType> evUpdateType = (EventHandler<EvArg_UpdateType>)evList[lsEvent[(int)enEvent.UpdateType].ToString()];
            evUpdateType(this, new EvArg_UpdateType(AccountDAO.Instance.GetAccountByUserName(txtUserName.Text)[0]));
        }

        //private event EventHandler<EvArg_UpdateType> _EVUpdateType;
        public event EventHandler<EvArg_UpdateType> EVUpdateType
        {
            add => evList.AddHandler("UpdateType", value);
            remove => evList.RemoveHandler("UpdateType", value);
        }

        static List<string> lsEvent = new List<string> { "UpdateDisplayName", "UpdateType" };
        enum enEvent { UpdateDisplayName, UpdateType };
    }

    public class EvArg_DisplayName : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get => acc;
            set => this.acc = value;
        }

        public EvArg_DisplayName(Account pAcc)
        {
            this.Acc = pAcc;
        }
    }

    public class EvArg_UpdateType : EventArgs
    {
        private Account acc;
        public Account Acc
        {
            get => acc;
            set => this.acc = value;
        }

        public EvArg_UpdateType(Account pAcc)
        {
            this.Acc = pAcc;
        }
    }

}
