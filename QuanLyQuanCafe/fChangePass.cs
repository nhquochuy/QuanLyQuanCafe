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
    public partial class fChangePass : Form
    {
        private Account acc;
        public Account Acc { get => acc; set => acc = value; }

        public fChangePass(Account acc)
        {
            InitializeComponent();

            this.Acc = acc;
            LoadControl();
        }

        public void LoadControl()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnUpdate;
            this.CancelButton = btnCancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtReEnter.Text)
            {
                MessageBox.Show("Your new Password and Re-enter Password are not match"); return; ;
            }
            if (txtPass.Text != acc.PassWord)
            {
                MessageBox.Show("Wrong Password"); return;
            }

            if(AccountDAO.Instance.ChangePass(acc.UserName, txtNewPass.Text))
            {
                MessageBox.Show("Changed password successfull !!");
                this.Close();
            }
        }
    }
}
