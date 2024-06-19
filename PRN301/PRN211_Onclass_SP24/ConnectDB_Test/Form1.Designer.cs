namespace ConnectDB_Test
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
            dgvData = new DataGridView();
            btnViewProducts = new Button();
            btnViewCatergories = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(58, 104);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(687, 261);
            dgvData.TabIndex = 0;
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(107, 43);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(107, 23);
            btnViewProducts.TabIndex = 1;
            btnViewProducts.Text = "ViewProducts";
            btnViewProducts.UseVisualStyleBackColor = true;
            // 
            // btnViewCatergories
            // 
            btnViewCatergories.Location = new Point(583, 43);
            btnViewCatergories.Name = "btnViewCatergories";
            btnViewCatergories.Size = new Size(107, 23);
            btnViewCatergories.TabIndex = 2;
            btnViewCatergories.Text = "ViewCatergories";
            btnViewCatergories.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(372, 393);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnViewCatergories);
            Controls.Add(btnViewProducts);
            Controls.Add(dgvData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private Button btnViewProducts;
        private Button btnViewCatergories;
        private Button btnClose;
    }
}
