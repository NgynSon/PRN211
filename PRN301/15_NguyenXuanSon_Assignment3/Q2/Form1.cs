using System;
using System.Linq;
using System.Windows.Forms;
using Q1.Data;

namespace Q2
{
    public partial class Form1 : Form
    {
        private Spring24B1Context context;

        public Form1()
        {
            InitializeComponent();
            context = new Spring24B1Context();
            LoadEmployee();
        }

        public void LoadEmployee(string searchDepartment = "")
        {
            // Retrieve employees with their associated skills filtered by department
            var query = context.Employees
                .Where(e => e.Department != null && e.Department.DepartmentName.Contains(searchDepartment))
                .Select(e => new
                {
                    EmployeeId = e.EmployeeId,
                    Name = e.Name,
                    Dob = e.Dob,
                    Department = e.DepartmentId,
                    Position = e.Position,
                    HireDate = e.HireDate
                })
                .ToList();

            dgvListEmployee.DataSource = query;

            dgvListEmployee.Columns["EmployeeId"].HeaderText = "Employee ID";
            dgvListEmployee.Columns["Name"].HeaderText = "Name";
            dgvListEmployee.Columns["Dob"].HeaderText = "Date of Birth";
            dgvListEmployee.Columns["Department"].HeaderText = "Department";
            dgvListEmployee.Columns["Position"].HeaderText = "Position";
            dgvListEmployee.Columns["HireDate"].HeaderText = "Hire Date";
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            frmDetails frmDetails = new frmDetails();
            frmDetails.ShowDialog();
            this.Hide();
        }

        private void textSeacrh_TextChanged(object sender, EventArgs e)
        {
        }

        /*private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListEmployee.SelectedRows.Count > 0)
            {
                int selectedEmployeeId = Convert.ToInt32(dgvListEmployee.SelectedRows[0].Cells["EmployeeId"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var employeeToDelete = context.Employees.FirstOrDefault(e => e.EmployeeId == selectedEmployeeId);

                        if (employeeToDelete != null)
                        {
                            context.Employees.Remove(employeeToDelete);
                            context.SaveChanges(); 

                            
                            LoadEmployee(); 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/
    }
}
