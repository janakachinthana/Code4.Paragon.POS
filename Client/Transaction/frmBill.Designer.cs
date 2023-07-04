using System.Drawing;
using System.Windows.Forms;

namespace Code4.Paragon.POS.Client.Transaction
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            lblMainProduct = new Label();
            cmbMainProductList = new ComboBox();
            lblMainQty = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMainProduct
            // 
            lblMainProduct.AutoSize = true;
            lblMainProduct.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMainProduct.Location = new Point(3, 0);
            lblMainProduct.Name = "lblMainProduct";
            lblMainProduct.Size = new Size(161, 31);
            lblMainProduct.TabIndex = 0;
            lblMainProduct.Text = "Select Product";
            // 
            // cmbMainProductList
            // 
            cmbMainProductList.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMainProductList.FormattingEnabled = true;
            cmbMainProductList.Items.AddRange(new object[] { "Egg Rice", "Chicken Rice", "Fish Rice", "Egg Kottu", "vegitable Kottu " });
            cmbMainProductList.Location = new Point(239, 3);
            cmbMainProductList.Name = "cmbMainProductList";
            cmbMainProductList.Size = new Size(207, 39);
            cmbMainProductList.TabIndex = 2;
            // 
            // lblMainQty
            // 
            lblMainQty.AutoSize = true;
            lblMainQty.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMainQty.Location = new Point(3, 45);
            lblMainQty.Name = "lblMainQty";
            lblMainQty.Size = new Size(109, 31);
            lblMainQty.TabIndex = 4;
            lblMainQty.Text = "Enter Qty";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(239, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 38);
            textBox1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.CausesValidation = false;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblMainProduct, 0, 0);
            tableLayoutPanel1.Controls.Add(lblMainQty, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbMainProductList, 1, 0);
            tableLayoutPanel1.Location = new Point(195, 156);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(472, 88);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1325, 684);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBill";
            StartPosition = FormStartPosition.Manual;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblMainProduct;
        private ComboBox cmbMainProductList;
        private Label lblMainQty;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}