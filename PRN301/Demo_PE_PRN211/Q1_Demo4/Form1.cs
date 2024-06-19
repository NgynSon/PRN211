namespace Q1_Demo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TextBox> list = new List<TextBox>();

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int count = (int)nu_Int.Value;
            for (int i = 1; i <= count; i++)
            {
                Label lm = new Label();
                lm.Text = "Text of button" + i.ToString() + ":";
                TextBox tb = new TextBox();
                tb.Width = 200;

                /*tb.Location = new Point(tb.Location.X + 20, tb.Location.Y + 90);*/

                flowLayoutPanel1.Controls.Add(lm);
                flowLayoutPanel1.Controls.Add(tb);

                button1.Visible = true;

                list.Add(tb);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (TextBox tb in list)
            {
                Button btn = new Button();
                btn.Text = tb.Text;
                btn.Click += btn_Click;
                flowLayoutPanel2.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bạn đã chọn: " + ((Button)sender).Text);

        }



    }
}