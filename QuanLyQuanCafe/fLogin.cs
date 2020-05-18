using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

            LoadControl();
        }

        void LoadControl()
        {
            this.AcceptButton = btnLogin;
            this.CancelButton = btnExit;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( MessageBox.Show("Are you sure !!!","Notice", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.Login(txtUserName.Text, txtPassWord.Text))
            {
                Account currentAccount = AccountDAO.Instance.GetAccountByUserName(txtUserName.Text)[0];

                this.Visible = false;
                fTableManager fTableManager = new fTableManager(currentAccount);
                fTableManager.StartPosition = FormStartPosition.CenterScreen;
                fTableManager.ShowDialog();
                this.Visible = true;
            }
            else
                MessageBox.Show("Wrong Username or Password");
        }
    }
}