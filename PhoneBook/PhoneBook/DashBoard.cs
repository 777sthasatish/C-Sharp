using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using BLL;

namespace PhoneBook
{
    public partial class DashBoard : Form
    {

        public const int WM_NCLButtonDown = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("User32.dll")]
        public static extern bool ReleaseCapture();

        MemoryStream ms;
        private string userName;
        BLLContact bllCon = new BLLContact();
        DataTable dTable = new DataTable();
        ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
        public DashBoard()
        {
            InitializeComponent();
            lstContactList.View = View.Details;
            lstContactList.Columns.Add("Contacts", 500);
            ShowContact();

        }


        //For making the title panel movable.
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
            //lets user to enter at least mobile number or landline number
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
            convertImage();
            Contact con = new Contact();
            con.FirstName = txtFirstName.Text;
            con.MiddleName = txtMidName.Text;
            con.LastName = txtLastName.Text;
            con.Street = txtStreet.Text;
            con.City = txtCity.Text;
            con.Country = txtCountry.Text;
            con.DOB = dtpDOB.Value;
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
            con.Gender = gender;
            con.ContactRelation = txtRelation.Text;
            con.EmailAddress = txtEmail.Text;
            con.MobileNumber = txtMobNo.Text;
            con.LandLineNumber = txtLandNo.Text;
            int inserted = bllCon.CreateContact(con, convertImage());
            if (inserted > 0)
            {
                MessageBox.Show("Inserted Successfully.");
                lstContactList.Items.Clear();
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

        private byte[] convertImage()//function to convert the photo 
        {
            byte[] photo_aray = new byte[ms.Length];
            ms = new MemoryStream();
            if (picContact.Image != null)//checks whether there is image in picture box
            {
                //using FileStream:(will not work while updating, if image is not changed since it uses image location rather than image itself)
                //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                //byte[] photo_aray = new byte[fs.Length];
                //fs.Read(photo_aray, 0, photo_aray.Length);  

                //For now we are using memory stream which is more dynamic and reliable

                picContact.Image.Save(ms, ImageFormat.Jpeg);

                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);

            }
            return ms.ToArray();
        }

        private void ShowContact()
        {
            imgContactList = new ImageList();
            imgContactList.ColorDepth = ColorDepth.Depth32Bit;
            imgContactList.ImageSize = new Size(150, 140);
            byte[] photoArray;
            //BLLContact blc = new BLLContact();
            dTable = bllCon.GetContacts();
            //i represent the rows;
            //contacts.Table[0] retrieves the table located in index 0
            if (dTable.Rows.Count > 0)
            {

                for (int i = 0; i < dTable.Rows.Count; i++)//loops till the last row of the table
                {
                    string uName = null;
                    string id = null;

                    photoArray = (byte[])dTable.Rows[i]["ContactImage"];
                     ms = new MemoryStream(photoArray);
                    imgContactList.Images.Add(Image.FromStream(ms));

                    id = dTable.Rows[i]["ContactID"].ToString();
                    uName = dTable.Rows[i]["FirstName"].ToString() + " " + dTable.Rows[i]["LastName"].ToString();

                    lstContactList.SmallImageList = imgContactList;
                    lstContactList.Items.Add(id, uName, i);

                }

            }
        }

        //logout
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

        //mouse click event for delete button to delete contact
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstContactList.Items)
            {
                if (item.Checked == true)//delete the contacts which has been checked or ticked.Can delete multiple contacts at a time
                {
                    item.Remove();
                    bllCon.DeleteContact(item.Name);
                    normalMode();
                }
                else if (item.Selected)//delete the contacts which has been selected or clicked.Only deletes one contact at a time.
                {
                    item.Remove();
                    bllCon.DeleteContact(item.Name);
                    normalMode();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Contact";
            lstContactList.Items.Clear();
            ShowContact();

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


        //This method is called when we click on a particular contact in a contactlist of list view in order to show details
        //This enables users to edit the contact details
        private void lstContactList_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in lstContactList.Items)
            {
                if (item.Selected == true)//only when an contact is selected from the contact list of list view
                {

                    btnSave.Visible = false;
                    btnEdit.Visible = true;
                    btnEdit.Location = new Point(1090, 790);
                    btnNew.Visible = true;
                    dTable = bllCon.FillForm(item.Name);//Values from BLL of BLLContact method is called upon to fill datatable.
                    showContact();
                }
            }
        }

        //Values that are stored in the variable dTable which is a datatable are extracted and stored in the object contact to make it useful for filling up the contact details form
        private Contact fillContact()
        {
            Contact con = new Contact();
            byte[] photoArray;

            //image on the datatable which is in byte form is retrieved and stored in photoArray which is a array of byte
            photoArray = (byte[])dTable.Rows[0]["ContactImage"];
             ms = new MemoryStream(photoArray);//photoArray is converted into image form by memoryStream
            picContact.Image = Image.FromStream(ms);//image is stored into picContact which is a picture box 

            //values from datatable is stored into the contact object and returned
            con.CID = (int)dTable.Rows[0]["ContactID"];
            con.FirstName = dTable.Rows[0]["FirstName"].ToString();
            con.MiddleName = dTable.Rows[0]["MiddleName"].ToString();
            con.LastName = dTable.Rows[0]["LastName"].ToString();
            con.Street = dTable.Rows[0]["Street"].ToString();
            con.City = dTable.Rows[0]["City"].ToString();
            con.Country = dTable.Rows[0]["Country"].ToString();
            con.DOB = DateTime.Parse(dTable.Rows[0]["DOB"].ToString());
            con.Gender = dTable.Rows[0]["Gender"].ToString();
            con.ContactRelation = dTable.Rows[0]["ContactRelation"].ToString();
            con.EmailAddress = dTable.Rows[0]["EmailAddress"].ToString();
            con.MobileNumber = dTable.Rows[0]["MobileNumber"].ToString();
            con.LandLineNumber = dTable.Rows[0]["LandlineNumber"].ToString();
            return con;
        }

        //Finally this method populates values into the contact form
        private void showContact()
        {
            Contact c = fillContact();//contact object which has values returned by fillContact method is stored into another Contact object.
            if (!String.IsNullOrEmpty(c.FirstName))
            {
                txtFirstName.Text = c.FirstName;
            }
            if (!String.IsNullOrEmpty(c.MiddleName))
            {
                txtMidName.Text = c.MiddleName;
            }
            if (!String.IsNullOrEmpty(c.LastName))
            {
                txtLastName.Text = c.LastName;
            }
            if (!String.IsNullOrEmpty(c.Street))
            {
                txtStreet.Text = c.Street;
            }
            if (!String.IsNullOrEmpty(c.City))
            {
                txtCity.Text = c.City;
            }
            if (!String.IsNullOrEmpty(c.Country))
            {
                txtCountry.Text = c.Country;
            }
            if (!String.IsNullOrEmpty(c.ContactRelation))
            {
                txtRelation.Text = c.ContactRelation;
            }

            if (c.Gender.Equals("Male"))
            {
                rdBtnMale.Checked = true;
            }
            else if (c.Gender.Equals("Female"))
            {
                rdBtnFemale.Checked = true;
            }
            else
            {
                rdBtnOthers.Checked = true;
            }

            dtpDOB.Value = c.DOB;
            if (!String.IsNullOrEmpty(c.EmailAddress))
            {
                txtEmail.Text = c.EmailAddress;
            }
            if (!String.IsNullOrEmpty(c.MobileNumber))
            {
                txtMobNo.Text = c.MobileNumber;
            }
            if (!String.IsNullOrEmpty(c.LandLineNumber))
            {
                txtLandNo.Text = c.LandLineNumber;
            }
        }
        //changes contact form panel to default state i.e new contact button being enable and other buttons being disabled
        private void normalMode()
        {
            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnNew.Visible = false;
            ChangeTextBox();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            normalMode();
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.Size = new Size(92, 99);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.Size = new Size(87, 94);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ChangeTextBox();
        }

        //shows the search result when search parameter in contact list is passed 
        private void ShowSearchResult()
        {
            lstContactList.Items.Clear();
            if (dTable.Rows.Count > 0)
            {
                byte[] photoArray;
                Contact con = new Contact();
                ImageList imgContactList = new ImageList();
                imgContactList.ColorDepth = ColorDepth.Depth32Bit;
                imgContactList.ImageSize = new Size(150, 140);
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    photoArray = (byte[])dTable.Rows[i]["ContactImage"];
                     ms = new MemoryStream(photoArray);
                    imgContactList.Images.Add(Image.FromStream(ms));

                    con.CID = (int)dTable.Rows[i]["ContactID"];
                    con.FirstName = dTable.Rows[i]["FirstName"].ToString();
                    con.LastName = dTable.Rows[i]["LastName"].ToString();

                    lstContactList.SmallImageList = imgContactList;
                    lstContactList.Items.Add(con.CID.ToString(), con.FirstName + " " + con.LastName, i);

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //whenever search parameter is passed in the contact list searches the contacts regarding the search parameter and retrives values from the database and store it in datatable
            dTable = bllCon.SearchContact(txtSearch.Text);
            //calls upon the ShowSearchResult to view the contacts searched
            ShowSearchResult();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "Search Contact")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.FromArgb(67, 173, 225);
            }
        }
    }
}
