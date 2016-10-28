using System;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace GUI
{
    public partial class FormSQLConfig : DevExpress.XtraEditors.XtraForm
    {

        Server server;
        ServerConnection conn;
        public FormSQLConfig()
        {
            InitializeComponent();
        }

        private void FormSQLConfig_Load(object sender, EventArgs e)
        {
            cbxTypeLogin.SelectedIndex = 0;
            searchServerName();
        }


        private void searchServerName()
        {
            RegistryKey rk;
            if (Environment.Is64BitOperatingSystem)
                rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            else
                rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            String[] instances = (String[]) rk.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server", false).GetValue("InstalledInstances");

            if (instances.Length > 0)
            {
                foreach (String element in instances)
                {
                    if (element == "MSSQLSERVER")
                    {
                        cbxServerName.Properties.Items.Add(System.Environment.MachineName);
                    }
                    else
                    {
                        cbxServerName.Properties.Items.Add(System.Environment.MachineName + @"\" + element);
                    }
                }
            }

            if(cbxServerName.Properties.Items.Count > 0)
            {
                cbxServerName.SelectedIndex = 0;
            }
        }

        private void cbxTypeLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTypeLogin.SelectedIndex == 0)
            {
                grbAccount.Enabled = false;
            }
            else
            {
                grbAccount.Enabled = true;
            }
        }

        private void btnTestLogin_Click(object sender, EventArgs e)
        {
            cbxDatabaseName.Properties.Items.Clear();
            try
            {
                if (cbxTypeLogin.SelectedIndex == 0)
                {
                    conn = new ServerConnection();
                    conn.ServerInstance = cbxServerName.SelectedItem.ToString();
                }
                else
                {
                    conn = new ServerConnection(cbxServerName.SelectedItem.ToString()
                        , txbUserName.Text
                        , txbPassword.Text);
                }

                server = new Server(conn);
                foreach (Database db in server.Databases)
                {
                    cbxDatabaseName.Properties.Items.Add(db.Name);
                }
                MessageBox.Show("Kết nối thành công, vui lòng chọn tên Database."
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không kết nối được đến Database, vui lòng kiểm tra lại."
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IniFile fileSave = new IniFile(Environment.CurrentDirectory + "\\config.ini");
            fileSave.IniWriteValue("Info", "Server", cbxServerName.Text);
            fileSave.IniWriteValue("Info", "Database-Name", cbxDatabaseName.Text);

            if (cbxTypeLogin.SelectedIndex == 0)
            {
                fileSave.IniWriteValue("Info", "Login-Type", "0");
            }
            else
            {
                fileSave.IniWriteValue("Info", "Login-Type", "1");
                fileSave.IniWriteValue("User", "UserName", txbUserName.Text);
                fileSave.IniWriteValue("User", "Password", txbPassword.Text);
            }

            MessageBox.Show("Đã lưu thông tin thành công."
                    , "Thông báo"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
        }
    }
}