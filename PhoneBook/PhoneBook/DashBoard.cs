using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace PhoneBook
{
    public partial class DashBoard : Form
    {
        ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
        public const int WM_NCLButtonDown = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("User32.dll")]
        public static extern bool ReleaseCapture();
        string connectionString = null;
        DataSet contacts;
        SqlCommand cmd;
        SqlConnection connection;
        MemoryStream ms;
        private string userName;
        public DashBoard()
        {
            InitializeComponent();
            connectionString = "Data Source=PARTH;Initial Catalog=Phonebook;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            LoadContact();
            lstContactList.View = View.Details;
            lstContactList.Columns.Add("Contacts", 500);
            ShowContact();


        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator7_Load(object sender, EventArgs e)
        {

        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLButtonDown, HT_CAPTION, 0);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstContactList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtFirstName.Text.Equals("First Name"))
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Crimson;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(22, 59, 91);
        }

        private void txtMidName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtMidName.Text.Equals("Middle Name"))
            {
                txtMidName.Text = "";
                txtMidName.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtLastName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLastName.Text.Equals("Last Name"))
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFirstName.Text.Equals("First Name"))
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtMidName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMidName.Text.Equals("Middle Name"))
            {
                txtMidName.Text = "";
                txtMidName.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLastName.Text.Equals("Last Name"))
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtStreet_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtStreet.Text.Equals("Street"))
            {
                txtStreet.Text = "";
                txtStreet.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtStreet.Text.Equals("Street"))
            {
                txtStreet.Text = "";
                txtStreet.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtCity_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCity.Text.Equals("City"))
            {
                txtCity.Text = "";
                txtCity.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCity.Text.Equals("City"))
            {
                txtCity.Text = "";
                txtCity.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtCountry_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCountry.Text.Equals("Country"))
            {
                txtCountry.Text = "";
                txtCountry.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtRelation_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtRelation.Text.Equals("Contact Relation"))
            {
                txtRelation.Text = "";
                txtRelation.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtRelation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtRelation.Text.Equals("Contact Relation"))
            {
                txtRelation.Text = "";
                txtRelation.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmail.Text.Equals("Email Address"))
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text.Equals("Email Address"))
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtMobNo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtMobNo.Text.Equals("Mobile Number"))
            {
                txtMobNo.Text = "";
                txtMobNo.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtMobNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMobNo.Text.Equals("Mobile Number"))
            {
                txtMobNo.Text = "";
                txtMobNo.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtLandNo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLandNo.Text.Equals("Landline Number"))
            {
                txtLandNo.Text = "";
                txtLandNo.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtLandNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLandNo.Text.Equals("Landline Number"))
            {
                txtLandNo.Text = "";
                txtLandNo.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void txtCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCountry.Text.Equals("Country"))
            {
                txtCountry.Text = "";
                txtCountry.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }

        private void ChangeTextBox()
        {
            txtFirstName.ForeColor = Color.Gray;
            txtFirstName.Text = "First Name";

            txtMidName.ForeColor = Color.Gray;
            txtMidName.Text = "Middle Name";

            txtLastName.ForeColor = Color.Gray;
            txtLastName.Text = "Last Name";

            txtStreet.ForeColor = Color.Gray;
            txtStreet.Text = "Street";

            txtCity.ForeColor = Color.Gray;
            txtCity.Text = "City";

            txtCountry.ForeColor = Color.Gray;
            txtCountry.Text = "Country";

            txtRelation.ForeColor = Color.Gray;
            txtRelation.Text = "Contact Relation";

            txtEmail.ForeColor = Color.Gray;
            txtEmail.Text = "Email Address";

            txtMobNo.ForeColor = Color.Gray;
            txtMobNo.Text = "Mobile Number";

            txtLandNo.ForeColor = Color.Gray;
            txtLandNo.Text = "Landline Number";
            picContact.Image = ((System.Drawing.Image)(resources.GetObject("picContact.Image")));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtMobNo.Text == "" || txtMobNo.Text.Equals("Mobile Number")) && (txtLandNo.Text == "" || txtLandNo.Text.Equals("Landline Number")))
            {
                MessageBox.Show("Mobile and Landline number both can't be empty.Please enter either of two values.");
            }
            else
            {
                validateContact();
                InsertContact();
                ChangeTextBox();

            }
        }

        private void InsertContact()
        {
            cmd = new SqlCommand("INSERT INTO tbl_contact(FirstName,MiddleName,LastName,Street,City,Country,DOB,Gender,ContactRelation,EmailAddress,MobileNumber,LandlineNumber,ContactImage)  VALUES(@fName,@mName,@lName,@street,@city,@country,@dob,@gender,@contactRelation,@eMail,@mobileNo,@landNo,@image)");

            connection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@mName", txtMidName.Text);
            cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@street", txtStreet.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@country", txtCountry.Text);
            String gender;
            if (rdBtnOthers.Checked == true)
            {
                gender = rdBtnOthers.Text;
            }
            else if (rdBtnFemale.Checked == true)
            {
                gender = rdBtnFemale.Text;
            }
            else
            {
                gender = rdBtnMale.Text;
            }
            cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@contactRelation", txtRelation.Text);
            cmd.Parameters.AddWithValue("@eMail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@mobileNo", txtMobNo.Text);
            cmd.Parameters.AddWithValue("@landNo", txtLandNo.Text);
            convertImage();

            int inserted = cmd.ExecuteNonQuery();
            connection.Close();

            if (inserted > 0)
            {
                MessageBox.Show("Inserted Successfully.");
                lstContactList.Items.Clear();
                LoadContact();
                ShowContact();
            }
            else
            {
                MessageBox.Show("Fail to insert.");
            }
        }

        private void validateContact()
        {
            if (txtFirstName.Text.Equals("First Name"))
            {
                txtFirstName.Text = "";
            }
            if (txtMidName.Text.Equals("Middle Name"))
            {
                txtMidName.Text = "";
            }
            if (txtLastName.Text.Equals("Last Name"))
            {
                txtLastName.Text = "";
            }
            if (txtStreet.Text.Equals("Street"))
            {
                txtStreet.Text = "";
            }
            if (txtCity.Text.Equals("City"))
            {
                txtCity.Text = "";
            }
            if (txtCountry.Text.Equals("Country"))
            {
                txtCountry.Text = "";
            }
            if (txtRelation.Text.Equals("Contact Relation"))
            {
                txtRelation.Text = "";
            }
            if (txtEmail.Text.Equals("Email Address"))
            {
                txtEmail.Text = "";
            }
            if (txtMobNo.Text.Equals("Mobile Number"))
            {
                txtMobNo.Text = "";
            }
            if (txtLandNo.Text.Equals("Landline Number"))
            {
                txtLandNo.Text = "";
            }

        }

        private void picContact_MouseEnter(object sender, EventArgs e)
        {
            picContact.Size = new Size(262, 262);
        }

        private void picContact_MouseLeave(object sender, EventArgs e)
        {
            picContact.Size = new Size(256, 256);
        }

        private void picContact_Click(object sender, EventArgs e)
        {

            //opens a dialog box to select image file only
            DialogContact.Filter = "jpeg|*.jpg|bmp|*.bmp|png|*.png";
            DialogResult res = DialogContact.ShowDialog();
            if (res == DialogResult.OK)
            {
                //Image file is loaded into the picture box selected from dialog box
                picContact.Image = Image.FromFile(DialogContact.FileName);
            }
        }

        private void convertImage()//function to convert the photo 
        {
            if (picContact.Image != null)//checks whether there is image in picture box
            {
                //using FileStream:(will not work while updating, if image is not changed since it uses image location rather than image itself)
                //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                //byte[] photo_aray = new byte[fs.Length];
                //fs.Read(photo_aray, 0, photo_aray.Length);  

                //For now we are using memory stream which is more dynamic and reliable
                ms = new MemoryStream();
                picContact.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@image", photo_aray);

            }

        }

        private void LoadContact()
        {
            string query = "Select ContactImage,FirstName,LastName,ContactID from tbl_contact";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            contacts = new DataSet();
            adapter.Fill(contacts, "tbl_contact");
        }

        private void ShowContact()
        {
            byte[] photoArray;
            //i represent the rows;
            //contacts.Table[0] retrieves the table located in index 0
            if (contacts.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show(contacts.Tables[0].Rows.Count.ToString());
                for (int i = 0; i < contacts.Tables[0].Rows.Count; i++)//loops till the last row of the table
                {
                    string uName = null;
                    string id = null;

                    //j represents the columns
                    for (int j = 0; j < 4; j++)//loops till the last column
                    {
                        if (j == 0)
                        {
                            photoArray = (byte[])contacts.Tables[0].Rows[i][j];
                            MemoryStream ms = new MemoryStream(photoArray);
                            imgContactList.Images.Add(Image.FromStream(ms));
                        }
                        else if (j == 3)
                        {
                            id = contacts.Tables[0].Rows[i][j].ToString();
                        }
                        else
                        {
                            string value = contacts.Tables[0].Rows[i][j].ToString();
                            uName = uName + " " + value;
                        }
                    }
                    lstContactList.Items.Add(id, uName, i);
                }
            }
            lstContactList.SmallImageList = imgContactList;
        }


        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            loginForm lf = new loginForm();
            lf.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = getUserName();

        }

        public void setUserName(string name)
        {
            userName = name;
        }

        public string getUserName()
        {
            return userName;
        }

        private void picLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.Size = new Size(80, 90);
        }

        private void picLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.Size = new Size(75, 84);
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm lf = new loginForm();
            lf.Show();
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstContactList.Items.Count > 0)
            {
                if (btnSelect.ButtonText == "Select")
                {
                    lstContactList.CheckBoxes = true;
                    btnSelect.ButtonText = "Select All";

                }
                else if (btnSelect.ButtonText == "Select All")
                {
                    foreach (ListViewItem item in lstContactList.Items)
                    {
                        item.Checked = true;
                    }
                }

            }

        }

        private void deleteContact(string id)
        {
            int conId = Convert.ToInt32(id);
            cmd = new SqlCommand("Delete from tbl_contact where ContactID=@id");
            connection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@id", conId);
            cmd.ExecuteNonQuery();
            connection.Close();

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstContactList.Items)
            {
                if (item.Checked == true)
                {
                    item.Remove();
                    deleteContact(item.Name);
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lstContactList.CheckBoxes = false;
            foreach (ListViewItem item in lstContactList.Items)
            {
                item.Checked = false;
            }
            btnSelect.ButtonText = "Select";
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.Size = new Size(100, 100);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Size = new Size(90, 90);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.Size = new Size(100, 100);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Size = new Size(90, 90);
        }

        private void getValue(string name)
        {
            int id = Convert.ToInt32(name);
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from tbl_Contact where ContactID=@id", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            contacts = new DataSet();
            adapter.Fill(contacts, "tbl_contact");
            connection.Close();
        }
        private void fillContact()
        {
            if (contacts.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < contacts.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < contacts.Tables[0].Columns.Count; j++)
                    {

                    }
                }
            }
        }
        private void lstContactList_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in lstContactList.Items)
            {
                if (item.Selected == true)
                {
                    //getValue(item.Name);
                }
            }
        }
    }


}
