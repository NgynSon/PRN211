namespace Bai_2
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
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            btnPlus = new Button();
            btnDecrease = new Button();
            btnMultiply = new Button();
            btnDevi = new Button();
            btnDel = new Button();
            txtKetqua = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 95);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(150, 29);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(276, 23);
            txtSo1.TabIndex = 2;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(150, 93);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(276, 23);
            txtSo2.TabIndex = 3;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(28, 164);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(57, 28);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new Point(115, 164);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(57, 28);
            btnDecrease.TabIndex = 5;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(201, 164);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(57, 28);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDevi
            // 
            btnDevi.Location = new Point(285, 164);
            btnDevi.Name = "btnDevi";
            btnDevi.Size = new Size(57, 28);
            btnDevi.TabIndex = 7;
            btnDevi.Text = "/";
            btnDevi.UseVisualStyleBackColor = true;
            btnDevi.Click += btnDevi_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(369, 164);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(57, 28);
            btnDel.TabIndex = 8;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // txtKetqua
            // 
            txtKetqua.Location = new Point(150, 221);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.Size = new Size(276, 23);
            txtKetqua.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 219);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 10;
            label3.Text = "Kết quả";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 278);
            Controls.Add(label3);
            Controls.Add(txtKetqua);
            Controls.Add(btnDel);
            Controls.Add(btnDevi);
            Controls.Add(btnMultiply);
            Controls.Add(btnDecrease);
            Controls.Add(btnPlus);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Button btnPlus;
        private Button btnDecrease;
        private Button btnMultiply;
        private Button btnDevi;
        private Button btnDel;
        private TextBox txtKetqua;
        private Label label3;
    }
}
