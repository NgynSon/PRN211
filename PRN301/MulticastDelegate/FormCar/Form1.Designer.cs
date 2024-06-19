namespace FormCar
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
            delete = new Button();
            SpeedUp = new Button();
            name = new Label();
            brand = new Label();
            speed = new Label();
            listView1 = new ListView();
            add = new Button();
            txtName = new TextBox();
            txtBrand = new TextBox();
            txtSpeed = new TextBox();
            listAll = new ListBox();
            SuspendLayout();
            // 
            // delete
            // 
            delete.Location = new Point(324, 195);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 1;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // SpeedUp
            // 
            SpeedUp.Location = new Point(324, 263);
            SpeedUp.Name = "SpeedUp";
            SpeedUp.Size = new Size(75, 23);
            SpeedUp.TabIndex = 2;
            SpeedUp.Text = "SpeedUp";
            SpeedUp.UseVisualStyleBackColor = true;
            SpeedUp.Click += SpeedUp_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(81, 135);
            name.Name = "name";
            name.Size = new Size(39, 15);
            name.TabIndex = 7;
            name.Text = "Name";
            name.Click += name_Click;
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Location = new Point(81, 199);
            brand.Name = "brand";
            brand.Size = new Size(38, 15);
            brand.TabIndex = 8;
            brand.Text = "Brand";
            brand.Click += label3_Click;
            // 
            // speed
            // 
            speed.AutoSize = true;
            speed.Location = new Point(81, 263);
            speed.Name = "speed";
            speed.Size = new Size(39, 15);
            speed.TabIndex = 9;
            speed.Text = "Speed";
            speed.Click += speed_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(62, 73);
            listView1.Name = "listView1";
            listView1.Size = new Size(236, 276);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // add
            // 
            add.Location = new Point(324, 127);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 14;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 128);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 15;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(142, 196);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(100, 23);
            txtBrand.TabIndex = 16;
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(142, 263);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(100, 23);
            txtSpeed.TabIndex = 17;
            // 
            // listAll
            // 
            listAll.FormattingEnabled = true;
            listAll.ItemHeight = 15;
            listAll.Location = new Point(446, 73);
            listAll.Name = "listAll";
            listAll.Size = new Size(207, 274);
            listAll.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listAll);
            Controls.Add(txtSpeed);
            Controls.Add(txtBrand);
            Controls.Add(txtName);
            Controls.Add(add);
            Controls.Add(speed);
            Controls.Add(brand);
            Controls.Add(name);
            Controls.Add(SpeedUp);
            Controls.Add(delete);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button delete;
        private Button SpeedUp;
        private Label name;
        private Label brand;
        private Label speed;
        private ListView listView1;
        private Button add;
        private TextBox txtName;
        private TextBox txtBrand;
        private TextBox txtSpeed;
        private ListBox listAll;
    }
}