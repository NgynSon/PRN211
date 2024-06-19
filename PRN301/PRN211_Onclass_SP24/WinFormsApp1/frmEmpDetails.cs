namespace WinFormsApp1
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
            String FullInfor = "";
            String degree = cmbDegree.SelectedItem.ToString();
            // check not null
            if (!(empid.Length > 0 && empName.Length > 0 && empphone.Length > 0))
            {
                MessageBox.Show("ID and Name and phone not null", "Error mess", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                FullInfor = "ID :" + empid + Environment.NewLine +
                            "Name :" + empName + Environment.NewLine +
                            "Degree:" + degree;
                MessageBox.Show(FullInfor, "Save Infor");
            }

        }
    }
}

