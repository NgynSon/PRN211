using System.Windows.Forms;

namespace SaleWinApp
{
    partial class frmProducts
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
            dataGridView1 = new DataGridView();
            lblPid = new Label();
            txtPid = new TextBox();
            txtPname = new TextBox();
            lblPname = new Label();
            label1 = new Label();
            txtWei = new TextBox();
            txtBoxCat = new TextBox();
            txtCatId = new Label();
            lblUnit = new Label();
            txtUnit = new TextBox();
            txtStock = new TextBox();
            lblUnitStock = new Label();
            lblSearch = new Label();
            txtBoxSearch = new TextBox();
            btnSearch = new Button();
            btnClose = new Button();
            delePro = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 192);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(714, 228);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // lblPid
            // 
            lblPid.AutoSize = true;
            lblPid.Location = new Point(65, 29);
            lblPid.Name = "lblPid";
            lblPid.Size = new Size(59, 15);
            lblPid.TabIndex = 1;
            lblPid.Text = "ProductId";
            // 
            // txtPid
            // 
            txtPid.Location = new Point(130, 26);
            txtPid.Margin = new Padding(3, 2, 3, 2);
            txtPid.Name = "txtPid";
            txtPid.Size = new Size(110, 23);
            txtPid.TabIndex = 2;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(130, 66);
            txtPname.Margin = new Padding(3, 2, 3, 2);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(110, 23);
            txtPname.TabIndex = 3;
            // 
            // lblPname
            // 
            lblPname.AutoSize = true;
            lblPname.Location = new Point(42, 68);
            lblPname.Name = "lblPname";
            lblPname.Size = new Size(82, 15);
            lblPname.TabIndex = 4;
            lblPname.Text = "Product name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 111);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Weight";
            // 
            // txtWei
            // 
            txtWei.Location = new Point(130, 106);
            txtWei.Margin = new Padding(3, 2, 3, 2);
            txtWei.Name = "txtWei";
            txtWei.Size = new Size(110, 23);
            txtWei.TabIndex = 6;
            // 
            // txtBoxCat
            // 
            txtBoxCat.Location = new Point(556, 29);
            txtBoxCat.Margin = new Padding(3, 2, 3, 2);
            txtBoxCat.Name = "txtBoxCat";
            txtBoxCat.Size = new Size(110, 23);
            txtBoxCat.TabIndex = 7;
            // 
            // txtCatId
            // 
            txtCatId.AutoSize = true;
            txtCatId.Location = new Point(485, 32);
            txtCatId.Name = "txtCatId";
            txtCatId.Size = new Size(65, 15);
            txtCatId.TabIndex = 8;
            txtCatId.Text = "CategoryId";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(495, 63);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(55, 15);
            lblUnit.TabIndex = 9;
            lblUnit.Text = "UnitPrice";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(556, 60);
            txtUnit.Margin = new Padding(3, 2, 3, 2);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(110, 23);
            txtUnit.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(556, 103);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(110, 23);
            txtStock.TabIndex = 11;
            // 
            // lblUnitStock
            // 
            lblUnitStock.AutoSize = true;
            lblUnitStock.Location = new Point(492, 106);
            lblUnitStock.Name = "lblUnitStock";
            lblUnitStock.Size = new Size(58, 15);
            lblUnitStock.TabIndex = 12;
            lblUnitStock.Text = "UnitStock";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(42, 154);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(111, 150);
            txtBoxSearch.Margin = new Padding(3, 2, 3, 2);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(379, 23);
            txtBoxSearch.TabIndex = 14;
            txtBoxSearch.TextChanged += textBox2_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(498, 150);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(674, 150);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // delePro
            // 
            delePro.Location = new Point(586, 150);
            delePro.Margin = new Padding(3, 2, 3, 2);
            delePro.Name = "delePro";
            delePro.Size = new Size(82, 22);
            delePro.TabIndex = 17;
            delePro.Text = "Delete";
            delePro.UseVisualStyleBackColor = true;
            delePro.Click += delePro_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 445);
            Controls.Add(delePro);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(txtBoxSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblUnitStock);
            Controls.Add(txtStock);
            Controls.Add(txtUnit);
            Controls.Add(lblUnit);
            Controls.Add(txtCatId);
            Controls.Add(txtBoxCat);
            Controls.Add(txtWei);
            Controls.Add(label1);
            Controls.Add(lblPname);
            Controls.Add(txtPname);
            Controls.Add(txtPid);
            Controls.Add(lblPid);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private Label lblPid;
        private TextBox txtPid;
        private TextBox txtPname;
        private Label lblPname;
        private Label label1;
        private TextBox txtWei;
        private TextBox txtBoxCat;
        private Label txtCatId;
        private Label lblUnit;
        private TextBox txtUnit;
        private TextBox txtStock;
        private Label lblUnitStock;
        private Label lblSearch;
        private TextBox txtBoxSearch;
        private Button btnSearch;
        private Button btnClose;
        #endregion

        private Button delePro;
    }
}