namespace Code4.Paragon.POS.Client.Admin
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            okButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.BackColor = SystemColors.Highlight;
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            okButton.ForeColor = SystemColors.ActiveCaptionText;
            okButton.Location = new Point(534, 164);
            okButton.Margin = new Padding(4, 5, 4, 5);
            okButton.Name = "okButton";
            okButton.Size = new Size(100, 48);
            okButton.TabIndex = 24;
            okButton.Text = "Login";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 56);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 26;
            label1.Text = "User Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 109);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 27;
            label2.Text = "Password : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(370, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(370, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 29;
            // 
            // frmLogin
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(650, 231);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Padding = new Padding(12, 14, 12, 14);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
