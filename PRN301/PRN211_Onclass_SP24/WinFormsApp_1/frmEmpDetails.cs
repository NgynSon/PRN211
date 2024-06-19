using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_1
{
    public partial class frmEmpDetails : Form
    {
        public frmEmpDetails()
        {
            InitializeComponent();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // kiem tra tinh logic bat phai nhap - validate
            String empid = txtEmpID.Text;
            string empName = txtEmpName.Text;
            string empphone = txtPhone.Text;
            // check not null
            if (!(empid.Length > 0 && empName.Length > 0 && empphone.Length > 0))
            {
                MessageBox.Show("ID and Name and phone not null", "Error mess", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
    }
}