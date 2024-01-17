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
    public partial class Form1 : RadForm
    {
        Dashboard dashboard;
        Category category;
        Company company;
        Models models;
        AddQuantity addQuantity;
        rpt_Stocks stocks;
        DB_Backup backup;
        CustomerBill bill;
        Sales_form sales;
        public Form1()
        {
            InitializeComponent();
        }    
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if(dashboard == null)
            {
                dashboard = new Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
               
            }
            ResetButtonColors();

            // Change color for the clicked button
            btn_dashboard.BackColor = Color.Green;
            
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }
        private void btn_companies_Click(object sender, EventArgs e)
        {
            if(company == null)
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
            ResetButtonColors();

            // Change color for the clicked button
            btn_companies.BackColor = Color.Green;
        }
        private void Company_FormClosed(object sender, FormClosedEventArgs e)
        {
            company = null;
        }
        private void btn_categories_Click(object sender, EventArgs e)
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
            ResetButtonColors();

            // Change color for the clicked button
            btn_categories.BackColor = Color.Green;
        }
        private void Category_FormClosed(object sender, FormClosedEventArgs e)
        {
            category = null;
        }
        private void btn_models_Click(object sender, EventArgs e)
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
            ResetButtonColors();

            // Change color for the clicked button
            btn_models.BackColor = Color.Green;
        }
        private void Models_FormClosed(object sender, FormClosedEventArgs e)
        {
            models = null;
        }
        private void btn_add_qty_Click(object sender, EventArgs e)
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
            ResetButtonColors();

            // Change color for the clicked button
            btn_add_qty.BackColor = Color.Green;
        }
        private void AddQuantity_FormClosed(object sender, FormClosedEventArgs e)
        {
            addQuantity = null;
        }

        private void ResetButtonColors()
        {
            // Reset color for all buttons
            btn_dashboard.BackColor = Color.FromArgb(23, 24, 29); 
            btn_companies.BackColor = Color.FromArgb(23, 24, 29); 
            btn_categories.BackColor = Color.FromArgb(23, 24, 29); 
            btn_models.BackColor = Color.FromArgb(23, 24, 29); 
            btn_add_qty.BackColor = Color.FromArgb(23, 24, 29); 
            btn_stock_report.BackColor = Color.FromArgb(23, 24, 29);
            btn_backup.BackColor = Color.FromArgb(23, 24, 29);
            btn_customer_bill.BackColor = Color.FromArgb(23, 24, 29);
            btn_sales.BackColor = Color.FromArgb(23, 24, 29);
        }

        private void btn_stock_report_Click(object sender, EventArgs e)
        {
            if (stocks == null)
            {
                stocks = new rpt_Stocks();
                stocks.FormClosed += Stocks_FormClosed; ;
                stocks.MdiParent = this;
                stocks.Dock = DockStyle.Fill;
                stocks.Show();
            }
            else
            {
                stocks.Activate();
            }
            ResetButtonColors();

            // Change color for the clicked button
            btn_stock_report.BackColor = Color.Green;
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
            ResetButtonColors();

            // Change color for the clicked button
            btn_backup.BackColor = Color.Green;
        }

        private void Backup_FormClosed(object sender, FormClosedEventArgs e)
        {
            backup = null;
        }

        private void btn_customer_bill_Click(object sender, EventArgs e)
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
            ResetButtonColors();

            // Change color for the clicked button
            btn_customer_bill.BackColor = Color.Green;
        }

        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            bill = null;
        }

        private void btn_sales_Click(object sender, EventArgs e)
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
            ResetButtonColors();

            // Change color for the clicked button
            btn_sales.BackColor = Color.Green;
        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            sales = null;
        }
    }
}
