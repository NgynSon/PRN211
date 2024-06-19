using Q1.Data;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (Spring24B1Context context = new Spring24B1Context())
            {
                IsProject.DataSource = context.Skills.ToList();
                IsProject.DisplayMember = "SkillName";
                IsProject.ValueMember = "SkillId";
                cboDepartment.DataSource = context.Departments.ToList();
                cboDepartment.DisplayMember = "DepartmentName";
                cboDepartment.ValueMember = "DepartmentId";
                List<string> positions = new List<string> {
                    "HR Manager", "HR Specialist", "IT Support Engineer", "IT Support Specialist" };
                cboPosition.DataSource = positions;
            }
        }

        private Employee getEmployee()
        {
            Employee employee = new Employee();
            try
            {
                string name = txtName.Text;
                if (name.Length >= 3 && txtName != null)
                {
                    employee.Name = name;
                }
                else
                {
                    MessageBox.Show("Employee's name must be more than 3 characters and not null","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                }
                DateTime dob = dtpDateOfBirth.Value;
                if (DateTime.Now.Year - dob.Year < 18)
                {
                    throw new Exception("Employees must be more than 18 years old");
                }
                else
                {
                    employee.Dob = dob;
                }
                if (cboDepartment.SelectedItem != null)
                {
                    employee.DepartmentId = ((Department)cboDepartment.SelectedItem).DepartmentId;
                }

                DateTime hireDate = dtpHireDate.Value;
                if (hireDate > DateTime.Now)
                {
                    throw new Exception("Hire date cannot be set in the future");
                }
                else
                {
                    employee.HireDate = hireDate;
                }

                if (cboPosition.SelectedItem != null)
                {
                    employee.Position = cboPosition.SelectedItem.ToString();
                }
                else
                {
                    throw new Exception("Please select a position");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return employee;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = getEmployee();
                DialogResult result = MessageBox.Show("Are you sure you want to add this employee?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (Spring24B1Context context = new Spring24B1Context())
                    {
                        context.Employees.Add(emp);

                        if (IsProject.SelectedItems.Count > 0)
                        {
                            foreach (var item in IsProject.SelectedItems)
                            {
                                emp.EmployeeSkills.Add(new EmployeeSkill { SkillId = ((Skill)item).SkillId, EmployeeId = emp.EmployeeId });
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
