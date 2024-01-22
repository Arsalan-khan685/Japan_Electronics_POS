
namespace JapanElectronics_POS.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_backup = new Telerik.WinControls.UI.RadButton();
            this.btn_Stock_report = new Telerik.WinControls.UI.RadButton();
            this.btn_customerbill = new Telerik.WinControls.UI.RadButton();
            this.btn_Sales = new Telerik.WinControls.UI.RadButton();
            this.btn_addstocks = new Telerik.WinControls.UI.RadButton();
            this.btn_category = new Telerik.WinControls.UI.RadButton();
            this.btn_Model = new Telerik.WinControls.UI.RadButton();
            this.btn_company = new Telerik.WinControls.UI.RadButton();
            this.btn_dashboard = new Telerik.WinControls.UI.RadButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_backup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stock_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_customerbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addstocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_backup);
            this.panel1.Controls.Add(this.btn_Stock_report);
            this.panel1.Controls.Add(this.btn_customerbill);
            this.panel1.Controls.Add(this.btn_Sales);
            this.panel1.Controls.Add(this.btn_addstocks);
            this.panel1.Controls.Add(this.btn_category);
            this.panel1.Controls.Add(this.btn_Model);
            this.panel1.Controls.Add(this.btn_company);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 589);
            this.panel1.TabIndex = 0;
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_backup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.Location = new System.Drawing.Point(0, 434);
            this.btn_backup.Margin = new System.Windows.Forms.Padding(0);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(232, 54);
            this.btn_backup.TabIndex = 10;
            this.btn_backup.Text = "BackUp";
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_Stock_report
            // 
            this.btn_Stock_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Stock_report.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock_report.ForeColor = System.Drawing.Color.White;
            this.btn_Stock_report.Location = new System.Drawing.Point(0, 380);
            this.btn_Stock_report.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Stock_report.Name = "btn_Stock_report";
            this.btn_Stock_report.Size = new System.Drawing.Size(232, 54);
            this.btn_Stock_report.TabIndex = 9;
            this.btn_Stock_report.Text = "Stock Report";
            this.btn_Stock_report.Click += new System.EventHandler(this.btn_Stock_report_Click);
            // 
            // btn_customerbill
            // 
            this.btn_customerbill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_customerbill.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerbill.ForeColor = System.Drawing.Color.White;
            this.btn_customerbill.Location = new System.Drawing.Point(0, 326);
            this.btn_customerbill.Margin = new System.Windows.Forms.Padding(0);
            this.btn_customerbill.Name = "btn_customerbill";
            this.btn_customerbill.Size = new System.Drawing.Size(232, 54);
            this.btn_customerbill.TabIndex = 8;
            this.btn_customerbill.Text = "Customer Bill";
            this.btn_customerbill.Click += new System.EventHandler(this.btn_customerbill_Click);
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Sales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.ForeColor = System.Drawing.Color.White;
            this.btn_Sales.Location = new System.Drawing.Point(0, 272);
            this.btn_Sales.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(232, 54);
            this.btn_Sales.TabIndex = 7;
            this.btn_Sales.Text = "Sales";
            this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
            // 
            // btn_addstocks
            // 
            this.btn_addstocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_addstocks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addstocks.ForeColor = System.Drawing.Color.White;
            this.btn_addstocks.Location = new System.Drawing.Point(0, 218);
            this.btn_addstocks.Margin = new System.Windows.Forms.Padding(0);
            this.btn_addstocks.Name = "btn_addstocks";
            this.btn_addstocks.Size = new System.Drawing.Size(232, 54);
            this.btn_addstocks.TabIndex = 6;
            this.btn_addstocks.Text = "Add Stocks";
            this.btn_addstocks.Click += new System.EventHandler(this.btn_addstocks_Click);
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_category.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category.ForeColor = System.Drawing.Color.White;
            this.btn_category.Location = new System.Drawing.Point(0, 110);
            this.btn_category.Margin = new System.Windows.Forms.Padding(0);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(232, 54);
            this.btn_category.TabIndex = 6;
            this.btn_category.Text = "Category";
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_Model
            // 
            this.btn_Model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Model.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Model.ForeColor = System.Drawing.Color.White;
            this.btn_Model.Location = new System.Drawing.Point(0, 164);
            this.btn_Model.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Model.Name = "btn_Model";
            this.btn_Model.Size = new System.Drawing.Size(232, 54);
            this.btn_Model.TabIndex = 5;
            this.btn_Model.Text = "Model";
            this.btn_Model.Click += new System.EventHandler(this.btn_Model_Click);
            // 
            // btn_company
            // 
            this.btn_company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_company.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_company.ForeColor = System.Drawing.Color.White;
            this.btn_company.Location = new System.Drawing.Point(0, 56);
            this.btn_company.Margin = new System.Windows.Forms.Padding(0);
            this.btn_company.Name = "btn_company";
            this.btn_company.Size = new System.Drawing.Size(232, 54);
            this.btn_company.TabIndex = 4;
            this.btn_company.Text = "Company";
            this.btn_company.Click += new System.EventHandler(this.btn_company_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 2);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(232, 54);
            this.btn_dashboard.TabIndex = 3;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 589);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Japan Electronics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_backup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Stock_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_customerbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addstocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton btn_dashboard;
        private Telerik.WinControls.UI.RadButton btn_company;
        private Telerik.WinControls.UI.RadButton btn_category;
        private Telerik.WinControls.UI.RadButton btn_Model;
        private Telerik.WinControls.UI.RadButton btn_addstocks;
        private Telerik.WinControls.UI.RadButton btn_Stock_report;
        private Telerik.WinControls.UI.RadButton btn_customerbill;
        private Telerik.WinControls.UI.RadButton btn_Sales;
        private Telerik.WinControls.UI.RadButton btn_backup;
    }
}