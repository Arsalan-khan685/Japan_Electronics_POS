
namespace JapanElectronics_POS.Forms
{
    partial class DB_Backup
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
            this.btn_db_backup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_db_backup
            // 
            this.btn_db_backup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_db_backup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_db_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_db_backup.Location = new System.Drawing.Point(615, 296);
            this.btn_db_backup.Name = "btn_db_backup";
            this.btn_db_backup.Size = new System.Drawing.Size(177, 71);
            this.btn_db_backup.TabIndex = 0;
            this.btn_db_backup.Text = "Backup";
            this.btn_db_backup.UseVisualStyleBackColor = false;
            this.btn_db_backup.Click += new System.EventHandler(this.btn_db_backup_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(877, 290);
            this.label1.TabIndex = 1;
            this.label1.Text = "For Backup of the database click on the button below ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DB_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_db_backup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DB_Backup";
            this.Text = "Backup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Backup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_db_backup;
        private System.Windows.Forms.Label label1;
    }
}