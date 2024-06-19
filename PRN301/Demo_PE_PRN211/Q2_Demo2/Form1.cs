using Microsoft.EntityFrameworkCore;
using Q1_Demo2.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Q2_Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();


        }

        public void LoadData()
        {
            using (var context = new PE_Fall21B5Context())
            {
                var employ = context.Employees.Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Sex,
                    e.Dob,
                    e.Position
                });
                var po = context.Employees.Select(e => e.Position).Distinct();
                comboBox1.DataSource = po.ToList();
                dataGridView1.DataSource = employ.ToList();
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = name_Input.Text;
            string sex = radio_male.Checked ? "Male" : "Female";
            DateTime dob = dateTimePicker1.Value;
            string? po = comboBox1.SelectedItem.ToString();

            Employee emp = new Employee()
            {
                Name = name,
                Sex = sex,
                Dob = dob,
                Position = po

            };

            using (var context = new PE_Fall21B5Context())
            {
                context.Employees.Add(emp);
                context.SaveChanges();
            }

            name_Input.Text = "";
            radio_male.Checked = false;
            radio_female.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells[0].Value);
                Employee? employee = new Employee();
                using (var con = new PE_Fall21B5Context())
                {
                    employee = con.Employees.FirstOrDefault(x => x.Id == id);
                    id_Input.Text = employee.Id.ToString();
                    name_Input.Text = employee.Name;
                    if (employee.Sex.ToUpper().Equals("MALE"))
                    {
                        radio_male.Checked = true;
                    }
                    else
                    {
                        radio_female.Checked = true;
                    }
                    comboBox1.Text = employee.Position;
                    dateTimePicker1.Value = employee.Dob;
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_Input.Text);
            string name = name_Input.Text;
            string sex = radio_male.Checked ? "Male" : "Female";
            DateTime dob = dateTimePicker1.Value;
            string? po = comboBox1.SelectedItem.ToString();
            Employee? employee = new Employee();
            using (var con = new PE_Fall21B5Context())
            {
                employee = con.Employees.FirstOrDefault(x => x.Id == id);
                if (employee != null)
                {

                    employee.Name = name;
                    employee.Sex = sex;
                    employee.Dob = dob;
                    employee.Position = po;
                    con.SaveChanges();



                    LoadData();
                }
                else
                {


                }


            }


        }
    }
}