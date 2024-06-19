namespace MyStore
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
            loaddata = new Button();
            insert = new Button();
            numberic = new NumericUpDown();
            textBox = new TextBox();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberic).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(280, 315);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // loaddata
            // 
            loaddata.Location = new Point(608, 80);
            loaddata.Name = "loaddata";
            loaddata.Size = new Size(75, 23);
            loaddata.TabIndex = 1;
            loaddata.Text = "Load Data";
            loaddata.UseVisualStyleBackColor = true;
            loaddata.Click += loaddata_Click;
            // 
            // insert
            // 
            insert.Location = new Point(608, 156);
            insert.Name = "insert";
            insert.Size = new Size(75, 23);
            insert.TabIndex = 2;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // numberic
            // 
            numberic.Location = new Point(360, 80);
            numberic.Name = "numberic";
            numberic.Size = new Size(120, 23);
            numberic.TabIndex = 3;
            // 
            // textBox
            // 
            textBox.Location = new Point(360, 156);
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = 4;
            // 
            // delete
            // 
            delete.Location = new Point(608, 231);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 5;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(textBox);
            Controls.Add(numberic);
            Controls.Add(insert);
            Controls.Add(loaddata);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button loaddata;
        private Button insert;
        private NumericUpDown numberic;
        private TextBox textBox;
        private Button delete;
    }
}