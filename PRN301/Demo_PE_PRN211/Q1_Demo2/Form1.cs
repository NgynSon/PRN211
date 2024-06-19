using Microsoft.EntityFrameworkCore;
using Q1_Demo2.Models;
using System.Web;

namespace Q1_Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
            position.SelectedIndex = 0;
            Input_Name.TextChanged += (sender, e) => Filter();
            radioButton1.CheckedChanged += (sender, e) => Filter();
            radioButton2.CheckedChanged += (sender, e) => Filter();
            radioButton3.CheckedChanged += (sender, e) => Filter();
            position.SelectedIndexChanged += (sender, e) => Filter();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {

            using (var context = new PE_Fall21B5Context())
            {
                /*var employees = context.Employees.Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Dob = x.Dob,
                    Sex = x.Sex,
                    Position = x.Position,
                    Department = x.Department,
                    DepartmentName = context.Departments.FirstOrDefault(y => y.Id == x.Department).Name,

                }).ToList();*/
                var query = context.Employees.Include(e => e.DepartmentNavigation).Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Dob,
                    e.Sex,
                    e.Position,
                    DepartmentID = e.Department,
                    DepartmentName = e.DepartmentNavigation.Name

                }).ToList();
                dataGridView1.DataSource = query;
            }
        }

        public void Filter()
        {
            using (var context = new PE_Fall21B5Context())
            {
                var query = context.Employees.Include(De => De.DepartmentNavigation).AsQueryable();
                string nameFilter = Input_Name.Text;
                if (!string.IsNullOrEmpty(nameFilter))
                {
                    query = query.Where(e => e.Name.Contains(nameFilter));
                }

                bool isMale = radioButton2.Checked;
                bool isFemail = radioButton3.Checked;

                if (isMale || isFemail)
                {
                    query = query.Where(e => e.Sex == (isMale ? "Male" : "Female"));
                }

                string? po = position.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(po) && po != "All Position")
                {
                    query = query.Where(e => e.Position == po);
                }

                dataGridView1.DataSource = query.ToList();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            position.SelectedIndex = 0;
        }

        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string? selectedPosition = position.SelectedItem.ToString(); // Lấy vị trí đã chọn từ ComboBox


            using (var context = new PE_Fall21B5Context())
            {
                if (selectedPosition == "All Position")
                {
                    // Nếu vị trí chọn là "All Position", hiển thị tất cả nhân viên
                    var employees = context.Employees.Select(x => new
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Dob = x.Dob,
                        Sex = x.Sex,
                        Position = x.Position,
                        Department = x.Department,
                        DepartmentName = context.Departments.FirstOrDefault(y => y.Id == x.Department).Name,

                    }).ToList();
                    dataGridView1.DataSource = employees;
                }
                else
                {
                    // Lọc danh sách nhân viên theo vị trí
                    var employees = context.Employees.Where(emp => emp.Position == selectedPosition).ToList();
                    dataGridView1.DataSource = employees;
                }

*/
        }

    }
}
