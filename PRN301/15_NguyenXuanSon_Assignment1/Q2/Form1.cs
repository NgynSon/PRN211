using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            loadEmployee();
        }

        private void loadEmployee()
        {
            using (var context = new PE_Fall21B5Context())
            {
                List<Employee> employees = context.Employees
                    .Select(x => new Employee
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Sex = x.Sex,
                        Dob = x.Dob,
                        Position = x.Position
                    })
                    .ToList();

                cboPosition.Items.Clear();

                foreach (var employee in employees)
                {
                    if (!string.IsNullOrWhiteSpace(employee.Position) &&
                        !cboPosition.Items.Contains(employee.Position))
                    {
                        cboPosition.Items.Add(employee.Position);
                    }
                }
                dataGridView1.DataSource = employees;
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var name = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            var dob = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            var sex = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            var position = dataGridView1.Rows[e.RowIndex].Cells[4].Value;

            txtID.Text = id.ToString();
            txtName.Text = name.ToString();
            dtp_Date.Value = DateTime.Parse(dob.ToString());

            if (sex.ToString() == "Female")
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;

            }
            cboPosition.Text = position.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadEmployee();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var dob = dtp_Date.Value;
            var sex = rdMale.Checked ? "Male" : "Female";
            var position = cboPosition.Text;
            using var context = new PE_Fall21B5Context();
            context.Employees.Add(new Employee
            {
                Name = name,
                Position = position,
                Dob = dob,
                Sex = sex,
            });
            context.SaveChanges();
            MessageBox.Show("Add new Employee successfully", "Success");
            loadEmployee(); 
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var context = new PE_Fall21B5Context();
            var id = txtID.Text;
            var name = txtName.Text;
            var dob = dtp_Date.Value;
            var sex = rdMale.Checked ? "Male" : "Female";
            var position = cboPosition.Text;
            Employee emp = new Employee
            {
                Id = int.Parse(id),
                Name = name,
                Position = position,
                Dob = dob,
                Sex = sex,
            };
            context.Employees.Update(emp);
            context.SaveChanges();
            MessageBox.Show("Edit a Employee successfully", "Success");
            loadEmployee();
        }
    }
}
