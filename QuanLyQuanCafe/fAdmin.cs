using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public BindingSource bsFood = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            Load();
        }

        #region Method
        void Load()
        {
            dtgvFood.DataSource = bsFood;
            LoadAccount();
            LoadFoodList();
            LoadControl();
            LoadRevenue();
            AddBingdingFood();
            AddDataIntoCB(cboFood_category);
        }
        public void LoadAccount()
        {
            string query = "exec S_GetAccountByUsername @username";

            dtgvAccount.DataSource = DataProvider.Intstance.ExcuteQuery(query, new Object[] { "huyquoc" });
        }

        public void LoadControl()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
            dtgRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "yyyy-MM-dd";
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.CustomFormat = "yyyy-MM-dd";
        }

        void AddBingdingFood()
        {
            txtFood_id.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            txtFood_name.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name"));
            nmrFood_price.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price"));
        }
        public void LoadRevenue()
        {
            dtgRevenue.DataSource = BillInfoDAO.Instance.GetRevenueReport(dtpFromDate.Value, dtpToDate.Value);
        }
        public void LoadFoodList()
        {
            bsFood.DataSource = FoodDAO.Instance.GetListFood();
            //dtgvFood.Click += DtgvFood_Click;
        }

        void AddDataIntoCB(ComboBox cb)
        {
            if (cb.Name == "cboFood_category")
            {
                cb.DataSource = CategoryDAO.Instance.GetCategory();
                cb.DisplayMember = "Name";
            }
        }
        #endregion

        #region Event
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadRevenue();
        }

        private void btnFood_view_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }
        #endregion

        private void txtFood_id_TextChanged(object sender, EventArgs e)
        {
            int ID_Category = -1;
            int index = -1;
            if (dtgvFood.SelectedCells.Count == 0) return;
            ID_Category = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["ID_FoodCategory"].Value;
            //comment test
            //ID_Category = CategoryDAO.Instance.GetCategoryIDByID(ID_Category).ID;
            int i = 0;
            foreach(Category item in cboFood_category.Items)
            {
                if(item.ID == ID_Category)
                {
                    index = i;
                    break;
                }
                i++;
            }

            cboFood_category.SelectedIndex = index;
        }
    }
}
