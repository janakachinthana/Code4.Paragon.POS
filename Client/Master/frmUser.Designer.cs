using System.Drawing;
using System.Windows.Forms;

namespace Code4.Paragon.POS.Client.Master
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.PnlUserTop = new System.Windows.Forms.Panel();
            this.txtUserGender = new System.Windows.Forms.TextBox();
            this.lblUserGender = new System.Windows.Forms.Label();
            this.txtUserConfPassword = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserConfPW = new System.Windows.Forms.Label();
            this.lblUserPW = new System.Windows.Forms.Label();
            this.btnUserBrowse = new System.Windows.Forms.Button();
            this.txtUserPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblUserPhoneNumber = new System.Windows.Forms.Label();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.txtUserAddress2 = new System.Windows.Forms.TextBox();
            this.txtUserAddress1 = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserNIC = new System.Windows.Forms.TextBox();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.txtUserFirstName = new System.Windows.Forms.TextBox();
            this.lblUserAddress2 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserAddress1 = new System.Windows.Forms.Label();
            this.lblUserNIC = new System.Windows.Forms.Label();
            this.lblUserFirstName = new System.Windows.Forms.Label();
            this.pctrUserProfile = new System.Windows.Forms.PictureBox();
            this.mFUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.txtUserSearchBox = new System.Windows.Forms.TextBox();
            this.PnlUserTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlUserTop
            // 
            this.PnlUserTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlUserTop.AutoSize = true;
            this.PnlUserTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlUserTop.Controls.Add(this.txtUserGender);
            this.PnlUserTop.Controls.Add(this.lblUserGender);
            this.PnlUserTop.Controls.Add(this.txtUserConfPassword);
            this.PnlUserTop.Controls.Add(this.txtUserPassword);
            this.PnlUserTop.Controls.Add(this.lblUserConfPW);
            this.PnlUserTop.Controls.Add(this.lblUserPW);
            this.PnlUserTop.Controls.Add(this.btnUserBrowse);
            this.PnlUserTop.Controls.Add(this.txtUserPhoneNumber);
            this.PnlUserTop.Controls.Add(this.lblUserPhoneNumber);
            this.PnlUserTop.Controls.Add(this.btnUserEdit);
            this.PnlUserTop.Controls.Add(this.btnUserCancel);
            this.PnlUserTop.Controls.Add(this.btnUserDelete);
            this.PnlUserTop.Controls.Add(this.btnUserCreate);
            this.PnlUserTop.Controls.Add(this.txtUserAddress2);
            this.PnlUserTop.Controls.Add(this.txtUserAddress1);
            this.PnlUserTop.Controls.Add(this.txtUserEmail);
            this.PnlUserTop.Controls.Add(this.txtUserNIC);
            this.PnlUserTop.Controls.Add(this.txtUserLastName);
            this.PnlUserTop.Controls.Add(this.txtUserFirstName);
            this.PnlUserTop.Controls.Add(this.lblUserAddress2);
            this.PnlUserTop.Controls.Add(this.lblLastName);
            this.PnlUserTop.Controls.Add(this.lblUserEmail);
            this.PnlUserTop.Controls.Add(this.lblUserAddress1);
            this.PnlUserTop.Controls.Add(this.lblUserNIC);
            this.PnlUserTop.Controls.Add(this.lblUserFirstName);
            this.PnlUserTop.Controls.Add(this.pctrUserProfile);
            this.PnlUserTop.Location = new System.Drawing.Point(0, 0);
            this.PnlUserTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlUserTop.Name = "PnlUserTop";
            this.PnlUserTop.Size = new System.Drawing.Size(1347, 251);
            this.PnlUserTop.TabIndex = 0;
            // 
            // txtUserGender
            // 
            this.txtUserGender.Location = new System.Drawing.Point(904, 92);
            this.txtUserGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserGender.Name = "txtUserGender";
            this.txtUserGender.Size = new System.Drawing.Size(266, 22);
            this.txtUserGender.TabIndex = 26;
            // 
            // lblUserGender
            // 
            this.lblUserGender.AutoSize = true;
            this.lblUserGender.Location = new System.Drawing.Point(761, 95);
            this.lblUserGender.Name = "lblUserGender";
            this.lblUserGender.Size = new System.Drawing.Size(55, 16);
            this.lblUserGender.TabIndex = 25;
            this.lblUserGender.Text = "Gender:";
            // 
            // txtUserConfPassword
            // 
            this.txtUserConfPassword.Location = new System.Drawing.Point(904, 143);
            this.txtUserConfPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserConfPassword.Name = "txtUserConfPassword";
            this.txtUserConfPassword.Size = new System.Drawing.Size(266, 22);
            this.txtUserConfPassword.TabIndex = 24;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(904, 117);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(266, 22);
            this.txtUserPassword.TabIndex = 23;
            // 
            // lblUserConfPW
            // 
            this.lblUserConfPW.AutoSize = true;
            this.lblUserConfPW.Location = new System.Drawing.Point(761, 145);
            this.lblUserConfPW.Name = "lblUserConfPW";
            this.lblUserConfPW.Size = new System.Drawing.Size(118, 16);
            this.lblUserConfPW.TabIndex = 22;
            this.lblUserConfPW.Text = "Confirm Password:";
            // 
            // lblUserPW
            // 
            this.lblUserPW.AutoSize = true;
            this.lblUserPW.Location = new System.Drawing.Point(761, 120);
            this.lblUserPW.Name = "lblUserPW";
            this.lblUserPW.Size = new System.Drawing.Size(70, 16);
            this.lblUserPW.TabIndex = 21;
            this.lblUserPW.Text = "Password:";
            // 
            // btnUserBrowse
            // 
            this.btnUserBrowse.Location = new System.Drawing.Point(38, 193);
            this.btnUserBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserBrowse.Name = "btnUserBrowse";
            this.btnUserBrowse.Size = new System.Drawing.Size(94, 23);
            this.btnUserBrowse.TabIndex = 20;
            this.btnUserBrowse.Text = "Browse";
            this.btnUserBrowse.UseVisualStyleBackColor = true;
            this.btnUserBrowse.Click += new System.EventHandler(this.btnUserBrowse_Click);
            // 
            // txtUserPhoneNumber
            // 
            this.txtUserPhoneNumber.Location = new System.Drawing.Point(458, 95);
            this.txtUserPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPhoneNumber.Name = "txtUserPhoneNumber";
            this.txtUserPhoneNumber.Size = new System.Drawing.Size(266, 22);
            this.txtUserPhoneNumber.TabIndex = 18;
            // 
            // lblUserPhoneNumber
            // 
            this.lblUserPhoneNumber.AutoSize = true;
            this.lblUserPhoneNumber.Location = new System.Drawing.Point(315, 98);
            this.lblUserPhoneNumber.Name = "lblUserPhoneNumber";
            this.lblUserPhoneNumber.Size = new System.Drawing.Size(100, 16);
            this.lblUserPhoneNumber.TabIndex = 17;
            this.lblUserPhoneNumber.Text = "Phone Number:";
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserEdit.BackColor = System.Drawing.Color.LightSalmon;
            this.btnUserEdit.Location = new System.Drawing.Point(1199, 71);
            this.btnUserEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(94, 23);
            this.btnUserEdit.TabIndex = 16;
            this.btnUserEdit.Text = "Edit";
            this.btnUserEdit.UseVisualStyleBackColor = false;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click_1);
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUserCancel.Location = new System.Drawing.Point(1199, 149);
            this.btnUserCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(94, 23);
            this.btnUserCancel.TabIndex = 15;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = false;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click_1);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserDelete.BackColor = System.Drawing.Color.Red;
            this.btnUserDelete.Location = new System.Drawing.Point(1199, 113);
            this.btnUserDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(94, 23);
            this.btnUserDelete.TabIndex = 14;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click_1);
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserCreate.BackColor = System.Drawing.Color.Lime;
            this.btnUserCreate.Location = new System.Drawing.Point(1199, 39);
            this.btnUserCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.Size = new System.Drawing.Size(94, 23);
            this.btnUserCreate.TabIndex = 13;
            this.btnUserCreate.Text = "Create";
            this.btnUserCreate.UseVisualStyleBackColor = false;
            this.btnUserCreate.Click += new System.EventHandler(this.btnUserCreate_Click_1);
            // 
            // txtUserAddress2
            // 
            this.txtUserAddress2.Location = new System.Drawing.Point(458, 147);
            this.txtUserAddress2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserAddress2.Name = "txtUserAddress2";
            this.txtUserAddress2.Size = new System.Drawing.Size(266, 22);
            this.txtUserAddress2.TabIndex = 12;
            // 
            // txtUserAddress1
            // 
            this.txtUserAddress1.Location = new System.Drawing.Point(458, 121);
            this.txtUserAddress1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserAddress1.Name = "txtUserAddress1";
            this.txtUserAddress1.Size = new System.Drawing.Size(266, 22);
            this.txtUserAddress1.TabIndex = 11;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(904, 66);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(266, 22);
            this.txtUserEmail.TabIndex = 10;
            // 
            // txtUserNIC
            // 
            this.txtUserNIC.Location = new System.Drawing.Point(458, 69);
            this.txtUserNIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserNIC.Name = "txtUserNIC";
            this.txtUserNIC.Size = new System.Drawing.Size(266, 22);
            this.txtUserNIC.TabIndex = 9;
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.Location = new System.Drawing.Point(904, 40);
            this.txtUserLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(266, 22);
            this.txtUserLastName.TabIndex = 8;
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.Location = new System.Drawing.Point(458, 43);
            this.txtUserFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(266, 22);
            this.txtUserFirstName.TabIndex = 7;
            // 
            // lblUserAddress2
            // 
            this.lblUserAddress2.AutoSize = true;
            this.lblUserAddress2.Location = new System.Drawing.Point(315, 149);
            this.lblUserAddress2.Name = "lblUserAddress2";
            this.lblUserAddress2.Size = new System.Drawing.Size(71, 16);
            this.lblUserAddress2.TabIndex = 6;
            this.lblUserAddress2.Text = "Address 2:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(761, 42);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 16);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(761, 69);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(44, 16);
            this.lblUserEmail.TabIndex = 4;
            this.lblUserEmail.Text = "Email:";
            // 
            // lblUserAddress1
            // 
            this.lblUserAddress1.AutoSize = true;
            this.lblUserAddress1.Location = new System.Drawing.Point(315, 124);
            this.lblUserAddress1.Name = "lblUserAddress1";
            this.lblUserAddress1.Size = new System.Drawing.Size(71, 16);
            this.lblUserAddress1.TabIndex = 3;
            this.lblUserAddress1.Text = "Address 1:";
            // 
            // lblUserNIC
            // 
            this.lblUserNIC.AutoSize = true;
            this.lblUserNIC.Location = new System.Drawing.Point(315, 71);
            this.lblUserNIC.Name = "lblUserNIC";
            this.lblUserNIC.Size = new System.Drawing.Size(32, 16);
            this.lblUserNIC.TabIndex = 2;
            this.lblUserNIC.Text = "NIC:";
            // 
            // lblUserFirstName
            // 
            this.lblUserFirstName.AutoSize = true;
            this.lblUserFirstName.Location = new System.Drawing.Point(315, 45);
            this.lblUserFirstName.Name = "lblUserFirstName";
            this.lblUserFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblUserFirstName.TabIndex = 1;
            this.lblUserFirstName.Text = "First Name:";
            // 
            // pctrUserProfile
            // 
            this.pctrUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("pctrUserProfile.Image")));
            this.pctrUserProfile.Location = new System.Drawing.Point(38, 28);
            this.pctrUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctrUserProfile.Name = "pctrUserProfile";
            this.pctrUserProfile.Size = new System.Drawing.Size(243, 158);
            this.pctrUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrUserProfile.TabIndex = 0;
            this.pctrUserProfile.TabStop = false;
            // 
            // mFUserBindingSource
            // 
            this.mFUserBindingSource.DataMember = "MFUser";
            // 
            // grdUser
            // 
            this.grdUser.AllowUserToOrderColumns = true;
            this.grdUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grdUser.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grdUser.Location = new System.Drawing.Point(0, 281);
            this.grdUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdUser.Name = "grdUser";
            this.grdUser.RowHeadersWidth = 51;
            this.grdUser.RowTemplate.Height = 29;
            this.grdUser.Size = new System.Drawing.Size(1347, 215);
            this.grdUser.TabIndex = 1;
            this.grdUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.AutoSize = true;
            this.lblUserSearch.Location = new System.Drawing.Point(17, 258);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(53, 16);
            this.lblUserSearch.TabIndex = 2;
            this.lblUserSearch.Text = "Search:";
            // 
            // txtUserSearchBox
            // 
            this.txtUserSearchBox.Location = new System.Drawing.Point(76, 255);
            this.txtUserSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserSearchBox.Name = "txtUserSearchBox";
            this.txtUserSearchBox.Size = new System.Drawing.Size(912, 22);
            this.txtUserSearchBox.TabIndex = 21;
            this.txtUserSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserSearchBox_KeyPress);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1343, 570);
            this.Controls.Add(this.txtUserSearchBox);
            this.Controls.Add(this.lblUserSearch);
            this.Controls.Add(this.grdUser);
            this.Controls.Add(this.PnlUserTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUser";
            this.Text = "User Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUser_Load_1);
            this.PnlUserTop.ResumeLayout(false);
            this.PnlUserTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PnlUserTop;
        private Label lblUserFirstName;
        private PictureBox pctrUserProfile;
        private Label lblUserEmail;
        private Label lblUserAddress1;
        private Label lblUserNIC;
        private Label lblLastName;
        private TextBox txtUserEmail;
        private TextBox txtUserNIC;
        private TextBox txtUserLastName;
        private TextBox txtUserFirstName;
        private Label lblUserAddress2;
        private TextBox txtUserAddress1;
        private TextBox txtUserAddress2;
        private DataGridView grdUser;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnUserEdit;
        private Button btnUserCancel;
        private Button btnUserDelete;
        private Button btnUserCreate;
        private BindingSource mFUserBindingSource;
        private TextBox txtUserPhoneNumber;
        private Label lblUserPhoneNumber;
        private Button btnUserBrowse;
        private Label lblUserSearch;
        private TextBox txtUserSearchBox;
        private TextBox txtUserConfPassword;
        private TextBox txtUserPassword;
        private Label lblUserConfPW;
        private Label lblUserPW;
        private TextBox txtUserGender;
        private Label lblUserGender;
    }
}