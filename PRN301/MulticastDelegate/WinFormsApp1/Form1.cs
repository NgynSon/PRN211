using MulticastDelegate;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string inputName = txtName.Text;
            // Lấy dữ liệu từ TextBox thứ hai
            string inputBrand = txtBrand.Text;

            // Lấy dữ liệu từ TextBox thứ ba
            string inputSpeed = txtSpeed.Text;
            // Thêm dữ liệu vào ListBox
            string combinedData = inputName + " - " + inputBrand + " - " + inputSpeed;

            // Thêm dữ liệu vào ListBox
            listAll.Items.Add(combinedData);

            // Xóa nội dung trong ba TextBox
            txtName.Text = string.Empty;
            txtBrand.Text = string.Empty;
            txtSpeed.Text = string.Empty;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn mục nào trong ListBox chưa
            if (listAll.SelectedItem != null)
            {
                // Lấy mục được chọn trong ListBox
                string selectedItem = listAll.SelectedItem.ToString();

                // Xóa mục được chọn khỏi ListBox
                listAll.Items.Remove(selectedItem);
            }
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void speed_Click(object sender, EventArgs e)
        {

        }

        private void SpeedUp_Click(object sender, EventArgs e)
        {
            
        }
    }
}