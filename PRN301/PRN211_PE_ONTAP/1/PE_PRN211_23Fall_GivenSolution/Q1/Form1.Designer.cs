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
            dgvSchedule = new DataGridView();
            groupBox1 = new GroupBox();
            tbNote = new TextBox();
            cbMovies = new ComboBox();
            cbTimeSlot = new ComboBox();
            cbRoom = new ComboBox();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            btAddSchedule = new Button();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbRooms = new ComboBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "List of rooms";
            label1.Click += label1_Click;
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(12, 102);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(704, 497);
            dgvSchedule.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbNote);
            groupBox1.Controls.Add(cbMovies);
            groupBox1.Controls.Add(cbTimeSlot);
            groupBox1.Controls.Add(cbRoom);
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(btAddSchedule);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(732, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 497);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add schedule";
            // 
            // tbNote
            // 
            tbNote.Location = new Point(140, 350);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(248, 72);
            tbNote.TabIndex = 6;
            // 
            // cbMovies
            // 
            cbMovies.FormattingEnabled = true;
            cbMovies.Location = new Point(133, 111);
            cbMovies.Name = "cbMovies";
            cbMovies.Size = new Size(255, 28);
            cbMovies.TabIndex = 5;
            // 
            // cbTimeSlot
            // 
            cbTimeSlot.FormattingEnabled = true;
            cbTimeSlot.Location = new Point(133, 174);
            cbTimeSlot.Name = "cbTimeSlot";
            cbTimeSlot.Size = new Size(255, 28);
            cbTimeSlot.TabIndex = 5;
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(133, 43);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(255, 28);
            cbRoom.TabIndex = 3;
            cbRoom.SelectedIndexChanged += cbRooms_SelectedIndexChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(140, 300);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(138, 230);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // btAddSchedule
            // 
            btAddSchedule.Location = new Point(168, 446);
            btAddSchedule.Name = "btAddSchedule";
            btAddSchedule.Size = new Size(135, 45);
            btAddSchedule.TabIndex = 1;
            btAddSchedule.Text = "Add Schedule";
            btAddSchedule.UseVisualStyleBackColor = true;
            btAddSchedule.Click += btAddSchedule_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 353);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 0;
            label8.Text = "Note";
            label8.Click += label6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 307);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 0;
            label6.Text = "EndDate";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 237);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 0;
            label5.Text = "StartDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 182);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 0;
            label4.Text = "TimeSlot";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 119);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 0;
            label7.Text = "Movie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 51);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 0;
            label3.Text = "Room";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 79);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 0;
            label2.Text = "Schedule of selected room";
            label2.Click += label1_Click;
            // 
            // cbRooms
            // 
            cbRooms.FormattingEnabled = true;
            cbRooms.Location = new Point(220, 27);
            cbRooms.Name = "cbRooms";
            cbRooms.Size = new Size(255, 28);
            cbRooms.TabIndex = 3;
            cbRooms.SelectedIndexChanged += cbRooms_SelectedIndexChanged;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.Connection = null;
            sqlCommand2.Notification = null;
            sqlCommand2.Transaction = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 672);
            Controls.Add(cbRooms);
            Controls.Add(groupBox1);
            Controls.Add(dgvSchedule);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSchedule;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cbRooms;
        private Label label4;
        private Label label3;
        private Button btAddSchedule;
        private Label label6;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private ComboBox cbRoom;
        private Label label7;
        private ComboBox cbTimeSlot;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private ComboBox cbMovies;
        private TextBox tbNote;
        private Label label8;
    }
}