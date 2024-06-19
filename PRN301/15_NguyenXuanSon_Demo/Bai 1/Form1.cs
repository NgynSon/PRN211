namespace Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {

                txtName.Text = "Hello Freetuts.net !!!";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên của bạn là: " + txtName.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
