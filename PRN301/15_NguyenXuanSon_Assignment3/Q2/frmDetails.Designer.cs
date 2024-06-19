namespace Q2
{
    partial class frmDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvListDetails = new DataGridView();
            textSearch = new TextBox();
            label1 = new Label();
            button1 = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvListDetails
            // 
            dgvListDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListDetails.Location = new Point(40, 73);
            dgvListDetails.Name = "dgvListDetails";
            dgvListDetails.RowTemplate.Height = 25;
            dgvListDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListDetails.Size = new Size(725, 263);
            dgvListDetails.TabIndex = 0;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(255, 32);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(217, 23);
            textSearch.TabIndex = 1;
            textSearch.TextChanged += textSeacrh_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 2;
            label1.Text = "Seacrh Department";
            // 
            // button1
            // 
            button1.Location = new Point(12, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(608, 394);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textSearch);
            Controls.Add(dgvListDetails);
            Name = "frmDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "15_NguyenXuanSon_LoadDetails";
            ((System.ComponentModel.ISupportInitialize)dgvListDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListDetails;
        private TextBox textSearch;
        private Label label1;
        private Button button1;
        private Button btnDelete;
    }
}