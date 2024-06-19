namespace SaleWinApp
{
    partial class frmMembers
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
            dataGridView1 = new DataGridView();
            lblMem = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtCom = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            btnCountry = new Label();
            txtCountry = new TextBox();
            btnUpdate = new Button();
            btnExit = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 161);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(648, 166);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += frmMembers_Load;
            // 
            // lblMem
            // 
            lblMem.AutoSize = true;
            lblMem.Location = new Point(69, 28);
            lblMem.Name = "lblMem";
            lblMem.Size = new Size(62, 15);
            lblMem.TabIndex = 1;
            lblMem.Text = "MemberId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 57);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(362, 57);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 57);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 5;
            label3.Text = "CompannyName";
            // 
            // txtCom
            // 
            txtCom.Location = new Point(137, 54);
            txtCom.Margin = new Padding(3, 2, 3, 2);
            txtCom.Name = "txtCom";
            txtCom.Size = new Size(160, 23);
            txtCom.TabIndex = 6;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(103, 105);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 7;
            lblCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(137, 102);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(160, 23);
            txtCity.TabIndex = 8;
            // 
            // btnCountry
            // 
            btnCountry.AutoSize = true;
            btnCountry.Location = new Point(306, 105);
            btnCountry.Name = "btnCountry";
            btnCountry.Size = new Size(50, 15);
            btnCountry.TabIndex = 9;
            btnCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(362, 105);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(178, 23);
            txtCountry.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(591, 58);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(591, 106);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(137, 20);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(160, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(numericUpDown1);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtCountry);
            Controls.Add(btnCountry);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(txtCom);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(lblMem);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMembers";
            Text = "frmMembers";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private Label lblMem;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtCom;
        private Label lblCity;
        private TextBox txtCity;
        private Label btnCountry;
        private TextBox txtCountry;
        private Button btnUpdate;
        private Button btnExit;

        #endregion

        private NumericUpDown numericUpDown1;
    }
}