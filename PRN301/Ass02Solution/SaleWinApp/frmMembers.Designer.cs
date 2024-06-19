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
            numericUpDown1 = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(741, 221);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += frmMembers_Load;
            // 
            // lblMem
            // 
            lblMem.AutoSize = true;
            lblMem.Location = new Point(79, 37);
            lblMem.Name = "lblMem";
            lblMem.Size = new Size(78, 20);
            lblMem.TabIndex = 1;
            lblMem.Text = "MemberId";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(157, 35);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(32, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 76);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(414, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 76);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 5;
            label3.Text = "CompannyName";
            // 
            // txtCom
            // 
            txtCom.Location = new Point(157, 72);
            txtCom.Name = "txtCom";
            txtCom.Size = new Size(182, 27);
            txtCom.TabIndex = 6;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(118, 140);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 20);
            lblCity.TabIndex = 7;
            lblCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(157, 136);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(182, 27);
            txtCity.TabIndex = 8;
            // 
            // btnCountry
            // 
            btnCountry.AutoSize = true;
            btnCountry.Location = new Point(350, 140);
            btnCountry.Name = "btnCountry";
            btnCountry.Size = new Size(60, 20);
            btnCountry.TabIndex = 9;
            btnCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(414, 140);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(203, 27);
            txtCountry.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(675, 77);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(675, 141);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
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
            Controls.Add(numericUpDown1);
            Controls.Add(lblMem);
            Controls.Add(dataGridView1);
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
        private NumericUpDown numericUpDown1;
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
    }
}