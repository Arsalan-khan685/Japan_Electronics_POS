
namespace JapanElectronics_POS.Forms
{
    partial class Models
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new Telerik.WinControls.UI.RadLabel();
            this.btn_back = new Telerik.WinControls.UI.RadButton();
            this.btn_Save = new Telerik.WinControls.UI.RadButton();
            this.txt_model = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new Telerik.WinControls.UI.RadLabel();
            this.cmb_category = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new Telerik.WinControls.UI.RadLabel();
            this.cmb_company = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_models = new Telerik.WinControls.UI.RadGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_models)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_models.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.txt_model);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_category);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_company);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 221);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 86);
            this.panel3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Models";
            this.label4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(658, 159);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(79, 36);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(756, 159);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 36);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_model
            // 
            this.txt_model.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_model.Location = new System.Drawing.Point(272, 159);
            this.txt_model.Margin = new System.Windows.Forms.Padding(2);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(198, 20);
            this.txt_model.TabIndex = 3;
            this.txt_model.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model";
            // 
            // cmb_category
            // 
            this.cmb_category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_category.Location = new System.Drawing.Point(625, 120);
            this.cmb_category.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(211, 20);
            this.cmb_category.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category";
            // 
            // cmb_company
            // 
            this.cmb_company.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_company.Location = new System.Drawing.Point(272, 120);
            this.cmb_company.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_company.Name = "cmb_company";
            this.cmb_company.Size = new System.Drawing.Size(198, 20);
            this.cmb_company.TabIndex = 1;
            this.cmb_company.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmb_company_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_models);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 221);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 757);
            this.panel2.TabIndex = 1;
            // 
            // dgv_models
            // 
            this.dgv_models.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_models.Location = new System.Drawing.Point(0, 0);
            this.dgv_models.Margin = new System.Windows.Forms.Padding(2);
            // 
            // dgv_models
            // 
            this.dgv_models.MasterTemplate.AllowAddNewRow = false;
            this.dgv_models.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "ModelID";
            gridViewTextBoxColumn1.Name = "ModelID";
            gridViewTextBoxColumn1.Width = 48;
            gridViewTextBoxColumn2.HeaderText = "Company Name";
            gridViewTextBoxColumn2.Name = "CompanyName";
            gridViewTextBoxColumn2.Width = 304;
            gridViewTextBoxColumn3.HeaderText = "Category Name";
            gridViewTextBoxColumn3.Name = "CategoryName";
            gridViewTextBoxColumn3.Width = 304;
            gridViewTextBoxColumn4.HeaderText = "Model Name";
            gridViewTextBoxColumn4.Name = "ModelName";
            gridViewTextBoxColumn4.Width = 296;
            this.dgv_models.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgv_models.MasterTemplate.EnableGrouping = false;
            this.dgv_models.Name = "dgv_models";
            this.dgv_models.Size = new System.Drawing.Size(970, 757);
            this.dgv_models.TabIndex = 1;
            this.dgv_models.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgv_models_CellDoubleClick);
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.MinimumWidth = 8;
            this.CategoryName.Name = "CategoryName";
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company";
            this.CompanyName.MinimumWidth = 8;
            this.CompanyName.Name = "CompanyName";
            // 
            // ModelName
            // 
            this.ModelName.HeaderText = "Model";
            this.ModelName.MinimumWidth = 8;
            this.ModelName.Name = "ModelName";
            // 
            // Models
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 978);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Models";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Models";
            this.Load += new System.EventHandler(this.Models_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_models.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_models)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadDropDownList cmb_category;
        private Telerik.WinControls.UI.RadLabel label2;
        private Telerik.WinControls.UI.RadDropDownList cmb_company;
        private Telerik.WinControls.UI.RadLabel label1;
        private Telerik.WinControls.UI.RadTextBox txt_model;
        private Telerik.WinControls.UI.RadLabel label3;
        private Telerik.WinControls.UI.RadGridView dgv_models;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private Telerik.WinControls.UI.RadButton btn_back;
        private Telerik.WinControls.UI.RadButton btn_Save;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadLabel label4;
    }
}