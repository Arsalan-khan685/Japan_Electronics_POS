using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapanElectronics_POS.Forms
{
    public partial class DB_Backup : Form
    {
      //  Backup Action;
        public DB_Backup()
        {         
            InitializeComponent();
        }
        private void Backup_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btn_db_backup_Click(object sender, EventArgs e)
        {
            string databaseName = "JapanElectronics"; // Replace with your database name

            try
            {
                // Display SaveFileDialog to choose the backup file location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                    saveFileDialog.Title = "Choose Backup Location";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Perform the backup
                        BackupDatabase(databaseName,saveFileDialog.FileName);
                        MessageBox.Show("Backup completed successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup failed. Error: " + ex.Message);
            }


           //     string databaseName = "EmployeeDB"; // Replace with your database name
           //     string backupFilePath = @"C:\Path\To\Your\Backup\File.bak"; // Replace with your desired backup file path
           //     string backupFilePath = @"D:\Database_Backup\dbbb.bak";
           //     BackupDatabase(databaseName, backupFilePath);

           //     MessageBox.Show("Backup completed successfully!");

        }
       
        private void BackupDatabase(string databaseName, string backupFilePath)
        {
            try
            {
                ServerConnection serverConnection = new ServerConnection("DESKTOP-PBE25SJ\\SQLEXPRESS"); // Replace with your SQL Server name
                Server sqlServer = new Server(serverConnection);

                Backup sqlBackup = new Backup
                {
                    Action = BackupActionType.Database,
                    Database = databaseName,
                    Incremental = false,
                    LogTruncation = BackupTruncateLogType.Truncate
                };

                sqlBackup.Devices.AddDevice(backupFilePath, DeviceType.File);

                sqlBackup.SqlBackup(sqlServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup failed. Error: " + ex.Message);
            }
        }


        //private void BackupDatabase(string databaseName, string backupFilePath)
        //{
        //    try
        //    {
        //        ServerConnection serverConnection = new ServerConnection("DESKTOP-PBE25SJ\SQLEXPRESS"); // Replace with your SQL Server name
        //        Server sqlServer = new Server(serverConnection);

        //        Backup sqlBackup = new Backup
        //        {
        //            Action = BackupActionType.Database,
        //            Database = databaseName,
        //            Devices.AddDevice(backupFilePath, DeviceType.File),
        //            Incremental = false,
        //            LogTruncation = BackupTruncateLogType.Truncate
        //        };

        //        sqlBackup.SqlBackup(sqlServer);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Backup failed. Error: " + ex.Message);
        //    }
        //}

    }
}
