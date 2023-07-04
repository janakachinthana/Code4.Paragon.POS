using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code4.Paragon.POS.Client.Master
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);

        private void frmUser_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Code4_Parogon_POSDataSet.MFUser' table. You can move, or remove it, as needed.
            //this.mFUserTableAdapter.Fill(this._Code4_Parogon_POSDataSet.MFUser);
            //mFUserBindingSource.DataSource = this._Code4_Parogon_POSDataSet.MFUser;
        }

        private void btnUserCreate_Click_1(object sender, EventArgs e)
        {
            Guid Id = Guid.NewGuid();
            string FirstName = txtUserFirstName.Text.ToString();
            string LastName = txtUserLastName.Text.ToString();
            string NIC = txtUserNIC.Text.ToString();
            string Email = txtUserEmail.Text.ToString();
            string PhoneNumber = txtUserPhoneNumber.Text.ToString();
            string Address1 = txtUserAddress1.Text.ToString();
            string Address2 = txtUserAddress2.Text.ToString();
            string Password = txtUserPassword.Text.ToString();
            string hashedValue = GetSHA256Hash(Password);
            string Gender = txtUserGender.Text.ToString();
            string Image = null;
            string OutputMessage = string.Empty;

            string test = GetSHA256Hash(Password);
            if (test == hashedValue) {

                MessageBox.Show("True");
            }

            conn.Open();

            using (SqlCommand command = new SqlCommand("spUserCreate", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add any necessary parameters to the command
                command.Parameters.AddWithValue("Id", Id);
                command.Parameters.AddWithValue("FirstName", FirstName);
                command.Parameters.AddWithValue("LastName", LastName);
                command.Parameters.AddWithValue("NIC", NIC);
                command.Parameters.AddWithValue("Email", Email);
                command.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("Address1", Address1);
                command.Parameters.AddWithValue("Address2", Address2);
                command.Parameters.AddWithValue("Image", Image);
                command.Parameters.AddWithValue("Gender", Gender);
                command.Parameters.AddWithValue("Password", hashedValue);
              

                // Add an output parameter to retrieve the return message
                SqlParameter returnMessageParameter = new SqlParameter("@ReturnMessage", SqlDbType.NVarChar, 200);
                returnMessageParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(returnMessageParameter);

                command.ExecuteNonQuery();

                // Retrieve the return message from the output parameter
                string returnMessage = returnMessageParameter.Value.ToString();

                // Display the return message in a MessageBox
                MessageBox.Show(returnMessage);
            }
            // Close the connection
            conn.Close();


        }
        private void btnUserEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUserCancel_Click_1(object sender, EventArgs e)
        {
         
        }

       

        private void btnUserDelete_Click_1(object sender, EventArgs e)
        {

        }


        private void btnUserBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "JPEG|*.jpg",ValidateNames = true, Multiselect=false })
                {
                    if (fileDialog.ShowDialog()==DialogResult.OK) 
                    {
                        pctrUserProfile.Image = Image.FromFile(fileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User Master", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete) 
            {
                if (MessageBox.Show("Are you sure to delete this record?", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    mFUserBindingSource.RemoveCurrent();
                }
            }
        }

        private void txtUserSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            {
                if (string.IsNullOrEmpty(txtUserSearchBox.Text))
                {
                    grdUser.DataSource = mFUserBindingSource;
                }
                else 
                {
                    //var resualt = this._Code4_Parogon_POSDataSet.MFUser.Where(x => x.FirstName.Contains(txtUserSearchBox.Text));
                }
            }
        }
        // ...

        private static string GetSHA256Hash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

    }
}
