namespace Finalshahaha
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            chbShow = new CheckBox();
            btnSignUp = new Button();
            btnSignIn = new Button();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            txtPassword = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chbShow
            // 
            chbShow.AutoSize = true;
            chbShow.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbShow.ForeColor = Color.Black;
            chbShow.Location = new Point(44, 358);
            chbShow.Name = "chbShow";
            chbShow.Size = new Size(155, 27);
            chbShow.TabIndex = 27;
            chbShow.Text = "Show Password";
            chbShow.UseVisualStyleBackColor = true;
            chbShow.CheckedChanged += chbShow_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkSeaGreen;
            btnSignUp.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ActiveCaptionText;
            btnSignUp.Location = new Point(44, 451);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(290, 47);
            btnSignUp.TabIndex = 26;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.CornflowerBlue;
            btnSignIn.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.ActiveCaptionText;
            btnSignIn.Location = new Point(44, 398);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(290, 47);
            btnSignIn.TabIndex = 25;
            btnSignIn.Text = "LOGIN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(44, 305);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 40);
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(100, 339);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 5);
            panel4.TabIndex = 22;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ActiveCaption;
            txtPassword.Font = new Font("Sitka Small", 13F);
            txtPassword.ForeColor = SystemColors.MenuText;
            txtPassword.Location = new Point(100, 305);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(234, 39);
            txtPassword.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(100, 275);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 5);
            panel3.TabIndex = 21;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(44, 241);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 40);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ActiveCaption;
            txtUsername.Font = new Font("Sitka Small", 13F);
            txtUsername.ForeColor = SystemColors.MenuText;
            txtUsername.Location = new Point(100, 241);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(234, 39);
            txtUsername.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(117, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 128);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 54);
            panel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 29;
            label1.Text = "USER";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(314, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(66, 61);
            panel2.TabIndex = 1;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 521);
            Controls.Add(panel1);
            Controls.Add(chbShow);
            Controls.Add(btnSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(pictureBox3);
            Controls.Add(panel4);
            Controls.Add(txtPassword);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "User";
            Text = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbShow;
        private Button btnSignUp;
        private Button btnSignIn;
        private PictureBox pictureBox3;
        private Panel panel4;
        private TextBox txtPassword;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}