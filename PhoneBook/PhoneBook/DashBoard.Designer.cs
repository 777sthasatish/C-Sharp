namespace PhoneBook
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.titleLogo = new System.Windows.Forms.PictureBox();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.sepSeventh = new Bunifu.Framework.UI.BunifuSeparator();
            this.sepEight = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtLandNo = new System.Windows.Forms.TextBox();
            this.txtMobNo = new System.Windows.Forms.TextBox();
            this.sepNinth = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdBtnOthers = new System.Windows.Forms.RadioButton();
            this.rdBtnFemale = new System.Windows.Forms.RadioButton();
            this.rdBtnMale = new System.Windows.Forms.RadioButton();
            this.sepFifth = new Bunifu.Framework.UI.BunifuSeparator();
            this.sepSixth = new Bunifu.Framework.UI.BunifuSeparator();
            this.sepFourth = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.sepSecond = new Bunifu.Framework.UI.BunifuSeparator();
            this.sepThird = new Bunifu.Framework.UI.BunifuSeparator();
            this.sepFirst = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMidName = new System.Windows.Forms.TextBox();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.DialogContact = new System.Windows.Forms.OpenFileDialog();
            this.lstContactList = new System.Windows.Forms.ListView();
            this.imgContactList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnSelect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLogo
            // 
            this.titleLogo.Image = ((System.Drawing.Image)(resources.GetObject("titleLogo.Image")));
            this.titleLogo.Location = new System.Drawing.Point(3, 3);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(62, 51);
            this.titleLogo.TabIndex = 1;
            this.titleLogo.TabStop = false;
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleName.ForeColor = System.Drawing.Color.White;
            this.lblTitleName.Location = new System.Drawing.Point(71, 9);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(190, 39);
            this.lblTitleName.TabIndex = 0;
            this.lblTitleName.Text = "Phonebook";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.pnlTitle.Controls.Add(this.picClose);
            this.pnlTitle.Controls.Add(this.titleLogo);
            this.pnlTitle.Controls.Add(this.lblTitleName);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(2012, 56);
            this.pnlTitle.TabIndex = 1;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1947, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(62, 45);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.lblUserName.Location = new System.Drawing.Point(1708, 58);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(124, 46);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "satish";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.lblWelcome.Location = new System.Drawing.Point(1422, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(280, 69);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome";
            // 
            // pnlContact
            // 
            this.pnlContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.pnlContact.Controls.Add(this.bunifuSeparator1);
            this.pnlContact.Controls.Add(this.sepSeventh);
            this.pnlContact.Controls.Add(this.sepEight);
            this.pnlContact.Controls.Add(this.txtRelation);
            this.pnlContact.Controls.Add(this.btnSave);
            this.pnlContact.Controls.Add(this.txtLandNo);
            this.pnlContact.Controls.Add(this.txtMobNo);
            this.pnlContact.Controls.Add(this.sepNinth);
            this.pnlContact.Controls.Add(this.txtEmail);
            this.pnlContact.Controls.Add(this.lblDOB);
            this.pnlContact.Controls.Add(this.dtpDOB);
            this.pnlContact.Controls.Add(this.lblGender);
            this.pnlContact.Controls.Add(this.rdBtnOthers);
            this.pnlContact.Controls.Add(this.rdBtnFemale);
            this.pnlContact.Controls.Add(this.rdBtnMale);
            this.pnlContact.Controls.Add(this.sepFifth);
            this.pnlContact.Controls.Add(this.sepSixth);
            this.pnlContact.Controls.Add(this.sepFourth);
            this.pnlContact.Controls.Add(this.txtCountry);
            this.pnlContact.Controls.Add(this.txtCity);
            this.pnlContact.Controls.Add(this.txtStreet);
            this.pnlContact.Controls.Add(this.sepSecond);
            this.pnlContact.Controls.Add(this.sepThird);
            this.pnlContact.Controls.Add(this.sepFirst);
            this.pnlContact.Controls.Add(this.txtLastName);
            this.pnlContact.Controls.Add(this.txtMidName);
            this.pnlContact.Controls.Add(this.picContact);
            this.pnlContact.Controls.Add(this.txtFirstName);
            this.pnlContact.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContact.Location = new System.Drawing.Point(587, 167);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(1425, 907);
            this.pnlContact.TabIndex = 4;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(685, 617);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(738, 10);
            this.bunifuSeparator1.TabIndex = 32;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // sepSeventh
            // 
            this.sepSeventh.BackColor = System.Drawing.Color.Transparent;
            this.sepSeventh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepSeventh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepSeventh.LineThickness = 2;
            this.sepSeventh.Location = new System.Drawing.Point(684, 440);
            this.sepSeventh.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.sepSeventh.Name = "sepSeventh";
            this.sepSeventh.Size = new System.Drawing.Size(738, 18);
            this.sepSeventh.TabIndex = 31;
            this.sepSeventh.Transparency = 255;
            this.sepSeventh.Vertical = false;
            // 
            // sepEight
            // 
            this.sepEight.BackColor = System.Drawing.Color.Transparent;
            this.sepEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepEight.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepEight.LineThickness = 2;
            this.sepEight.Location = new System.Drawing.Point(12, 506);
            this.sepEight.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.sepEight.Name = "sepEight";
            this.sepEight.Size = new System.Drawing.Size(1410, 10);
            this.sepEight.TabIndex = 29;
            this.sepEight.Transparency = 255;
            this.sepEight.Vertical = false;
            this.sepEight.Load += new System.EventHandler(this.bunifuSeparator7_Load);
            // 
            // txtRelation
            // 
            this.txtRelation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtRelation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelation.ForeColor = System.Drawing.Color.Gray;
            this.txtRelation.Location = new System.Drawing.Point(684, 378);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(757, 40);
            this.txtRelation.TabIndex = 10;
            this.txtRelation.Text = "Contact Relation";
            this.txtRelation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRelation_MouseClick);
            this.txtRelation.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtRelation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRelation_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 24;
            this.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSave.ButtonText = "Add Contact";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconZoom = 65D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(1090, 790);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.White;
            this.btnSave.OnHoverTextColor = System.Drawing.SystemColors.WindowText;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(344, 94);
            this.btnSave.TabIndex = 13;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLandNo
            // 
            this.txtLandNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtLandNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLandNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandNo.ForeColor = System.Drawing.Color.Gray;
            this.txtLandNo.Location = new System.Drawing.Point(684, 551);
            this.txtLandNo.Name = "txtLandNo";
            this.txtLandNo.Size = new System.Drawing.Size(757, 40);
            this.txtLandNo.TabIndex = 12;
            this.txtLandNo.Text = "Landline Number";
            this.txtLandNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLandNo_MouseClick);
            this.txtLandNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLandNo_KeyPress);
            // 
            // txtMobNo
            // 
            this.txtMobNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtMobNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobNo.ForeColor = System.Drawing.Color.Gray;
            this.txtMobNo.Location = new System.Drawing.Point(13, 551);
            this.txtMobNo.Name = "txtMobNo";
            this.txtMobNo.Size = new System.Drawing.Size(652, 40);
            this.txtMobNo.TabIndex = 12;
            this.txtMobNo.Text = "Mobile Number";
            this.txtMobNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMobNo_MouseClick);
            this.txtMobNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobNo_KeyPress);
            // 
            // sepNinth
            // 
            this.sepNinth.BackColor = System.Drawing.Color.Transparent;
            this.sepNinth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepNinth.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepNinth.LineThickness = 2;
            this.sepNinth.Location = new System.Drawing.Point(13, 617);
            this.sepNinth.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.sepNinth.Name = "sepNinth";
            this.sepNinth.Size = new System.Drawing.Size(653, 10);
            this.sepNinth.TabIndex = 22;
            this.sepNinth.Transparency = 255;
            this.sepNinth.Vertical = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(13, 455);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(1393, 40);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "Email Address";
            this.txtEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEmail_MouseClick);
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.lblDOB.Location = new System.Drawing.Point(279, 297);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(214, 39);
            this.lblDOB.TabIndex = 20;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.dtpDOB.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.dtpDOB.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.dtpDOB.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.dtpDOB.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(499, 297);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(534, 43);
            this.dtpDOB.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.lblGender.Location = new System.Drawing.Point(6, 379);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(139, 39);
            this.lblGender.TabIndex = 18;
            this.lblGender.Text = "Gender:";
            // 
            // rdBtnOthers
            // 
            this.rdBtnOthers.AutoSize = true;
            this.rdBtnOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnOthers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.rdBtnOthers.Location = new System.Drawing.Point(482, 379);
            this.rdBtnOthers.Name = "rdBtnOthers";
            this.rdBtnOthers.Size = new System.Drawing.Size(155, 43);
            this.rdBtnOthers.TabIndex = 9;
            this.rdBtnOthers.Text = "Others";
            this.rdBtnOthers.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemale
            // 
            this.rdBtnFemale.AutoSize = true;
            this.rdBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.rdBtnFemale.Location = new System.Drawing.Point(298, 379);
            this.rdBtnFemale.Name = "rdBtnFemale";
            this.rdBtnFemale.Size = new System.Drawing.Size(168, 43);
            this.rdBtnFemale.TabIndex = 8;
            this.rdBtnFemale.Text = "Female";
            this.rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdBtnMale
            // 
            this.rdBtnMale.AutoSize = true;
            this.rdBtnMale.Checked = true;
            this.rdBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.rdBtnMale.Location = new System.Drawing.Point(153, 379);
            this.rdBtnMale.Name = "rdBtnMale";
            this.rdBtnMale.Size = new System.Drawing.Size(128, 43);
            this.rdBtnMale.TabIndex = 7;
            this.rdBtnMale.TabStop = true;
            this.rdBtnMale.Text = "Male";
            this.rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // sepFifth
            // 
            this.sepFifth.BackColor = System.Drawing.Color.Transparent;
            this.sepFifth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepFifth.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepFifth.LineThickness = 2;
            this.sepFifth.Location = new System.Drawing.Point(684, 238);
            this.sepFifth.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.sepFifth.Name = "sepFifth";
            this.sepFifth.Size = new System.Drawing.Size(349, 30);
            this.sepFifth.TabIndex = 12;
            this.sepFifth.Transparency = 255;
            this.sepFifth.Vertical = false;
            // 
            // sepSixth
            // 
            this.sepSixth.BackColor = System.Drawing.Color.Transparent;
            this.sepSixth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepSixth.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepSixth.LineThickness = 2;
            this.sepSixth.Location = new System.Drawing.Point(1051, 238);
            this.sepSixth.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.sepSixth.Name = "sepSixth";
            this.sepSixth.Size = new System.Drawing.Size(371, 30);
            this.sepSixth.TabIndex = 11;
            this.sepSixth.Transparency = 255;
            this.sepSixth.Vertical = false;
            // 
            // sepFourth
            // 
            this.sepFourth.BackColor = System.Drawing.Color.Transparent;
            this.sepFourth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepFourth.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepFourth.LineThickness = 2;
            this.sepFourth.Location = new System.Drawing.Point(279, 238);
            this.sepFourth.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.sepFourth.Name = "sepFourth";
            this.sepFourth.Size = new System.Drawing.Size(386, 30);
            this.sepFourth.TabIndex = 10;
            this.sepFourth.Transparency = 255;
            this.sepFourth.Vertical = false;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.Gray;
            this.txtCountry.Location = new System.Drawing.Point(1051, 185);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(390, 40);
            this.txtCountry.TabIndex = 5;
            this.txtCountry.Text = "Country";
            this.txtCountry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCountry_MouseClick);
            this.txtCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountry_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Gray;
            this.txtCity.Location = new System.Drawing.Point(684, 185);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(349, 40);
            this.txtCity.TabIndex = 4;
            this.txtCity.Text = "City";
            this.txtCity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCity_MouseClick);
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.ForeColor = System.Drawing.Color.Gray;
            this.txtStreet.Location = new System.Drawing.Point(279, 185);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(386, 40);
            this.txtStreet.TabIndex = 3;
            this.txtStreet.Text = "Street";
            this.txtStreet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtStreet_MouseClick);
            this.txtStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStreet_KeyPress);
            // 
            // sepSecond
            // 
            this.sepSecond.BackColor = System.Drawing.Color.Transparent;
            this.sepSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepSecond.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepSecond.LineThickness = 2;
            this.sepSecond.Location = new System.Drawing.Point(684, 147);
            this.sepSecond.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.sepSecond.Name = "sepSecond";
            this.sepSecond.Size = new System.Drawing.Size(349, 25);
            this.sepSecond.TabIndex = 6;
            this.sepSecond.Transparency = 255;
            this.sepSecond.Vertical = false;
            // 
            // sepThird
            // 
            this.sepThird.BackColor = System.Drawing.Color.Transparent;
            this.sepThird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepThird.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepThird.LineThickness = 2;
            this.sepThird.Location = new System.Drawing.Point(1047, 147);
            this.sepThird.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.sepThird.Name = "sepThird";
            this.sepThird.Size = new System.Drawing.Size(375, 25);
            this.sepThird.TabIndex = 5;
            this.sepThird.Transparency = 255;
            this.sepThird.Vertical = false;
            // 
            // sepFirst
            // 
            this.sepFirst.BackColor = System.Drawing.Color.Transparent;
            this.sepFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepFirst.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepFirst.LineThickness = 2;
            this.sepFirst.Location = new System.Drawing.Point(279, 147);
            this.sepFirst.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.sepFirst.Name = "sepFirst";
            this.sepFirst.Size = new System.Drawing.Size(386, 25);
            this.sepFirst.TabIndex = 4;
            this.sepFirst.Transparency = 255;
            this.sepFirst.Vertical = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName.Location = new System.Drawing.Point(1051, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(390, 40);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLastName_MouseClick);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtMidName
            // 
            this.txtMidName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtMidName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidName.ForeColor = System.Drawing.Color.Gray;
            this.txtMidName.Location = new System.Drawing.Point(684, 85);
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.Size = new System.Drawing.Size(349, 40);
            this.txtMidName.TabIndex = 1;
            this.txtMidName.Text = "Middle Name";
            this.txtMidName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMidName_MouseClick);
            this.txtMidName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMidName_KeyPress);
            // 
            // picContact
            // 
            this.picContact.BackColor = System.Drawing.Color.White;
            this.picContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picContact.Image = ((System.Drawing.Image)(resources.GetObject("picContact.Image")));
            this.picContact.Location = new System.Drawing.Point(6, 76);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(260, 260);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContact.TabIndex = 1;
            this.picContact.TabStop = false;
            this.picContact.Click += new System.EventHandler(this.picContact_Click);
            this.picContact.MouseEnter += new System.EventHandler(this.picContact_MouseEnter);
            this.picContact.MouseLeave += new System.EventHandler(this.picContact_MouseLeave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.Location = new System.Drawing.Point(279, 85);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(386, 40);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFirstName_MouseClick);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // DialogContact
            // 
            this.DialogContact.FileName = "DialogContact";
            // 
            // lstContactList
            // 
            this.lstContactList.BackColor = System.Drawing.Color.SeaShell;
            this.lstContactList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstContactList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstContactList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContactList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.lstContactList.FullRowSelect = true;
            this.lstContactList.GridLines = true;
            this.lstContactList.HoverSelection = true;
            this.lstContactList.Location = new System.Drawing.Point(0, 243);
            this.lstContactList.MultiSelect = false;
            this.lstContactList.Name = "lstContactList";
            this.lstContactList.Size = new System.Drawing.Size(587, 719);
            this.lstContactList.TabIndex = 5;
            this.lstContactList.UseCompatibleStateImageBehavior = false;
            this.lstContactList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstContactList_MouseClick);
            // 
            // imgContactList
            // 
            this.imgContactList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgContactList.ImageSize = new System.Drawing.Size(150, 140);
            this.imgContactList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2012, 111);
            this.panel1.TabIndex = 6;
            // 
            // btnSettings
            // 
            this.btnSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.BorderRadius = 30;
            this.btnSettings.ButtonText = "Settings";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSettings.Iconimage")));
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconZoom = 65D;
            this.btnSettings.IsTab = false;
            this.btnSettings.Location = new System.Drawing.Point(685, 0);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnSettings.OnHovercolor = System.Drawing.Color.SeaShell;
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSettings.selected = false;
            this.btnSettings.Size = new System.Drawing.Size(337, 83);
            this.btnSettings.TabIndex = 35;
            this.btnSettings.Textcolor = System.Drawing.Color.White;
            this.btnSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExport
            // 
            this.btnExport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.BorderRadius = 30;
            this.btnExport.ButtonText = "Export";
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExport.Iconimage")));
            this.btnExport.Iconimage_right = null;
            this.btnExport.Iconimage_right_Selected = null;
            this.btnExport.Iconimage_Selected = null;
            this.btnExport.IconZoom = 65D;
            this.btnExport.IsTab = false;
            this.btnExport.Location = new System.Drawing.Point(344, 1);
            this.btnExport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnExport.OnHovercolor = System.Drawing.Color.SeaShell;
            this.btnExport.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnExport.selected = false;
            this.btnExport.Size = new System.Drawing.Size(337, 83);
            this.btnExport.TabIndex = 34;
            this.btnExport.Textcolor = System.Drawing.Color.White;
            this.btnExport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnImport
            // 
            this.btnImport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.BorderRadius = 30;
            this.btnImport.ButtonText = "Import";
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImport.Iconimage")));
            this.btnImport.Iconimage_right = null;
            this.btnImport.Iconimage_right_Selected = null;
            this.btnImport.Iconimage_Selected = null;
            this.btnImport.IconZoom = 65D;
            this.btnImport.IsTab = false;
            this.btnImport.Location = new System.Drawing.Point(3, 0);
            this.btnImport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnImport.Name = "btnImport";
            this.btnImport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnImport.OnHovercolor = System.Drawing.Color.SeaShell;
            this.btnImport.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnImport.selected = false;
            this.btnImport.Size = new System.Drawing.Size(337, 84);
            this.btnImport.TabIndex = 33;
            this.btnImport.Textcolor = System.Drawing.Color.White;
            this.btnImport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1925, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 84);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 3;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.picLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.picLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.picLogout_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 962);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 112);
            this.panel2.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(476, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 90);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 36;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.pictureBox2_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(344, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 90);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 35;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnSelect
            // 
            this.btnSelect.Activecolor = System.Drawing.Color.Green;
            this.btnSelect.BackColor = System.Drawing.Color.Green;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.BorderRadius = 24;
            this.btnSelect.ButtonText = "Select";
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSelect.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSelect.Iconimage")));
            this.btnSelect.Iconimage_right = null;
            this.btnSelect.Iconimage_right_Selected = null;
            this.btnSelect.Iconimage_Selected = null;
            this.btnSelect.IconZoom = 65D;
            this.btnSelect.IsTab = false;
            this.btnSelect.Location = new System.Drawing.Point(8, 11);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Normalcolor = System.Drawing.Color.Green;
            this.btnSelect.OnHovercolor = System.Drawing.Color.Black;
            this.btnSelect.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSelect.selected = false;
            this.btnSelect.Size = new System.Drawing.Size(297, 89);
            this.btnSelect.TabIndex = 33;
            this.btnSelect.Textcolor = System.Drawing.Color.White;
            this.btnSelect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuSeparator2);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 76);
            this.panel3.TabIndex = 8;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 66);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(569, 10);
            this.bunifuSeparator2.TabIndex = 10;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(495, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 63);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(3, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(486, 40);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search Contact";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(2012, 1074);
            this.Controls.Add(this.lstContactList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlContact);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox titleLogo;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel pnlContact;
        private Bunifu.Framework.UI.BunifuSeparator sepSecond;
        private Bunifu.Framework.UI.BunifuSeparator sepThird;
        private Bunifu.Framework.UI.BunifuSeparator sepFirst;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMidName;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.TextBox txtFirstName;
        private Bunifu.Framework.UI.BunifuSeparator sepFifth;
        private Bunifu.Framework.UI.BunifuSeparator sepSixth;
        private Bunifu.Framework.UI.BunifuSeparator sepFourth;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdBtnOthers;
        private System.Windows.Forms.RadioButton rdBtnFemale;
        private System.Windows.Forms.RadioButton rdBtnMale;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLandNo;
        private System.Windows.Forms.TextBox txtMobNo;
        private Bunifu.Framework.UI.BunifuSeparator sepNinth;
        private Bunifu.Framework.UI.BunifuSeparator sepEight;
        private System.Windows.Forms.TextBox txtRelation;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuSeparator sepSeventh;
        private System.Windows.Forms.OpenFileDialog DialogContact;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.ListView lstContactList;
        private System.Windows.Forms.ImageList imgContactList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSelect;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private Bunifu.Framework.UI.BunifuFlatButton btnExport;
        private Bunifu.Framework.UI.BunifuFlatButton btnImport;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnCancel;
    }
}