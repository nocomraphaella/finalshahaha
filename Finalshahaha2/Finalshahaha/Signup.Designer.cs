namespace Finalshahaha
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            chbShow = new CheckBox();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            txtPassword = new TextBox();
            panel3 = new Panel();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            btnSignUp = new Button();
            pictureBox4 = new PictureBox();
            txtName = new TextBox();
            panel5 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 55);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(315, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(66, 61);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(117, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 122);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // chbShow
            // 
            chbShow.AutoSize = true;
            chbShow.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbShow.ForeColor = Color.Black;
            chbShow.Location = new Point(47, 412);
            chbShow.Name = "chbShow";
            chbShow.Size = new Size(155, 27);
            chbShow.TabIndex = 24;
            chbShow.Text = "Show Password";
            chbShow.UseVisualStyleBackColor = true;
            chbShow.CheckedChanged += chbShow_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(44, 358);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 40);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(100, 392);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 5);
            panel4.TabIndex = 21;
            panel4.Paint += panel4_Paint;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.DarkSeaGreen;
            txtPassword.Font = new Font("Sitka Small", 13F);
            txtPassword.ForeColor = SystemColors.MenuText;
            txtPassword.Location = new Point(100, 358);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(234, 39);
            txtPassword.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(100, 328);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 5);
            panel3.TabIndex = 20;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.DarkSeaGreen;
            txtUsername.Font = new Font("Sitka Small", 13F);
            txtUsername.ForeColor = SystemColors.MenuText;
            txtUsername.Location = new Point(100, 294);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(234, 39);
            txtUsername.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(44, 294);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 40);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkSeaGreen;
            btnSignUp.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ActiveCaptionText;
            btnSignUp.Location = new Point(44, 453);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(290, 47);
            btnSignUp.TabIndex = 26;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(44, 228);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 40);
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.DarkSeaGreen;
            txtName.Font = new Font("Sitka Small", 13F);
            txtName.ForeColor = SystemColors.MenuText;
            txtName.Location = new Point(100, 228);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(234, 39);
            txtName.TabIndex = 27;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(100, 263);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 5);
            panel5.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 31);
            label1.TabIndex = 44;
            label1.Text = "ADMIN";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 571);
            Controls.Add(panel5);
            Controls.Add(pictureBox4);
            Controls.Add(txtName);
            Controls.Add(btnSignUp);
            Controls.Add(pictureBox2);
            Controls.Add(chbShow);
            Controls.Add(pictureBox3);
            Controls.Add(panel4);
            Controls.Add(txtPassword);
            Controls.Add(panel3);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Signup";
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private CheckBox chbShow;
        private PictureBox pictureBox3;
        private Panel panel4;
        private TextBox txtPassword;
        private Panel panel3;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private Button btnSignUp;
        private PictureBox pictureBox4;
        private TextBox txtName;
        private Panel panel5;
        private Label label1;
    }
}