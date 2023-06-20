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
            btnBillManagement = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnSKUManagement = new ToolStripButton();
            rbnMain = new ToolStrip();
            tabPage1 = new TabPage();
            tabControl1 = new TabControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            rbnMain.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBillManagement
            // 
            btnBillManagement.Image = (Image)resources.GetObject("btnBillManagement.Image");
            btnBillManagement.ImageTransparentColor = Color.Magenta;
            btnBillManagement.Name = "btnBillManagement";
            btnBillManagement.Size = new Size(146, 39);
            btnBillManagement.Text = "Bill Management";
            btnBillManagement.Click += btnBillManagement_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 42);
            // 
            // btnSKUManagement
            // 
            btnSKUManagement.BackColor = SystemColors.ActiveCaption;
            btnSKUManagement.Image = (Image)resources.GetObject("btnSKUManagement.Image");
            btnSKUManagement.ImageTransparentColor = Color.Magenta;
            btnSKUManagement.Margin = new Padding(1, 1, 0, 2);
            btnSKUManagement.Name = "btnSKUManagement";
            btnSKUManagement.Size = new Size(176, 39);
            btnSKUManagement.Text = "Product Management";
            btnSKUManagement.Click += btnSKUManagement_Click;
            // 
            // rbnMain
            // 
            rbnMain.AutoSize = false;
            rbnMain.BackColor = SystemColors.ActiveCaption;
            rbnMain.ImageScalingSize = new Size(20, 20);
            rbnMain.Items.AddRange(new ToolStripItem[] { btnBillManagement, toolStripSeparator1, btnSKUManagement });
            rbnMain.Location = new Point(0, 0);
            rbnMain.Name = "rbnMain";
            rbnMain.Size = new Size(800, 42);
            rbnMain.TabIndex = 0;
            rbnMain.Text = "toolStrip1";
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 374);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 407);
            tabControl1.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(rbnMain);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmMain";
            Text = "Paragon POS System";
            WindowState = FormWindowState.Maximized;
            FormClosed += Onclosed;
            Load += Main_Load;
            rbnMain.ResumeLayout(false);
            rbnMain.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripButton btnBillManagement;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnSKUManagement;
        private ToolStrip rbnMain;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSplitButton toolStripSplitButton1;
        private TabPage tabPage1;
        private TabControl tabControl1;
    }
}