using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace JapanElectronics_POS.Forms
{
    public partial class MainForm : RadForm
    {
        Dashboard dashboard;
        Company company;
        Category category;
        Models models;
        AddQuantity addQuantity;
        rpt_Stocks stocks;
        Sales_form sales;
        DB_Backup backup;
        CustomerBill bill;
        Dashboard_Backup db;
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the closing action is triggered by the close button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Close all child forms
                CloseAllChildForms();
            }
        }
        private void CloseAllChildForms()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Application.Exit();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                db = new Dashboard_Backup();
                db.FormClosed += Db_FormClosed;
                db.MdiParent = this;
                db.Dock = DockStyle.Fill;
                db.Show();
            }
            else
            {
                db.Activate();
            }            
        }
        private void Db_FormClosed(object sender, FormClosedEventArgs e)
        {
            db = null;
        }        
        private void btn_company_Click(object sender, EventArgs e)
        {
            if (company == null)
            {
                company = new Company();
                company.FormClosed += Company_FormClosed;
                company.MdiParent = this;
                company.Dock = DockStyle.Fill;
                company.Show();

            }
            else
            {
                company.Activate();
            }
         //   ResetButtonColors();
         //   btn_company.BackColor = Color.Green;
        }
        private void Company_FormClosed(object sender, FormClosedEventArgs e)
        {
            company = null;
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                category = new Category();
                category.FormClosed += Category_FormClosed;
                category.MdiParent = this;
                category.Dock = DockStyle.Fill;
                category.Show();

            }
            else
            {
                category.Activate();
            }
         //   ResetButtonColors();
         //   btn_category.BackColor = Color.Green;
        }
        private void Category_FormClosed(object sender, FormClosedEventArgs e)
        {
            category = null;
        }

        private void btn_Model_Click(object sender, EventArgs e)
        {
            if (models == null)
            {
                models = new Models();
                models.FormClosed += Models_FormClosed;
                models.MdiParent = this;
                models.Dock = DockStyle.Fill;
                models.Show();

            }
            else
            {
                models.Activate();
            }
         //   ResetButtonColors();
         //   btn_Model.BackColor = Color.Green;
        }
        private void Models_FormClosed(object sender, FormClosedEventArgs e)
        {
            models = null;
        }

        private void btn_addstocks_Click(object sender, EventArgs e)
        {
            if (addQuantity == null)
            {
                addQuantity = new AddQuantity();
                addQuantity.FormClosed += AddQuantity_FormClosed;
                addQuantity.MdiParent = this;
                addQuantity.Dock = DockStyle.Fill;
                addQuantity.Show();
            }
            else
            {
                addQuantity.Activate();
            }
         //   ResetButtonColors();
         //   btn_addstocks.BackColor = Color.Green;
        }
        private void AddQuantity_FormClosed(object sender, FormClosedEventArgs e)
        {
            addQuantity = null;
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            if (sales == null)
            {
                sales = new Sales_form();
                sales.FormClosed += Sales_FormClosed;
                sales.MdiParent = this;
                sales.Dock = DockStyle.Fill;
                sales.Show();
            }
            else
            {
                sales.Activate();
            }
         //   ResetButtonColors();
         //   btn_Sales.BackColor = Color.Green;
        }
        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            sales = null;
        }

        private void btn_customerbill_Click(object sender, EventArgs e)
        {
            if (bill == null)
            {
                bill = new CustomerBill();
                bill.FormClosed += Bill_FormClosed;
                bill.MdiParent = this;
                bill.Dock = DockStyle.Fill;
                bill.Show();
            }
            else
            {
                bill.Activate();
            }
         //   ResetButtonColors();
         //   btn_customerbill.BackColor = Color.Green;
        }
        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            bill = null;
        }

        private void btn_Stock_report_Click(object sender, EventArgs e)
        {
            if (stocks == null)
            {
                stocks = new rpt_Stocks();
                stocks.FormClosed += Stocks_FormClosed;
                stocks.MdiParent = this;
                stocks.Dock = DockStyle.Fill;
                stocks.Show();
            }
            else
            {
                stocks.Activate();
            }
          //  ResetButtonColors();
         //   btn_Stock_report.BackColor = Color.Green;
        }
        private void Stocks_FormClosed(object sender, FormClosedEventArgs e)
        {
            stocks = null;
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            if (backup == null)
            {
                backup = new DB_Backup();
                backup.FormClosed += Backup_FormClosed;
                backup.MdiParent = this;
                backup.Dock = DockStyle.Fill;
                backup.Show();
            }
            else
            {
                backup.Activate();
            }

          //  ResetButtonColors();
         //   btn_backup.BackColor = Color.Green;
        }
        private void Backup_FormClosed(object sender, FormClosedEventArgs e)
        {
            backup = null;
        }

        

        //private void ClearControls(Control.ControlCollection controls)
        //{
        //    foreach (Control ctrl in controls)
        //    {
        //        if (ctrl is TextBox)
        //        {
        //            ((TextBox)ctrl).Clear();
        //        }
        //        //else if (ctrl is ComboBox)
        //        //{
        //        //  //  ((ComboBox)ctrl).SelectedIndex = 0;
        //        //    ((ComboBox)ctrl).SelectedItem = "-- Sekect --";
        //        //}
        //        //else if (control is CheckBox)
        //        //{
        //        //    ((CheckBox)control).Checked = false;
        //        //}
        //        //else if (control is RadioButton)
        //        //{
        //        //    ((RadioButton)control).Checked = false;
        //        //}
        //        else if (ctrl is DateTimePicker)
        //        {
        //            ((DateTimePicker)ctrl).Value = DateTime.Now;
        //        }
        //        else if (ctrl is DataGridView)
        //        {
        //            ((DataGridView)ctrl).DataSource = null;
        //            ((DataGridView)ctrl).Rows.Clear();
        //        }
        //        else if (ctrl is ReportViewer)
        //        {
        //            ((ReportViewer)ctrl).Reset();
        //        }
        //        else if (ctrl.HasChildren)
        //        {
        //            ClearControls(ctrl.Controls);
        //        }
        //    }
        //}
        //private void ResetButtonColors()
        //{
        //    // Reset color for all buttons
        //    btn_dashboard.BackColor = Color.FromArgb(23, 24, 29);
        //    btn_company.BackColor = Color.FromArgb(23, 24, 29);
        //    btn_category.BackColor = Color.FromArgb(23, 24, 29);
        //    btn_Model.BackColor = Color.FromArgb(23, 24, 29);
        //    btn_addstocks.BackColor = Color.FromArgb(23, 24, 29);
        //    btn_Stock_report.BackColor = Color.FromArgb(23, 24, 29);
        //    btn_backup.BackColor = Color.FromArgb(23, 24, 29);
        //    btn_customerbill.BackColor = Color.FromArgb(23, 24, 29);
        //    btn_Sales.BackColor = Color.FromArgb(23, 24, 29);
        //}
    }
}
