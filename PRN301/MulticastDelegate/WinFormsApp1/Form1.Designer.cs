namespace WinFormsApp1
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
            txtSpeed = new TextBox();
            txtBrand = new TextBox();
            txtName = new TextBox();
            speed = new Label();
            brand = new Label();
            name = new Label();
            listView1 = new ListView();
            listAll = new ListBox();
            add = new Button();
            SpeedUp = new Button();
            delete = new Button();
            listSpeed = new ListBox();
            SuspendLayout();
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(92, 257);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(100, 23);
            txtSpeed.TabIndex = 24;
            txtSpeed.TextChanged += txtSpeed_TextChanged;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(92, 190);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(100, 23);
            txtBrand.TabIndex = 23;
            txtBrand.TextChanged += txtBrand_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(92, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 22;
            // 
            // speed
            // 
            speed.AutoSize = true;
            speed.Location = new Point(25, 263);
            speed.Name = "speed";
            speed.Size = new Size(39, 15);
            speed.TabIndex = 20;
            speed.Text = "Speed";
            speed.Click += speed_Click;
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Location = new Point(26, 193);
            brand.Name = "brand";
            brand.Size = new Size(38, 15);
            brand.TabIndex = 19;
            brand.Text = "Brand";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(25, 127);
            name.Name = "name";
            name.Size = new Size(39, 15);
            name.TabIndex = 18;
            name.Text = "Name";
            name.Click += name_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 58);
            listView1.Name = "listView1";
            listView1.Size = new Size(198, 276);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listAll
            // 
            listAll.FormattingEnabled = true;
            listAll.ItemHeight = 15;
            listAll.Location = new Point(340, 60);
            listAll.Name = "listAll";
            listAll.Size = new Size(152, 274);
            listAll.TabIndex = 28;
            // 
            // add
            // 
            add.Location = new Point(238, 119);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 27;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // SpeedUp
            // 
            SpeedUp.Location = new Point(238, 255);
            SpeedUp.Name = "SpeedUp";
            SpeedUp.Size = new Size(75, 23);
            SpeedUp.TabIndex = 26;
            SpeedUp.Text = "SpeedUp";
            SpeedUp.UseVisualStyleBackColor = true;
            SpeedUp.Click += SpeedUp_Click;
            // 
            // delete
            // 
            delete.Location = new Point(238, 187);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 25;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // listSpeed
            // 
            listSpeed.FormattingEnabled = true;
            listSpeed.ItemHeight = 15;
            listSpeed.Location = new Point(537, 58);
            listSpeed.Name = "listSpeed";
            listSpeed.Size = new Size(152, 274);
            listSpeed.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listSpeed);
            Controls.Add(listAll);
            Controls.Add(add);
            Controls.Add(SpeedUp);
            Controls.Add(delete);
            Controls.Add(txtSpeed);
            Controls.Add(txtBrand);
            Controls.Add(txtName);
            Controls.Add(speed);
            Controls.Add(brand);
            Controls.Add(name);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSpeed;
        private TextBox txtBrand;
        private TextBox txtName;
        private Label speed;
        private Label brand;
        private Label name;
        private ListView listView1;
        private ListBox listAll;
        private Button add;
        private Button SpeedUp;
        private Button delete;
        private ListBox listSpeed;
    }
}