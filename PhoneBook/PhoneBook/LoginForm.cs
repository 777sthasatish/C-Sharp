using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using BLL;
using System.Data;
using DAL;

namespace PhoneBook
{
    public partial class loginForm : Form
    {
        public const int WM_NCLButtonDown = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("User32.dll")]
        public static extern bool ReleaseCapture();
        private static String connectionString;
        private static SqlConnection connection;
        private static String userName;
        public loginForm()
        {
            InitializeComponent();
            connectionString = "Data Source=PARTH;Initial Catalog=Phonebook;Integrated Security=True";
            connection = new SqlConnection(connectionString);

        }
        public void setName(string name)
        {
            userName = name;
        }
        public static string getName()
        {
            return userName;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Crimson;
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {

        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(22, 59, 91);
        }

        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            showRegister();
            defaultRegister();
        }

        private void showRegister()
        {
            pnlLogin.Visible = false;
            pnlRegister.Visible = true;
            pnlRegister.Location = new Point(165, 223);
            pnlRegister.Size = new Size(826, 550);
            btnBack.Visible = true;
            btnCreate.Visible = false;
        }
        private void defaultRegister()
        {
            txtRUsername.Text = "Enter Username or Email";
            txtRUsername.ForeColor = Color.Gray;
            txtRegisterPass.PasswordChar = new char();
            txtRegisterPass.Text = "Enter Password";
            txtRegisterPass.ForeColor = Color.Gray;
            txtRePassword.PasswordChar = new char();
            txtRePassword.Text = "Re-Enter Password";
            txtRePassword.ForeColor = Color.Gray;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            hideRegister();
            defaultLogin();
        }

        private void hideRegister()
        {
            pnlRegister.Location = new Point(0, 224);
            pnlRegister.Size = new Size(515, 549);
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
            btnBack.Visible = false;
            btnCreate.Visible = true;
        }

        private void defaultLogin()
        {
            txtUserName.Text = "Enter Username or Email";
            txtUserName.ForeColor = Color.Gray;
            txtPassword.Text = "Enter Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = new char();
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text.Equals("Enter Username or Email"))
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUserName.Text.Equals("Enter Username or Email"))
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.PasswordChar.Equals('*') == false)
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.FromArgb(67, 173, 225);
            }

        }

        private void txtRUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtRUsername.Text.Equals("Enter Username or Email"))
            {
                txtRUsername.Text = "";
                txtRUsername.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtRegisterPass_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtRePassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (!txtRePassword.PasswordChar.Equals('*'))
            {
                txtRePassword.Text = "";
                txtRePassword.PasswordChar = '*';
                txtRePassword.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtRegisterPass_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (!txtRegisterPass.PasswordChar.Equals('*'))
            {
                txtRegisterPass.Text = "";
                txtRegisterPass.PasswordChar = '*';
                txtRegisterPass.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtRePassword_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (!txtRePassword.PasswordChar.Equals('*'))
            {
                txtRePassword.Text = "";
                txtRePassword.PasswordChar = '*';
                txtRePassword.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLButtonDown, HT_CAPTION, 0);
            }
        }
        private void InsertUsers()
        {
            Users u = new Users();
            u.UserName = txtRUsername.Text;
            u.Password = txtRegisterPass.Text;

            BLLUser blu = new BLLUser();
            blu.CreateUser(u);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool inserted = ValidateRegister();
            if (inserted == true)
            {
                hideRegister();
                defaultLogin();
            }

        }

        private bool ValidateRegister()
        {
            bool inserted = false;
            if ((txtRUsername.Text == "" || string.IsNullOrEmpty(txtRegisterPass.Text) || string.IsNullOrEmpty(txtRePassword.Text)) || (txtRUsername.Text.Equals("Enter Username or Email") || txtRegisterPass.Text.Equals("Enter Password") || txtRePassword.Text.Equals("Re-Enter Password")))
            {
                MessageBox.Show("Empty value found. Please fill up all the details");
            }
            else if (!txtRePassword.Text.Equals(txtRegisterPass.Text))
            {
                MessageBox.Show("You have entered two different passwords.");
            }
            else
            {
                string username = txtRUsername.Text;
                BLLUser blu = new BLLUser();
                DataTable dt = blu.CheckUserName(username);
                if (dt.Rows.Count > 0)
                {
                    if (!username.ToLower().Equals(dt.Rows[0]["Username"].ToString().ToLower()))
                    {
                        InsertUsers();
                        MessageBox.Show("Registered successfully.");
                        inserted = true;
                    }
                    else
                    {
                        txtRUsername.Focus();
                        MessageBox.Show(username + " username has already been used.");
                    }
                }
                else
                {
                    InsertUsers();
                    MessageBox.Show("Registered Successfully");
                    inserted = true;
                }
            }
            return inserted;
        }

        private void txtRUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtRUsername.Text.Equals("Enter Username or Email"))
            {
                txtRUsername.Text = "";
                txtRUsername.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtRegisterPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtRegisterPass.Text.Equals("Enter Password"))
            {
                txtRegisterPass.Text = "";
                txtRegisterPass.PasswordChar = '*';
                txtRegisterPass.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }



        private void txtRePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtRePassword.Text.Equals("Re-Enter Password"))
            {
                txtRePassword.Text = "";
                txtRePassword.PasswordChar = '*';
                txtRePassword.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPassword.Text.Equals("Enter Password"))
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            ValidateLogin();

        }

        private void ValidateLogin()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username == "" || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Empty value found. Please fill up all the details");
            }
            else
            {
                BLLUser blu = new BLLUser();
                DataTable dts = blu.Login(username, password);
                if (dts.Rows.Count > 0)
                {
                        MessageBox.Show("Login Successfully.");
                        this.Hide();
                        DashBoard db = new DashBoard();
                        db.setUserName(txtUserName.Text);
                        db.Show();
                }
                else
                {
                    MessageBox.Show("Please enter correct username or password");
                }
            }
        }
    }
}

