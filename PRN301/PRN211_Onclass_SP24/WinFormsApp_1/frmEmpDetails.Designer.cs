namespace WinFormsApp_1
{
    partial class frmEmpDetails
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
            txtEmpID = new TextBox();
            txtEmpName = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            textBox4 = new TextBox();
            btn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(210, 92);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(212, 23);
            txtEmpID.TabIndex = 0;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(210, 144);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(212, 23);
            txtEmpName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(210, 204);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(212, 23);
            txtPhone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 92);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 144);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 204);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "PHONE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 263);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "GENDER";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(234, 263);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(334, 263);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 312);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 9;
            label5.Text = "DEGREE";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(210, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 23);
            textBox4.TabIndex = 10;
            // 
            // btn
            // 
            btn.Location = new Point(210, 382);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 11;
            btn.Text = "Save";
            btn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(347, 382);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmEmpDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(button2);
            Controls.Add(btn);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpID);
            Name = "frmEmpDetails";
            Text = "frmEmpDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmpID;
        private TextBox txtEmpName;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private TextBox textBox4;
        private Button btn;
        private Button button2;
    }
}
