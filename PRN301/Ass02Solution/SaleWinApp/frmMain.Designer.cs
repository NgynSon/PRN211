namespace SaleWinApp
{
    partial class frmMain
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
            btnMem = new Button();
            btnProduct = new Button();
            btnOrder = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMem
            // 
            btnMem.BackColor = SystemColors.ActiveCaption;
            btnMem.Location = new Point(124, 65);
            btnMem.Margin = new Padding(3, 2, 3, 2);
            btnMem.Name = "btnMem";
            btnMem.Size = new Size(82, 22);
            btnMem.TabIndex = 0;
            btnMem.Text = "Member";
            btnMem.UseVisualStyleBackColor = false;
            btnMem.Click += btnMem_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.GradientActiveCaption;
            btnProduct.Location = new Point(124, 91);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(82, 22);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.GradientInactiveCaption;
            btnOrder.Location = new Point(124, 117);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(82, 22);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(93, 33);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 3;
            label1.Text = "Choose one of part";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 195);
            Controls.Add(label1);
            Controls.Add(btnOrder);
            Controls.Add(btnProduct);
            Controls.Add(btnMem);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnMem;
        private Button btnProduct;
        private Button btnOrder;
        private Label label1;
        #endregion
    }
}