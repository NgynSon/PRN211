namespace LoadDB_ADO_sample
{
    partial class Form1
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
            dvgDisplay = new DataGridView();
            add = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgDisplay).BeginInit();
            SuspendLayout();
            // 
            // dvgDisplay
            // 
            dvgDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDisplay.Location = new Point(12, 12);
            dvgDisplay.Name = "dvgDisplay";
            dvgDisplay.RowTemplate.Height = 25;
            dvgDisplay.Size = new Size(362, 245);
            dvgDisplay.TabIndex = 0;
            dvgDisplay.CellContentClick += dvgDisplay_CellContentClick;
            // 
            // add
            // 
            add.Location = new Point(570, 346);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 1;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 470);
            Controls.Add(add);
            Controls.Add(dvgDisplay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion



        private DataGridView dvgDisplay;
        private Button add;

    }
}