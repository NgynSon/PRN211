using Q2_Demo1.Models;

namespace Q2_Demo1
{
    public partial class Form1 : Form
    {
        PE_PRN211_23SprB1Context _context = new PE_PRN211_23SprB1Context();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }


        public void LoadData()
        {
            var student = _context.Students.Select(x => new
            {
                Id = x.Id,
                Fullname = x.Fullname,
                Sex = x.Sex,
                Dob = x.Dob,
                Email = x.Email,
            }).ToList();
            dataGridView1.DataSource = student;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullname = fullname_input.Text;
            string sex = radioButton1.Checked ? "Male" : "Female";
            DateTime dob = dob_input.Value;
            string email = this.email.Text;
            Student newStudent = new Student()
            {
                Fullname = fullname,
                Sex = sex,
                Dob = dob,
                Email = email
            };
            _context.Students.Add(newStudent);
            _context.SaveChanges();
            id.Text = "";
            this.fullname_input.Text = "";
            this.email.Text = "";
            radioButton1.Checked = true;
            this.dob_input.Value = DateTime.Now;

            LoadData();
        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Đảm bảo người dùng nhấp vào một ô hợp lệ
            {
                // Lấy thông tin từ ô trong hàng tương ứng
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Hiển thị thông tin trong GroupBox
                id.Text = selectedRow.Cells[0].Value.ToString();
                fullname_input.Text = selectedRow.Cells[1].Value.ToString();
                radioButton1.Checked = selectedRow.Cells[2].Value.ToString().ToLower() == "male";
                radioButton2.Checked = selectedRow.Cells[2].Value.ToString().ToLower() == "female";
                dob_input.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);
                email.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            int studentId = int.Parse(id.Text);
            string fullname = fullname_input.Text;
            string sex = radioButton1.Checked ? "Male" : "Female";
            DateTime dob = dob_input.Value;
            string email = this.email.Text;



            Student? student = _context.Students.Find(studentId);

            if (student != null)
            {

                student.Fullname = fullname;
                student.Sex = sex;
                student.Dob = dob;
                student.Email = email;
                _context.SaveChanges();
                MessageBox.Show("Student information updated successfully.");


                LoadData();
            }
            else
            {

                MessageBox.Show("Student not found.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            id.Text = string.Empty;
            fullname_input.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dob_input.Value = DateTime.Now;
            email.Text = string.Empty;
            LoadData();
        }
    }
}


