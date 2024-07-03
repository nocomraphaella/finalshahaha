namespace Finalshahaha
{
    partial class Userlibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userlibrary));
            menuStrip1 = new MenuStrip();
            menuAddBooks = new ToolStripMenuItem();
            menuIssuedbooks = new ToolStripMenuItem();
            menuReturn = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuAddBooks, menuIssuedbooks, menuReturn, menuExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(870, 58);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuAddBooks
            // 
            menuAddBooks.BackColor = Color.RosyBrown;
            menuAddBooks.BackgroundImageLayout = ImageLayout.Stretch;
            menuAddBooks.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuAddBooks.Image = (Image)resources.GetObject("menuAddBooks.Image");
            menuAddBooks.ImageScaling = ToolStripItemImageScaling.None;
            menuAddBooks.Name = "menuAddBooks";
            menuAddBooks.Size = new Size(204, 54);
            menuAddBooks.Text = "ADD BOOKS";
            menuAddBooks.Click += menuAddBooks_Click;
            // 
            // menuIssuedbooks
            // 
            menuIssuedbooks.BackColor = Color.Thistle;
            menuIssuedbooks.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuIssuedbooks.Image = (Image)resources.GetObject("menuIssuedbooks.Image");
            menuIssuedbooks.ImageScaling = ToolStripItemImageScaling.None;
            menuIssuedbooks.Name = "menuIssuedbooks";
            menuIssuedbooks.Size = new Size(241, 54);
            menuIssuedbooks.Text = "ISSUED BOOKS";
            menuIssuedbooks.Click += menuIssuedbooks_Click;
            // 
            // menuReturn
            // 
            menuReturn.BackColor = Color.DarkSeaGreen;
            menuReturn.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuReturn.Image = (Image)resources.GetObject("menuReturn.Image");
            menuReturn.ImageScaling = ToolStripItemImageScaling.None;
            menuReturn.Name = "menuReturn";
            menuReturn.Size = new Size(284, 54);
            menuReturn.Text = "RETURNED BOOKS";
            menuReturn.Click += menuReturn_Click;
            // 
            // menuExit
            // 
            menuExit.BackColor = Color.Tan;
            menuExit.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuExit.Image = (Image)resources.GetObject("menuExit.Image");
            menuExit.ImageScaling = ToolStripItemImageScaling.None;
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(130, 54);
            menuExit.Text = "EXIT";
            menuExit.Click += menuExit_Click;
            // 
            // Userlibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 489);
            Controls.Add(menuStrip1);
            Name = "Userlibrary";
            Text = "Userlibrary";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuAddBooks;
        private ToolStripMenuItem menuIssuedbooks;
        private ToolStripMenuItem menuReturn;
        private ToolStripMenuItem menuExit;
    }
}