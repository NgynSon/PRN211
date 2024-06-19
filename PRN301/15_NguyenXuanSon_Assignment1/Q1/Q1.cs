using Q1.Models;
using System.Data;
using System.Xml.Linq;
namespace Q1
{
    public partial class Q1 : Form
    {
        public DBContext db;
        public Q1()
        {
            db = new DBContext();
            InitializeComponent();
            
            cbPosition.Items.Add("All positions");
            cbPosition.Items.Add("Developer");
            cbPosition.Items.Add("Tester");
            cbPosition.Items.Add("Leader");
            cbPosition.Items.Add("Manager");
            cbPosition.SelectedIndex = 0;
        }

        private void LoadData()
        {



            if (db != null)
            {
                var query = db.Employees.AsQueryable();


                if (!string.IsNullOrEmpty(txtName.Text))
                    query = query.Where(e => e.Name.Contains(txtName.Text));


                string selectedPosition = cbPosition.SelectedItem.ToString();
                if (selectedPosition != "All positions")
                    query = query.Where(e => e.Position == selectedPosition);


                if (radioButton1.Checked)
                    query = query.Where(e => e.Sex != null);
                else if (radioButton2.Checked)
                    query = query.Where(e => e.Sex == "Male");
                else if (radioButton3.Checked)
                    query = query.Where(e => e.Sex == "Female");

                dgvEmployee.DataSource = query.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Dob,
                    x.Sex,
                    x.Position,
                    x.Department
                }).ToList();
            }
            else
            {
                MessageBox.Show("Database context is null.");
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        
        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
