namespace GUI
{
    partial class FormSQLConfig
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSQLConfig));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnDatabaseName = new DevExpress.XtraEditors.PanelControl();
            this.cbxDatabaseName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnTestLogin = new DevExpress.XtraEditors.SimpleButton();
            this.grbAccount = new DevExpress.XtraEditors.GroupControl();
            this.txbPassword = new DevExpress.XtraEditors.TextEdit();
            this.txbUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxTypeLogin = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbxServerName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnDatabaseName)).BeginInit();
            this.pnDatabaseName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDatabaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbAccount)).BeginInit();
            this.grbAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTypeLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(348, 124);
            this.panelControl1.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::GUI.Properties.Resources.sql_server_logo;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(348, 124);
            this.pictureEdit1.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.pnDatabaseName);
            this.panelControl2.Controls.Add(this.btnTestLogin);
            this.panelControl2.Controls.Add(this.grbAccount);
            this.panelControl2.Controls.Add(this.cbxTypeLogin);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.cbxServerName);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 124);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(348, 280);
            this.panelControl2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(259, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnDatabaseName
            // 
            this.pnDatabaseName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnDatabaseName.Controls.Add(this.cbxDatabaseName);
            this.pnDatabaseName.Controls.Add(this.labelControl5);
            this.pnDatabaseName.Location = new System.Drawing.Point(3, 193);
            this.pnDatabaseName.Name = "pnDatabaseName";
            this.pnDatabaseName.Size = new System.Drawing.Size(341, 40);
            this.pnDatabaseName.TabIndex = 6;
            // 
            // cbxDatabaseName
            // 
            this.cbxDatabaseName.Location = new System.Drawing.Point(99, 10);
            this.cbxDatabaseName.Name = "cbxDatabaseName";
            this.cbxDatabaseName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDatabaseName.Size = new System.Drawing.Size(239, 20);
            this.cbxDatabaseName.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 11);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Database name:";
            // 
            // btnTestLogin
            // 
            this.btnTestLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnTestLogin.Image")));
            this.btnTestLogin.Location = new System.Drawing.Point(237, 164);
            this.btnTestLogin.Name = "btnTestLogin";
            this.btnTestLogin.Size = new System.Drawing.Size(107, 23);
            this.btnTestLogin.TabIndex = 5;
            this.btnTestLogin.Text = "Test Connection";
            this.btnTestLogin.Click += new System.EventHandler(this.btnTestLogin_Click);
            // 
            // grbAccount
            // 
            this.grbAccount.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grbAccount.CaptionImage")));
            this.grbAccount.Controls.Add(this.txbPassword);
            this.grbAccount.Controls.Add(this.txbUserName);
            this.grbAccount.Controls.Add(this.labelControl4);
            this.grbAccount.Controls.Add(this.labelControl3);
            this.grbAccount.Location = new System.Drawing.Point(12, 67);
            this.grbAccount.Name = "grbAccount";
            this.grbAccount.Size = new System.Drawing.Size(329, 89);
            this.grbAccount.TabIndex = 4;
            this.grbAccount.Text = "Account";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(121, 57);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(181, 20);
            this.txbPassword.TabIndex = 3;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(121, 25);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(181, 20);
            this.txbUserName.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Username";
            // 
            // cbxTypeLogin
            // 
            this.cbxTypeLogin.Location = new System.Drawing.Point(102, 44);
            this.cbxTypeLogin.Name = "cbxTypeLogin";
            this.cbxTypeLogin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTypeLogin.Properties.Items.AddRange(new object[] {
            "Windows Authentication",
            "Sql Server Authentication"});
            this.cbxTypeLogin.Size = new System.Drawing.Size(239, 20);
            this.cbxTypeLogin.TabIndex = 3;
            this.cbxTypeLogin.SelectedIndexChanged += new System.EventHandler(this.cbxTypeLogin_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Authentication:";
            // 
            // cbxServerName
            // 
            this.cbxServerName.Location = new System.Drawing.Point(102, 17);
            this.cbxServerName.Name = "cbxServerName";
            this.cbxServerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxServerName.Size = new System.Drawing.Size(239, 20);
            this.cbxServerName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server name:";
            // 
            // FormSQLConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 404);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSQLConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình SQLServer";
            this.Load += new System.EventHandler(this.FormSQLConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnDatabaseName)).EndInit();
            this.pnDatabaseName.ResumeLayout(false);
            this.pnDatabaseName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDatabaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbAccount)).EndInit();
            this.grbAccount.ResumeLayout(false);
            this.grbAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTypeLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServerName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTestLogin;
        private DevExpress.XtraEditors.GroupControl grbAccount;
        private DevExpress.XtraEditors.TextEdit txbPassword;
        private DevExpress.XtraEditors.TextEdit txbUserName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbxTypeLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbxServerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pnDatabaseName;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDatabaseName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}