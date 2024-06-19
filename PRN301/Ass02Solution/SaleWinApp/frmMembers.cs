using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmMembers : Form
    {

        private readonly FStoreContext _context = new FStoreContext();
        public frmMembers()
        {
            InitializeComponent();

        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var ListMem = _context.Members.ToList();
            dataGridView1.DataSource = ListMem;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                txtEmail.Text = selectedRow.Cells[1].Value.ToString();
                txtCom.Text = selectedRow.Cells[2].Value.ToString();
                txtCity.Text = selectedRow.Cells[3].Value.ToString();
                txtCountry.Text = selectedRow.Cells[4].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            var getMemById = _context.Members.SingleOrDefault(m => m.MemberId == id);
            if (getMemById != null)
            {
                getMemById.MemberId = id;
                getMemById.Email = txtEmail.Text;
                getMemById.City = txtCity.Text;
                getMemById.CompanyName = txtCom.Text;
                getMemById.Country = txtCountry.Text;
                _context.Update(getMemById);
                _context.SaveChanges();
                MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
