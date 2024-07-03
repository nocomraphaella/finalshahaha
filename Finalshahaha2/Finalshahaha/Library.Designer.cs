namespace Finalshahaha
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            btnBrowse = new Button();
            btnUser = new Button();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.DarkGoldenrod;
            btnBrowse.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = SystemColors.ControlLightLight;
            btnBrowse.Location = new Point(139, 147);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(231, 185);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "ADMIN";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.DarkGoldenrod;
            btnUser.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = SystemColors.ControlLightLight;
            btnUser.Location = new Point(428, 147);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(231, 185);
            btnUser.TabIndex = 3;
            btnUser.Text = "USER";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(807, 512);
            Controls.Add(btnUser);
            Controls.Add(btnBrowse);
            Name = "Library";
            Text = "Form1";
            Load += Library_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBrowse;
        private Button btnUser;
    }
}
