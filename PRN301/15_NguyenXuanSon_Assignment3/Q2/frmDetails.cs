using Q1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class frmDetails : Form
    {
        private Spring24B1Context context;
        public frmDetails()
        {
            InitializeComponent();
            context = new Spring24B1Context();
            LoadEmployee();
        }

        public void LoadEmployee(string searchDepartment = null)
        {
            // Retrieve employees with their associated skills and filter by department if specified
            var query = context.Employees
        .Where(e => e.Department != null && e.Department.DepartmentName.Contains(searchDepartment ?? string.Empty))
        .Select(e => new
        {
            EmployeeId = e.EmployeeId,
            Name = e.Name,
            Dob = e.Dob,
            DepartmentName = e.Department != null ? e.Department.DepartmentName : "N/A",
            Position = e.Position ?? "N/A",
            HireDate = e.HireDate,
            Skills = string.Join(", ", e.EmployeeSkills.Select(es => es.Skill.SkillName)),
            Projects = string.Join(", ", e.EmployeeProjects.Select(ep => ep.Project.ProjectName))
        })
        .ToList();

            dgvListDetails.DataSource = query;

            // Configure DataGridView column headers
            dgvListDetails.Columns["EmployeeId"].HeaderText = "Employee ID";
            dgvListDetails.Columns["Name"].HeaderText = "Name";
            dgvListDetails.Columns["Dob"].HeaderText = "Date of Birth";
            dgvListDetails.Columns["DepartmentName"].HeaderText = "Department";
            dgvListDetails.Columns["Position"].HeaderText = "Position";
            dgvListDetails.Columns["HireDate"].HeaderText = "Hire Date";
            dgvListDetails.Columns["Skills"].HeaderText = "Skills";
            dgvListDetails.Columns["Projects"].HeaderText = "Projects";
        }

        private void textSeacrh_TextChanged(object sender, EventArgs e)
        {
            string departmentName = textSearch.Text.Trim(); // Get the department name from the textbox
            LoadEmployee(departmentName);
        }

       

    }
}
