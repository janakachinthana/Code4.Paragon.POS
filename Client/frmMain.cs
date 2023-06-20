using Code4.Paragon.POS.Client.Admin;
using Code4.Paragon.POS.Client.Master;
using Code4.Paragon.POS.Client.Transaction;
using System.Windows.Forms;

namespace Code4.Paragon.POS
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Onclosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
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
            frmSKU frmSKUObj = new frmSKU();
            frmSKUObj.TopLevel = false;
            tabPage1.Controls.Add(frmSKUObj);
            tabPage1.Text = frmSKUObj.Text;
            tabControl1.Controls.Add(tabPage1);
            frmSKUObj.BringToFront();
            frmSKUObj.Show();
        }

        private void btnBillManagement_Click(object sender, EventArgs e)
        {
            frmBill frmBillObj = new frmBill();
            frmBillObj.TopLevel = false;
            tabPage1.Controls.Add(frmBillObj);
            tabPage1.Text = frmBillObj.Text;
            tabControl1.Controls.Add(tabPage1);
            //frmBillObj.BringToFront();
            frmBillObj.Show();
        }

    }
}