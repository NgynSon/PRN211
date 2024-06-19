namespace Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtSo1.Text) + Convert.ToDouble(txtSo2.Text);
            txtKetqua.Text = result.ToString();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtSo1.Text) - Convert.ToDouble(txtSo2.Text);
            txtKetqua.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtSo1.Text) * Convert.ToDouble(txtSo2.Text);
            txtKetqua.Text = result.ToString();
        }

        private void btnDevi_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtSo1.Text) / Convert.ToDouble(txtSo2.Text);
            txtKetqua.Text = result.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetqua.Clear();

        }
    }
}
