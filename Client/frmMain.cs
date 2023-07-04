using Code4.Paragon.POS.Client.Admin;
using Code4.Paragon.POS.Client.Master;
using Code4.Paragon.POS.Client.Transaction;
using System;
using System.Windows.Forms;

namespace Code4.Paragon.POS
{
    public partial class frmMain : Form
    {
        frmLogin frmLogin = new frmLogin();
        frmSKU frmSKUObj = new frmSKU();
        frmBill frmBillObj = new frmBill();
        frmUser frmUserObj = new frmUser();
        public frmMain()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            frmBillObj.TopLevel = false;
            pnlMain.Controls.Add(frmBillObj);
            frmBillObj.Show();
        }

        private void Onclosed(object sender, FormClosedEventArgs e)
        {

            this.Hide();
            frmLogin.Show();
        }

        private void nevigateToProductManagement(object sender, EventArgs e)
        {
            //frmSKU frmSKU = new frmSKU();
            //this.Hide();
            //frmSKU.Show();
        }

        private void btnSKUManagement_Click(object sender, EventArgs e)
        {
            frmUserObj.Hide();
            frmBillObj.Hide();
            frmSKUObj.TopLevel = false;
            pnlMain.Controls.Add(frmSKUObj);
            frmSKUObj.Show();
        }

        private void btnBillManagement_Click(object sender, EventArgs e)
        {
            frmSKUObj.Hide();
            frmUserObj.Hide();
            frmBillObj.TopLevel = false;
            pnlMain.Controls.Add(frmBillObj);
            frmBillObj.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmSKUObj.Hide();
            frmBillObj.Hide();
            frmUserObj.TopLevel = false;
            pnlMain.Controls.Add(frmUserObj);
            frmUserObj.Show();

        }

    
    }
}