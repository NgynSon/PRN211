namespace Q1
{
    partial class frmRoomManger
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
            cboRooms = new ComboBox();
            dgvListView = new DataGridView();
            groupBox1 = new GroupBox();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            cboTimeSlot = new ComboBox();
            cboMovie = new ComboBox();
            btnAddSchedule = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "List of rooms";
            // 
            // cboRooms
            // 
            cboRooms.FormattingEnabled = true;
            cboRooms.Location = new Point(124, 25);
            cboRooms.Name = "cboRooms";
            cboRooms.Size = new Size(121, 23);
            cboRooms.TabIndex = 1;
            cboRooms.TextChanged += cboRooms_TextChanged;
            // 
            // dgvListView
            // 
            dgvListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListView.Location = new Point(31, 104);
            dgvListView.Name = "dgvListView";
            dgvListView.RowTemplate.Height = 25;
            dgvListView.Size = new Size(534, 308);
            dgvListView.TabIndex = 2;
            dgvListView.CellClick += dgvListView_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(cboTimeSlot);
            groupBox1.Controls.Add(cboMovie);
            groupBox1.Controls.Add(btnAddSchedule);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(593, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 332);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add schedule";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(76, 174);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(78, 130);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(198, 23);
            dtpStartDate.TabIndex = 7;
            // 
            // cboTimeSlot
            // 
            cboTimeSlot.FormattingEnabled = true;
            cboTimeSlot.Location = new Point(81, 81);
            cboTimeSlot.Name = "cboTimeSlot";
            cboTimeSlot.Size = new Size(195, 23);
            cboTimeSlot.TabIndex = 6;
            // 
            // cboMovie
            // 
            cboMovie.FormattingEnabled = true;
            cboMovie.Location = new Point(81, 36);
            cboMovie.Name = "cboMovie";
            cboMovie.Size = new Size(121, 23);
            cboMovie.TabIndex = 5;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Location = new Point(108, 270);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(103, 23);
            btnAddSchedule.TabIndex = 4;
            btnAddSchedule.Text = "Add schedule";
            btnAddSchedule.UseVisualStyleBackColor = true;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 182);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 3;
            label5.Text = "EndDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 138);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 2;
            label4.Text = "StartDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 89);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 1;
            label3.Text = "TimeSlot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 44);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Movie";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 71);
            label6.Name = "label6";
            label6.Size = new Size(152, 15);
            label6.TabIndex = 4;
            label6.Text = "Schedules of selected room";
            // 
            // frmRoomManger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 449);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dgvListView);
            Controls.Add(cboRooms);
            Controls.Add(label1);
            Name = "frmRoomManger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "15_NguyenXuanSon_RoomManger";
            ((System.ComponentModel.ISupportInitialize)dgvListView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboRooms;
        private DataGridView dgvListView;
        private GroupBox groupBox1;
        private ComboBox cboTimeSlot;
        private ComboBox cboMovie;
        private Button btnAddSchedule;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label6;
    }
}
