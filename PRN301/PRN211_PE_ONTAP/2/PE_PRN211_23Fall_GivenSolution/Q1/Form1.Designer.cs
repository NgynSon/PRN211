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
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            label5 = new Label();
            dtpEndDate = new DateTimePicker();
            label4 = new Label();
            dtpStartDate = new DateTimePicker();
            cboTimeSlot = new ComboBox();
            vdsvd = new Label();
            cboMovies = new ComboBox();
            label3 = new Label();
            dgvSchedules = new DataGridView();
            label2 = new Label();
            cboRooms = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(cboTimeSlot);
            groupBox1.Controls.Add(vdsvd);
            groupBox1.Controls.Add(cboMovies);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(759, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 373);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add schedule";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(121, 285);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add schedule";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 197);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "End Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(121, 191);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(148, 23);
            dtpEndDate.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 144);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(119, 138);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(148, 23);
            dtpStartDate.TabIndex = 8;
            // 
            // cboTimeSlot
            // 
            cboTimeSlot.FormattingEnabled = true;
            cboTimeSlot.Location = new Point(121, 84);
            cboTimeSlot.Name = "cboTimeSlot";
            cboTimeSlot.Size = new Size(227, 23);
            cboTimeSlot.TabIndex = 7;
            // 
            // vdsvd
            // 
            vdsvd.AutoSize = true;
            vdsvd.Location = new Point(20, 87);
            vdsvd.Name = "vdsvd";
            vdsvd.Size = new Size(53, 15);
            vdsvd.TabIndex = 6;
            vdsvd.Text = "TimeSlot";
            // 
            // cboMovies
            // 
            cboMovies.FormattingEnabled = true;
            cboMovies.Location = new Point(121, 33);
            cboMovies.Name = "cboMovies";
            cboMovies.Size = new Size(121, 23);
            cboMovies.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 33);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 1;
            label3.Text = "Movie";
            // 
            // dgvSchedules
            // 
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Location = new Point(20, 82);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowTemplate.Height = 25;
            dgvSchedules.Size = new Size(712, 351);
            dgvSchedules.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-148, 53);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 7;
            label2.Text = "Schedules of selected room";
            // 
            // cboRooms
            // 
            cboRooms.FormattingEnabled = true;
            cboRooms.Location = new Point(123, 28);
            cboRooms.Name = "cboRooms";
            cboRooms.Size = new Size(121, 23);
            cboRooms.TabIndex = 11;
            cboRooms.TextChanged += cboRooms_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 10;
            label1.Text = "List Of rooms";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 462);
            Controls.Add(cboRooms);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgvSchedules);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private Label label5;
        private DateTimePicker dtpEndDate;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private ComboBox cboTimeSlot;
        private Label vdsvd;
        private ComboBox cboMovies;
        private Label label3;
        private DataGridView dgvSchedules;
        private Label label2;
        private ComboBox cboRooms;
        private Label label1;
    }
}