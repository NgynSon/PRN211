namespace Q1
{
    partial class Form1
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
            label1 = new Label();
            txtName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cboDepartment = new ComboBox();
            btnAdd = new Button();
            IsProject = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboPosition = new ComboBox();
            dtpHireDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 48);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "EmployeeName";
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(177, 91);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 23);
            dtpDateOfBirth.TabIndex = 2;
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(177, 162);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(200, 23);
            cboDepartment.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 370);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(191, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add new employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // IsProject
            // 
            IsProject.FormattingEnabled = true;
            IsProject.ItemHeight = 15;
            IsProject.Location = new Point(442, 91);
            IsProject.Name = "IsProject";
            IsProject.Size = new Size(272, 244);
            IsProject.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 99);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 170);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 7;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 235);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 307);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 9;
            label5.Text = "HireDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 53);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Skills";
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(177, 232);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(200, 23);
            cboPosition.TabIndex = 11;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(177, 299);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(200, 23);
            dtpHireDate.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpHireDate);
            Controls.Add(cboPosition);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(IsProject);
            Controls.Add(btnAdd);
            Controls.Add(cboDepartment);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "15_NguyenXuanSon_Q1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cboDepartment;
        private Button btnAdd;
        private ListBox IsProject;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboPosition;
        private DateTimePicker dtpHireDate;
    }
}
