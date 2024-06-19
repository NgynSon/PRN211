namespace FormCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void speed_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string inputData = txtName.Text;

            // Thêm dữ liệu vào ListBox
            listAll.Items.Add(inputData);

            // Xóa nội dung trong TextBox
            txtName.Text = string.Empty;
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void SpeedUp_Click(object sender, EventArgs e)
        {

        }

        
    }
}