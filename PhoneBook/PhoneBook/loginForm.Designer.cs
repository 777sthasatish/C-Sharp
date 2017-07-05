namespace PhoneBook
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.titleLogo = new System.Windows.Forms.PictureBox();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnSignin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sepPwd = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.sepUsrName = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblRegTitle = new System.Windows.Forms.Label();
            this.sepRePassword = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sepPassword = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtRegisterPass = new System.Windows.Forms.TextBox();
            this.sepUsername = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtRUsername = new System.Windows.Forms.TextBox();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
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
            this.pnlTitle.Size = new System.Drawing.Size(1142, 59);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1077, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(62, 45);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseClick);
            this.picClose.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
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
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(133, 131);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("CANDY INC.", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.lblLogo.Location = new System.Drawing.Point(151, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(479, 151);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "My Phonebook";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.btnSignin);
            this.pnlLogin.Controls.Add(this.sepPwd);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.sepUsrName);
            this.pnlLogin.Controls.Add(this.lblLoginTitle);
            this.pnlLogin.Controls.Add(this.txtUserName);
            this.pnlLogin.Location = new System.Drawing.Point(165, 223);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(826, 550);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnSignin
            // 
            this.btnSignin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(34)))));
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(34)))));
            this.btnSignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignin.BorderRadius = 24;
            this.btnSignin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSignin.ButtonText = "Signin";
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignin.Iconimage")));
            this.btnSignin.Iconimage_right = null;
            this.btnSignin.Iconimage_right_Selected = null;
            this.btnSignin.Iconimage_Selected = null;
            this.btnSignin.IconZoom = 65D;
            this.btnSignin.IsTab = false;
            this.btnSignin.Location = new System.Drawing.Point(245, 436);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(34)))));
            this.btnSignin.OnHovercolor = System.Drawing.Color.White;
            this.btnSignin.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSignin.selected = false;
            this.btnSignin.Size = new System.Drawing.Size(256, 105);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.Textcolor = System.Drawing.Color.White;
            this.btnSignin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // sepPwd
            // 
            this.sepPwd.BackColor = System.Drawing.Color.Transparent;
            this.sepPwd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepPwd.LineThickness = 2;
            this.sepPwd.Location = new System.Drawing.Point(22, 331);
            this.sepPwd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sepPwd.Name = "sepPwd";
            this.sepPwd.Size = new System.Drawing.Size(786, 11);
            this.sepPwd.TabIndex = 5;
            this.sepPwd.Transparency = 255;
            this.sepPwd.Vertical = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(22, 270);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(786, 46);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // sepUsrName
            // 
            this.sepUsrName.BackColor = System.Drawing.Color.Transparent;
            this.sepUsrName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepUsrName.LineThickness = 2;
            this.sepUsrName.Location = new System.Drawing.Point(22, 200);
            this.sepUsrName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sepUsrName.Name = "sepUsrName";
            this.sepUsrName.Size = new System.Drawing.Size(786, 11);
            this.sepUsrName.TabIndex = 10;
            this.sepUsrName.Transparency = 255;
            this.sepUsrName.Vertical = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLoginTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoginTitle.Font = new System.Drawing.Font("Arkhip", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(39, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(752, 72);
            this.lblLoginTitle.TabIndex = 1;
            this.lblLoginTitle.Text = "    Login to Phonebook    ";
            this.lblLoginTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(22, 139);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(786, 46);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Enter Username or Email";
            this.txtUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserName_MouseClick);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLogo.Controls.Add(this.btnCreate);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 59);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1142, 294);
            this.pnlLogo.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.BorderRadius = 24;
            this.btnCreate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCreate.ButtonText = "Create Account";
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreate.Iconimage")));
            this.btnCreate.Iconimage_right = null;
            this.btnCreate.Iconimage_right_Selected = null;
            this.btnCreate.Iconimage_Selected = null;
            this.btnCreate.IconZoom = 65D;
            this.btnCreate.IsTab = false;
            this.btnCreate.Location = new System.Drawing.Point(739, 12);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.btnCreate.OnHovercolor = System.Drawing.Color.White;
            this.btnCreate.OnHoverTextColor = System.Drawing.SystemColors.WindowText;
            this.btnCreate.selected = false;
            this.btnCreate.Size = new System.Drawing.Size(403, 93);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Textcolor = System.Drawing.Color.White;
            this.btnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.pnlRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRegister.Controls.Add(this.lblRegTitle);
            this.pnlRegister.Controls.Add(this.sepRePassword);
            this.pnlRegister.Controls.Add(this.txtRePassword);
            this.pnlRegister.Controls.Add(this.btnSave);
            this.pnlRegister.Controls.Add(this.sepPassword);
            this.pnlRegister.Controls.Add(this.txtRegisterPass);
            this.pnlRegister.Controls.Add(this.sepUsername);
            this.pnlRegister.Controls.Add(this.txtRUsername);
            this.pnlRegister.Location = new System.Drawing.Point(0, 224);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(535, 549);
            this.pnlRegister.TabIndex = 3;
            this.pnlRegister.Visible = false;
            // 
            // lblRegTitle
            // 
            this.lblRegTitle.AutoSize = true;
            this.lblRegTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRegTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegTitle.Font = new System.Drawing.Font("Arkhip", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.lblRegTitle.Location = new System.Drawing.Point(36, 0);
            this.lblRegTitle.Name = "lblRegTitle";
            this.lblRegTitle.Size = new System.Drawing.Size(758, 72);
            this.lblRegTitle.TabIndex = 13;
            this.lblRegTitle.Text = "  Register to Phonebook  ";
            // 
            // sepRePassword
            // 
            this.sepRePassword.BackColor = System.Drawing.Color.Transparent;
            this.sepRePassword.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepRePassword.LineThickness = 2;
            this.sepRePassword.Location = new System.Drawing.Point(22, 374);
            this.sepRePassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sepRePassword.Name = "sepRePassword";
            this.sepRePassword.Size = new System.Drawing.Size(786, 11);
            this.sepRePassword.TabIndex = 12;
            this.sepRePassword.Transparency = 255;
            this.sepRePassword.Vertical = false;
            // 
            // txtRePassword
            // 
            this.txtRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.ForeColor = System.Drawing.Color.Gray;
            this.txtRePassword.Location = new System.Drawing.Point(22, 313);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(786, 46);
            this.txtRePassword.TabIndex = 2;
            this.txtRePassword.Text = "Re-Enter Password";
            this.txtRePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRePassword_MouseClick_1);
            this.txtRePassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRePassword_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(34)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(34)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 24;
            this.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSave.ButtonText = "Signup";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconZoom = 65D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(244, 432);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(34)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.White;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(269, 105);
            this.btnSave.TabIndex = 3;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sepPassword
            // 
            this.sepPassword.BackColor = System.Drawing.Color.Transparent;
            this.sepPassword.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepPassword.LineThickness = 2;
            this.sepPassword.Location = new System.Drawing.Point(22, 278);
            this.sepPassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sepPassword.Name = "sepPassword";
            this.sepPassword.Size = new System.Drawing.Size(786, 11);
            this.sepPassword.TabIndex = 5;
            this.sepPassword.Transparency = 255;
            this.sepPassword.Vertical = false;
            // 
            // txtRegisterPass
            // 
            this.txtRegisterPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtRegisterPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPass.ForeColor = System.Drawing.Color.Gray;
            this.txtRegisterPass.Location = new System.Drawing.Point(22, 217);
            this.txtRegisterPass.Name = "txtRegisterPass";
            this.txtRegisterPass.Size = new System.Drawing.Size(786, 46);
            this.txtRegisterPass.TabIndex = 1;
            this.txtRegisterPass.Text = "Enter Password";
            this.txtRegisterPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRegisterPass_MouseClick_1);
            this.txtRegisterPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegisterPass_KeyPress);
            // 
            // sepUsername
            // 
            this.sepUsername.BackColor = System.Drawing.Color.Transparent;
            this.sepUsername.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(173)))), ((int)(((byte)(225)))));
            this.sepUsername.LineThickness = 2;
            this.sepUsername.Location = new System.Drawing.Point(22, 174);
            this.sepUsername.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sepUsername.Name = "sepUsername";
            this.sepUsername.Size = new System.Drawing.Size(786, 11);
            this.sepUsername.TabIndex = 10;
            this.sepUsername.Transparency = 255;
            this.sepUsername.Vertical = false;
            // 
            // txtRUsername
            // 
            this.txtRUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.txtRUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtRUsername.Location = new System.Drawing.Point(22, 113);
            this.txtRUsername.Name = "txtRUsername";
            this.txtRUsername.Size = new System.Drawing.Size(786, 46);
            this.txtRUsername.TabIndex = 0;
            this.txtRUsername.Text = "Enter Username or Email";
            this.txtRUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRUsername_MouseClick);
            this.txtRUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUsername_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SeaShell;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(3, 721);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 87);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Visible = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1142, 806);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlTitle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignin;
        private Bunifu.Framework.UI.BunifuSeparator sepPwd;
        private System.Windows.Forms.TextBox txtPassword;
        private Bunifu.Framework.UI.BunifuSeparator sepUsrName;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox titleLogo;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Panel pnlLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreate;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblRegTitle;
        private Bunifu.Framework.UI.BunifuSeparator sepRePassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuSeparator sepPassword;
        private System.Windows.Forms.TextBox txtRegisterPass;
        private Bunifu.Framework.UI.BunifuSeparator sepUsername;
        private System.Windows.Forms.TextBox txtRUsername;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Timer timer1;
    }
}

