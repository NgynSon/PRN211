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
            cbRooms = new ComboBox();
            dgSchedule = new DataGridView();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtEndDate = new DateTimePicker();
            cbTimeSlot = new ComboBox();
            cbMovie = new ComboBox();
            dtStartDate = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgSchedule).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 15);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "List Of Rooms";
            // 
            // cbRooms
            // 
            cbRooms.FormattingEnabled = true;
            cbRooms.Location = new Point(134, 12);
            cbRooms.Name = "cbRooms";
            cbRooms.Size = new Size(226, 28);
            cbRooms.TabIndex = 1;
            cbRooms.SelectedIndexChanged += cbRooms_SelectedIndexChanged;
            // 
            // dgSchedule
            // 
            dgSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSchedule.Location = new Point(30, 85);
            dgSchedule.Name = "dgSchedule";
            dgSchedule.RowHeadersWidth = 51;
            dgSchedule.RowTemplate.Height = 29;
            dgSchedule.Size = new Size(687, 353);
            dgSchedule.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtEndDate);
            groupBox1.Controls.Add(cbTimeSlot);
            groupBox1.Controls.Add(cbMovie);
            groupBox1.Controls.Add(dtStartDate);
            groupBox1.Location = new Point(734, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 353);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(109, 278);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 45);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add a schedule";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 212);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 9;
            label5.Text = "EndDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "StartDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 7;
            label3.Text = "TimeSlot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Movie";
            // 
            // dtEndDate
            // 
            dtEndDate.Format = DateTimePickerFormat.Custom;
            dtEndDate.Location = new Point(84, 207);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(226, 27);
            dtEndDate.TabIndex = 6;
            // 
            // cbTimeSlot
            // 
            cbTimeSlot.FormattingEnabled = true;
            cbTimeSlot.Location = new Point(84, 92);
            cbTimeSlot.Name = "cbTimeSlot";
            cbTimeSlot.Size = new Size(226, 28);
            cbTimeSlot.TabIndex = 5;
            // 
            // cbMovie
            // 
            cbMovie.FormattingEnabled = true;
            cbMovie.Location = new Point(84, 40);
            cbMovie.Name = "cbMovie";
            cbMovie.Size = new Size(226, 28);
            cbMovie.TabIndex = 4;
            // 
            // dtStartDate
            // 
            dtStartDate.Format = DateTimePickerFormat.Custom;
            dtStartDate.Location = new Point(84, 151);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(226, 27);
            dtStartDate.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 62);
            label6.Name = "label6";
            label6.Size = new Size(189, 20);
            label6.TabIndex = 4;
            label6.Text = "Schedule of selected room:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 450);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dgSchedule);
            Controls.Add(cbRooms);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgSchedule).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbRooms;
        private DataGridView dgSchedule;
        private GroupBox groupBox1;
        private Button btnAdd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtEndDate;
        private ComboBox cbTimeSlot;
        private ComboBox cbMovie;
        private DateTimePicker dtStartDate;
        private Label label6;
    }
}