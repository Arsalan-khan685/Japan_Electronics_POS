
namespace JapanElectronics_POS.Forms
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_haier = new System.Windows.Forms.Button();
            this.btn_dawlance = new System.Windows.Forms.Button();
            this.btn_pel = new System.Windows.Forms.Button();
            this.btn_other = new System.Windows.Forms.Button();
            this.pnl_cmp = new System.Windows.Forms.Panel();
            this.pnl_cat = new System.Windows.Forms.Panel();
            this.pnl_model = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_cmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashobard Of Japan Electronics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 114);
            this.panel1.TabIndex = 1;
            // 
            // btn_haier
            // 
            this.btn_haier.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_haier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_haier.Location = new System.Drawing.Point(4, 109);
            this.btn_haier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_haier.Name = "btn_haier";
            this.btn_haier.Size = new System.Drawing.Size(261, 75);
            this.btn_haier.TabIndex = 2;
            this.btn_haier.Text = "Haier";
            this.btn_haier.UseVisualStyleBackColor = false;
            // 
            // btn_dawlance
            // 
            this.btn_dawlance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_dawlance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dawlance.Location = new System.Drawing.Point(4, 206);
            this.btn_dawlance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dawlance.Name = "btn_dawlance";
            this.btn_dawlance.Size = new System.Drawing.Size(261, 75);
            this.btn_dawlance.TabIndex = 3;
            this.btn_dawlance.Text = "Dawlance";
            this.btn_dawlance.UseVisualStyleBackColor = false;
            // 
            // btn_pel
            // 
            this.btn_pel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_pel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pel.Location = new System.Drawing.Point(4, 296);
            this.btn_pel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pel.Name = "btn_pel";
            this.btn_pel.Size = new System.Drawing.Size(261, 75);
            this.btn_pel.TabIndex = 4;
            this.btn_pel.Text = "Pel";
            this.btn_pel.UseVisualStyleBackColor = false;
            // 
            // btn_other
            // 
            this.btn_other.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_other.Location = new System.Drawing.Point(3, 391);
            this.btn_other.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_other.Name = "btn_other";
            this.btn_other.Size = new System.Drawing.Size(262, 75);
            this.btn_other.TabIndex = 5;
            this.btn_other.Text = "Other";
            this.btn_other.UseVisualStyleBackColor = false;
            // 
            // pnl_cmp
            // 
            this.pnl_cmp.Controls.Add(this.btn_haier);
            this.pnl_cmp.Controls.Add(this.btn_other);
            this.pnl_cmp.Controls.Add(this.btn_dawlance);
            this.pnl_cmp.Controls.Add(this.btn_pel);
            this.pnl_cmp.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_cmp.Location = new System.Drawing.Point(0, 114);
            this.pnl_cmp.Name = "pnl_cmp";
            this.pnl_cmp.Size = new System.Drawing.Size(268, 730);
            this.pnl_cmp.TabIndex = 6;
            // 
            // pnl_cat
            // 
            this.pnl_cat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_cat.Location = new System.Drawing.Point(268, 114);
            this.pnl_cat.Name = "pnl_cat";
            this.pnl_cat.Size = new System.Drawing.Size(322, 730);
            this.pnl_cat.TabIndex = 7;
            // 
            // pnl_model
            // 
            this.pnl_model.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_model.Location = new System.Drawing.Point(590, 114);
            this.pnl_model.Name = "pnl_model";
            this.pnl_model.Size = new System.Drawing.Size(322, 730);
            this.pnl_model.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 844);
            this.Controls.Add(this.pnl_model);
            this.Controls.Add(this.pnl_cat);
            this.Controls.Add(this.pnl_cmp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_cmp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_haier;
        private System.Windows.Forms.Button btn_dawlance;
        private System.Windows.Forms.Button btn_pel;
        private System.Windows.Forms.Button btn_other;
        private System.Windows.Forms.Panel pnl_cmp;
        private System.Windows.Forms.Panel pnl_cat;
        private System.Windows.Forms.Panel pnl_model;
    }
}