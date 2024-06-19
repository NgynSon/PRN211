namespace Q1_Demo3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            title_input = new TextBox();
            des_input = new TextBox();
            comment_input = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            btn_Add = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 47);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 88);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "Des";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 171);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Room Square";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 214);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Floor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 250);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Comment";
            // 
            // title_input
            // 
            title_input.Location = new Point(182, 47);
            title_input.Name = "title_input";
            title_input.Size = new Size(178, 23);
            title_input.TabIndex = 5;
            // 
            // des_input
            // 
            des_input.Location = new Point(182, 85);
            des_input.Multiline = true;
            des_input.Name = "des_input";
            des_input.Size = new Size(178, 67);
            des_input.TabIndex = 6;
            // 
            // comment_input
            // 
            comment_input.Location = new Point(182, 247);
            comment_input.Multiline = true;
            comment_input.Name = "comment_input";
            comment_input.Size = new Size(178, 88);
            comment_input.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(182, 212);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "133", "138", "154", "164", "180" });
            comboBox1.Location = new Point(182, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 10;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(50, 385);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(310, 23);
            btn_Add.TabIndex = 11;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(401, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(558, 397);
            dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 464);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Add);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(comment_input);
            Controls.Add(des_input);
            Controls.Add(title_input);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox title_input;
        private TextBox des_input;
        private TextBox comment_input;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Button btn_Add;
        private DataGridView dataGridView1;
    }
}