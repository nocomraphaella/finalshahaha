namespace Finalshahaha
{
    partial class Addbooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addbooks));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            btnBack = new Button();
            label6 = new Label();
            panel6 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            cbStatus = new ComboBox();
            dateTP3 = new DateTimePicker();
            txtAuthor = new TextBox();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel7 = new Panel();
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 112);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(56, 225);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Book Title";
            textBox1.Size = new Size(201, 36);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(dateTP3);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 646);
            panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(43, 39);
            btnBack.TabIndex = 48;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(60, 46);
            label6.Name = "label6";
            label6.Size = new Size(190, 39);
            label6.TabIndex = 19;
            label6.Text = "ADD BOOKS";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.Location = new Point(56, 499);
            panel6.Name = "panel6";
            panel6.Size = new Size(201, 4);
            panel6.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(56, 426);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 4);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(56, 343);
            panel5.Name = "panel5";
            panel5.Size = new Size(201, 4);
            panel5.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(56, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 4);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(56, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 4);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 440);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 13;
            label4.Text = "AVAILABLE:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(52, 364);
            label8.Name = "label8";
            label8.Size = new Size(169, 28);
            label8.TabIndex = 12;
            label8.Text = "DATE UPLOADED:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 281);
            label7.Name = "label7";
            label7.Size = new Size(94, 28);
            label7.TabIndex = 11;
            label7.Text = "AUTHOR:";
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Yes ", "No" });
            cbStatus.Location = new Point(56, 471);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(201, 31);
            cbStatus.TabIndex = 10;
            // 
            // dateTP3
            // 
            dateTP3.CustomFormat = "yyyy-MM-dd";
            dateTP3.Font = new Font("Sitka Small", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTP3.Format = DateTimePickerFormat.Custom;
            dateTP3.Location = new Point(56, 397);
            dateTP3.Name = "dateTP3";
            dateTP3.Size = new Size(201, 29);
            dateTP3.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthor.Location = new Point(56, 312);
            txtAuthor.Multiline = true;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Author";
            txtAuthor.Size = new Size(201, 35);
            txtAuthor.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(56, 143);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.Size = new Size(201, 37);
            txtID.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 194);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 3;
            label3.Text = "BOOK TITLE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 247);
            label2.Name = "label2";
            label2.Size = new Size(0, 35);
            label2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(348, 500);
            button1.Name = "button1";
            button1.Size = new Size(129, 54);
            button1.TabIndex = 3;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RosyBrown;
            btnUpdate.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(483, 500);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 54);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.RosyBrown;
            btnClear.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(766, 500);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(153, 54);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(361, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 394);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RosyBrown;
            btnSearch.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(752, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(154, 35);
            btnSearch.TabIndex = 46;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(357, 28);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(380, 35);
            txtSearch.TabIndex = 45;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(357, 59);
            panel7.Name = "panel7";
            panel7.Size = new Size(380, 4);
            panel7.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.RosyBrown;
            btnDelete.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(627, 501);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 54);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Addbooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(950, 582);
            Controls.Add(btnDelete);
            Controls.Add(panel7);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Addbooks";
            Text = "Addbooks";
            Load += Addbooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox txtAuthor;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTP3;
        private ComboBox cbStatus;
        private Label label8;
        private Label label7;
        private Label label4;
        private Panel panel2;
        private Panel panel6;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Button button1;
        private Button btnUpdate;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel7;
        private Button btnDelete;
        private Label label6;
        private Button btnBack;
    }
}