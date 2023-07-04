using System.Drawing;
using System.Windows.Forms;

namespace Code4.Paragon.POS
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.BackgroundWorker backgroundWorker1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBillManagement = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSKUManagement = new System.Windows.Forms.ToolStripButton();
            this.rbnMain = new System.Windows.Forms.ToolStrip();
            this.btnUserManagement = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBillManagement
            // 
            this.btnBillManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnBillManagement.Image")));
            this.btnBillManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBillManagement.Name = "btnBillManagement";
            this.btnBillManagement.Size = new System.Drawing.Size(146, 31);
            this.btnBillManagement.Text = "Bill Management";
            this.btnBillManagement.Click += new System.EventHandler(this.btnBillManagement_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnSKUManagement
            // 
            this.btnSKUManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSKUManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnSKUManagement.Image")));
            this.btnSKUManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSKUManagement.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.btnSKUManagement.Name = "btnSKUManagement";
            this.btnSKUManagement.Size = new System.Drawing.Size(176, 31);
            this.btnSKUManagement.Text = "Product Management";
            this.btnSKUManagement.Click += new System.EventHandler(this.btnSKUManagement_Click);
            // 
            // rbnMain
            // 
            this.rbnMain.AutoSize = false;
            this.rbnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rbnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBillManagement,
            this.toolStripSeparator1,
            this.btnSKUManagement,
            this.btnUserManagement});
            this.rbnMain.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.Name = "rbnMain";
            this.rbnMain.Size = new System.Drawing.Size(800, 34);
            this.rbnMain.TabIndex = 0;
            this.rbnMain.Text = "toolStrip1";
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnUserManagement.Image")));
            this.btnUserManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(154, 31);
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 34);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 326);
            this.pnlMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.rbnMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Paragon POS System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.rbnMain.ResumeLayout(false);
            this.rbnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStripButton btnBillManagement;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnSKUManagement;
        private ToolStrip rbnMain;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSplitButton toolStripSplitButton1;
        private Panel pnlMain;
        private ToolStripButton btnUserManagement;
    }
}