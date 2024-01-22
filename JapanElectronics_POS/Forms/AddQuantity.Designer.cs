
namespace JapanElectronics_POS.Forms
{
    partial class AddQuantity
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
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_quantity = new Telerik.WinControls.UI.RadTextBox();
            this.label8 = new Telerik.WinControls.UI.RadLabel();
            this.txt_totalprice = new Telerik.WinControls.UI.RadTextBox();
            this.label7 = new Telerik.WinControls.UI.RadLabel();
            this.btn_save = new Telerik.WinControls.UI.RadButton();
            this.btn_back = new Telerik.WinControls.UI.RadButton();
            this.label6 = new Telerik.WinControls.UI.RadLabel();
            this.txt_creationdate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txt_unitprice = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new Telerik.WinControls.UI.RadLabel();
            this.cmb_model = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new Telerik.WinControls.UI.RadLabel();
            this.cmb_category = new Telerik.WinControls.UI.RadDropDownList();
            this.label2 = new Telerik.WinControls.UI.RadLabel();
            this.cmb_company = new Telerik.WinControls.UI.RadDropDownList();
            this.label3 = new Telerik.WinControls.UI.RadLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_totalprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_creationdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unitprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 122);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Items";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_quantity);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_totalprice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_creationdate);
            this.panel2.Controls.Add(this.txt_unitprice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmb_model);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmb_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_company);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 641);
            this.panel2.TabIndex = 1;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_quantity.Location = new System.Drawing.Point(460, 228);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(235, 20);
            this.txt_quantity.TabIndex = 5;
            this.txt_quantity.TabStop = false;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Quantity";
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_totalprice.Location = new System.Drawing.Point(460, 264);
            this.txt_totalprice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(235, 20);
            this.txt_totalprice.TabIndex = 6;
            this.txt_totalprice.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Price";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.Location = new System.Drawing.Point(607, 342);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 26);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.Location = new System.Drawing.Point(521, 342);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 26);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Creation Date";
            // 
            // txt_creationdate
            // 
            this.txt_creationdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_creationdate.Location = new System.Drawing.Point(460, 302);
            this.txt_creationdate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_creationdate.Name = "txt_creationdate";
            this.txt_creationdate.Size = new System.Drawing.Size(235, 20);
            this.txt_creationdate.TabIndex = 7;
            this.txt_creationdate.TabStop = false;
            this.txt_creationdate.Value = new System.DateTime(((long)(0)));
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_unitprice.Location = new System.Drawing.Point(460, 190);
            this.txt_unitprice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(235, 20);
            this.txt_unitprice.TabIndex = 4;
            this.txt_unitprice.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unit Pirice";
            // 
            // cmb_model
            // 
            this.cmb_model.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_model.Location = new System.Drawing.Point(460, 152);
            this.cmb_model.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.Size = new System.Drawing.Size(235, 20);
            this.cmb_model.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Model";
            // 
            // cmb_category
            // 
            this.cmb_category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_category.Location = new System.Drawing.Point(460, 114);
            this.cmb_category.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(235, 20);
            this.cmb_category.TabIndex = 2;
            this.cmb_category.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category";
            // 
            // cmb_company
            // 
            this.cmb_company.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_company.Location = new System.Drawing.Point(460, 76);
            this.cmb_company.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_company.Name = "cmb_company";
            this.cmb_company.Size = new System.Drawing.Size(235, 20);
            this.cmb_company.TabIndex = 1;
            this.cmb_company.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmb_company_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Company";
            // 
            // AddQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 763);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuantity";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "AddQuantity";
            this.Load += new System.EventHandler(this.AddQuantity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_totalprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_creationdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unitprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadLabel label1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadButton btn_save;
        private Telerik.WinControls.UI.RadButton btn_back;
        private Telerik.WinControls.UI.RadLabel label6;
     //   private System.Windows.Forms.DateTimePicker txt_creationdate;
        private Telerik.WinControls.UI.RadDateTimePicker txt_creationdate;
        private Telerik.WinControls.UI.RadTextBox txt_unitprice;
        private Telerik.WinControls.UI.RadLabel label5;
        private Telerik.WinControls.UI.RadDropDownList cmb_model;
        private Telerik.WinControls.UI.RadLabel label4;
        private Telerik.WinControls.UI.RadDropDownList cmb_category;
        private Telerik.WinControls.UI.RadLabel label2;
        private Telerik.WinControls.UI.RadDropDownList cmb_company;
        private Telerik.WinControls.UI.RadLabel label3;
        private Telerik.WinControls.UI.RadTextBox txt_quantity;
        private Telerik.WinControls.UI.RadLabel label8;
        private Telerik.WinControls.UI.RadTextBox txt_totalprice;
        private Telerik.WinControls.UI.RadLabel label7;
    }
}