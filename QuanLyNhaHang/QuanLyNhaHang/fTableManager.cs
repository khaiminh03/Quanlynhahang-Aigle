﻿using QuanLyNhaHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using QuanLyNhaHang.DTO;


namespace QuanLyNhaHang
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }


        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
        }
        void load()
        {
           
        }
        #region Method
        void ShowBill(int id)
        {
            listBill.Items.Clear();
            List<QuanLyNhaHang.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLyNhaHang.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvitem = new ListViewItem(item.FoodName.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());
                lsvitem.SubItems.Add(item.Price.ToString());
                lsvitem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                listBill.Items.Add(lsvitem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTotalPrice.Text = totalPrice.ToString();
        }
        void ChangeAccount(int type)
        {
           
        }
        void LoadCategory()
        {
            
        }
        void LoadFoodListByCategoryID(int id)
        {
           
        }
        void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    default:
                        btn.BackColor = Color.Red;
                        break;
                    case "Trống":
                        btn.BackColor = Color.GreenYellow;
                        break;

                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        void LoadComboboxTable(ComboBox cb)
        {
           
        }
        #endregion

        #region Event
        int idhientai = 0;
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            idhientai = tableID;
            string tableName = ((sender as Button).Tag as Table).Name;
            listBill.Tag = (sender as Button).Tag;
            ban.Text = tableName;
            ShowBill(tableID);

        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void F_DeleteFood(object sender, EventArgs e)
        {
            
        }

        private void F_UpdateFood(object sender, EventArgs e)
        {
            
        }

        private void F_InsertFood(object sender, EventArgs e)
        {
           
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void f_UpdateAccount(object sender)
        {
            
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSwitchTable_Click(object sender, EventArgs e)
        { 
          
        }

        #endregion
        private void rf_Click(object sender, EventArgs e)
        {
           
        }

        private void listBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void In_Click(object sender, EventArgs e)
        {
           
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }
    }
}