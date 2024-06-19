namespace Q2
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
            dgvListEmployee = new DataGridView();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvListEmployee
            // 
            dgvListEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListEmployee.Location = new Point(38, 96);
            dgvListEmployee.Name = "dgvListEmployee";
            dgvListEmployee.RowTemplate.Height = 25;
            dgvListEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListEmployee.Size = new Size(720, 238);
            dgvListEmployee.TabIndex = 0;
            // 
            // btnView
            // 
            btnView.Location = new Point(630, 363);
            btnView.Name = "btnView";
            btnView.Size = new Size(93, 23);
            btnView.TabIndex = 1;
            btnView.Text = "View Details";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnView);
            Controls.Add(dgvListEmployee);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "15_NguyenXuanSon_LoadEmployee";
            ((System.ComponentModel.ISupportInitialize)dgvListEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListEmployee;
        private Button btnView;
    }
}
