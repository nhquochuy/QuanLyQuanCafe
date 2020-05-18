using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyQuanCafe.DTO.Menu;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        delegate void dlgChanegDisplayName();


        private Account currentAccount;
        public Account CurrentAccount 
        {
            get { return currentAccount; }
            set { 
                currentAccount = value; 
                AccountRole(); 
            }
        }

        public fTableManager(Account currentAccount)
        {
            InitializeComponent();

            this.CurrentAccount = currentAccount;

            lblCurrentUserName.Text = currentAccount.DisplayName;
            LoadControl();
            LoadTable();
            LoadCategory();
        }

        void AccountRole()
        {
            mntAdmin.Enabled = currentAccount.IsType == 0;
        }

        #region Methods
        void LoadControl()
        {
            //fpnTable
            fpnTable.AutoScroll = true;
            // txtTotalAmount
            txtTotalAmount.Text = "0";
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // livBill
            livBill.View = View.Details;
            //livBill.Columns.Add("ID");
            livBill.Columns.Add("Product Name", 100);
            livBill.Columns.Add("Qty");
            livBill.Columns.Add("Price");
            livBill.Columns.Add("Amount");
            // cboFoodCategory
            cboFoodCategory.DisplayMember = "Name";
            // cboFood
            cboFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            fpnTable.Controls.Clear();
            List<Table> lst = TableDAO.Instance.ListTable();
            cboChangeTable.DataSource = lst;
            cboChangeTable.DisplayMember = "Name";
            foreach (Table table in lst)
            {
                Button btnTable = new Button();
                btnTable.Text = table.Name + Environment.NewLine + table.IsType;
                btnTable.Width = table.TableW;
                btnTable.Height = table.TableH;
                btnTable.Tag = table;
                btnTable.BackColor = (table.IsType == "Available") ? Color.LightCyan : Color.LightSeaGreen;
                fpnTable.Controls.Add(btnTable);

                btnTable.Click += BtnTable_Click;
            }
        }

        void LoadCategory()
        {
            List<Category> categories = CategoryDAO.Instance.GetCategory();
            cboFoodCategory.DataSource = categories;
            //cboFoodCategory.SelectedValueChanged += CboFoodCategory_SelectedValueChanged;
        }

        private void CboFoodCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            var cbo = sender as ComboBox;
            Category category = cbo.SelectedItem as Category;
            LoadCategoryByCategoryID(category.ID);
        }

        void LoadCategoryByCategoryID(int ID)
        {
            List<Food> foods = FoodDAO.Instance.GetFoodByCateforyID(ID);
            cboFood.DataSource = foods;

        }
        #endregion

        #region Events
        private void mntUserInfo_Click(object sender, EventArgs e)
        {
            fUserInfo fUserInfo = new fUserInfo(AccountDAO.Instance.GetAccountByUserName(currentAccount.UserName)[0]);
            fUserInfo.EVUpdateDisplayName += FUserInfo_EVUpdateDisplayName;
            fUserInfo.EVUpdateType += FUserInfo_EVUpdateType;
            fUserInfo.ShowDialog();
        }

        private void FUserInfo_EVUpdateType(object sender, EvArg_UpdateType e)
        {
            lblTypeAcc.Text = (e.Acc.IsType == 0)? "Admin": "Staff";
        }

        private void FUserInfo_EVUpdateDisplayName(object sender, EvArg_DisplayName e)
        {
            lblCurrentUserName.Text = e.Acc.DisplayName;
        }

        private void mntLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mntAdmin_Click(object sender, EventArgs e)
        {
            fAdmin fAdmin = new fAdmin();
            fAdmin.ShowDialog();
        }

        Table currentTable = null;

        private void BtnTable_Click(object sender, EventArgs e)
        {
            Table table = (sender as Button).Tag as Table;

            currentTable = (sender as Button).Tag as Table;
            LoadMenuByTableID(table);
        }

        void LoadMenuByTableID(Table table)
        {
            livBill.Items.Clear();
            double totalAmount = 0;
            
            livBill.Tag = table;
            List<Menu> lstMenu = MenuDAO.Instance.GetMenuByTableID(table.ID);

            foreach (Menu item in lstMenu)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName);
                //listViewItem.SubItems.Add(item.FoodName);
                listViewItem.SubItems.Add(item.Qty.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());

                livBill.Items.Add(listViewItem);

                totalAmount += item.Amount;
            }

            CultureInfo cultureInfo = new CultureInfo("vn-VN");
            txtTotalAmount.Text = totalAmount.ToString("c", cultureInfo);
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nmrQty.Value == 0)
            { 
                MessageBox.Show("Please change your Qty !!!"); 
                return; 
            }

            Food food = cboFood.SelectedItem as Food;
            Table table = livBill.Tag as Table;
            int BillInfo_ID = BillInfoDAO.Instance.GetBillInfoByTableID(table.ID);
            
            if (BillInfo_ID > 0)
            {
                BillItemDAO.Instance.UpadteBillItem(BillInfo_ID, food.ID, (int)nmrQty.Value);
            }
            else
            {
                BillInfo_ID = BillInfoDAO.Instance.UpadteBillInfo("staff", table.ID, 0);
                BillItemDAO.Instance.UpadteBillItem(BillInfo_ID, food.ID, (int)nmrQty.Value);
                //TableDAO.Instance.CheckIn(table.ID);
                LoadTable();
            }

            LoadMenuByTableID(table);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Table table = livBill.Tag as Table;
            int BillID = BillInfoDAO.Instance.GetBillInfoByTableID(table.ID);
            if(MessageBox.Show("Are you sure for checking out table " + table.Name.ToString(),"Notice", MessageBoxButtons.OKCancel) ==  DialogResult.OK)
            {
                TableDAO.Instance.CheckOut(table.ID, BillID);
                LoadMenuByTableID(table);
                LoadTable();
            }
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            if (currentTable == null || cboChangeTable.SelectedItem == null) return;
            int FromTableID = currentTable.ID;
            int ToTableID = (cboChangeTable.SelectedItem as Table).ID;

            TableDAO.Instance.ChangeTable(FromTableID, ToTableID);
            LoadMenuByTableID(currentTable);
            LoadTable();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (currentTable == null || cboChangeTable.SelectedItem == null) return;
            int FromTableID = currentTable.ID;
            int ToTableID = (cboChangeTable.SelectedItem as Table).ID;

            TableDAO.Instance.MergeTable(FromTableID, ToTableID);
            LoadMenuByTableID(currentTable);
            LoadTable();
        }
    }
}
