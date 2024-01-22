
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
            this.btn_db_backup = new Telerik.WinControls.UI.RadButton();
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_db_backup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_db_backup
            // 
            this.btn_db_backup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_db_backup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_db_backup.Location = new System.Drawing.Point(509, 101);
            this.btn_db_backup.Margin = new System.Windows.Forms.Padding(2);
            this.btn_db_backup.Name = "btn_db_backup";
            this.btn_db_backup.Size = new System.Drawing.Size(118, 46);
            this.btn_db_backup.TabIndex = 0;
            this.btn_db_backup.Text = "Backup";
            this.btn_db_backup.Click += new System.EventHandler(this.btn_db_backup_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "For Backup of the database click on the button below ";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DB_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 415);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_db_backup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DB_Backup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_db_backup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_db_backup;
        private Telerik.WinControls.UI.RadLabel label1;
    }
}