namespace Q2_Demo2
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btn_Edit = new Button();
            btn_Add = new Button();
            btn_Refresh = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            name_Input = new TextBox();
            id_Input = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(690, 485);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Edit);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(btn_Refresh);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(radio_female);
            groupBox1.Controls.Add(radio_male);
            groupBox1.Controls.Add(name_Input);
            groupBox1.Controls.Add(id_Input);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(735, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 405);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Current Employee";
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(268, 339);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(75, 36);
            btn_Edit.TabIndex = 13;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(152, 339);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 36);
            btn_Add.TabIndex = 12;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(35, 339);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(75, 36);
            btn_Refresh.TabIndex = 11;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 271);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 23);
            comboBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(133, 228);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Location = new Point(239, 192);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(63, 19);
            radio_female.TabIndex = 8;
            radio_female.TabStop = true;
            radio_female.Text = "Female";
            radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Location = new Point(133, 192);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(51, 19);
            radio_male.TabIndex = 7;
            radio_male.TabStop = true;
            radio_male.Text = "Male";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // name_Input
            // 
            name_Input.Location = new Point(133, 139);
            name_Input.Name = "name_Input";
            name_Input.Size = new Size(200, 23);
            name_Input.TabIndex = 6;
            // 
            // id_Input
            // 
            id_Input.Location = new Point(133, 101);
            id_Input.Name = "id_Input";
            id_Input.ReadOnly = true;
            id_Input.Size = new Size(130, 23);
            id_Input.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 271);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 228);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 192);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 2;
            label3.Text = "Sex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 139);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 101);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 632);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btn_Edit;
        private Button btn_Add;
        private Button btn_Refresh;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private TextBox name_Input;
        private TextBox id_Input;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}