using BusinessObject.Models;
using DataAccess.Repository;
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
    public partial class frmProducts : Form
    {
        private readonly FStoreContext _context = new FStoreContext();
        IProductRepository productRepository = new ProductRepository();
        public frmProducts()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUnit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadData()
        {
            var ListProduct = _context.Products.ToList();
            dataGridView1.DataSource = ListProduct;
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                txtPid.Text = selectedRow.Cells[0].Value.ToString();
                txtBoxCat.Text = selectedRow.Cells[1].Value.ToString();
                txtPname.Text = selectedRow.Cells[2].Value.ToString();
                txtWei.Text = selectedRow.Cells[3].Value.ToString();
                txtUnit.Text = selectedRow.Cells[4].Value.ToString();
                txtStock.Text = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                var products = _context.Products.Where(p => p.ProductName.Contains(keyword)).ToList();
                if (products.Count > 0)
                {
                    dataGridView1.DataSource = products;
                }
                else
                {
                    MessageBox.Show("Nothing! Search again By ProductName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LoadData();
            }

        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatId_Click(object sender, EventArgs e)
        {

        }
        private Product GetProductObject()
        {
            Product pro = null;
            try
            {
                pro = new Product
                {
                    ProductId = int.Parse(txtPid.Text),
                    ProductName = txtPname.Text,
                    CategoryId = int.Parse(txtBoxCat.Text),
                    Weight = txtWei.Text,
                    UnitPrice = (decimal)float.Parse(txtUnit.Text),
                    UnitsInStock = int.Parse(txtStock.Text)

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return pro;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var pro = GetProductObject();
                productRepository.DeleteProduct(pro.ProductId);
                MessageBox.Show("Delete successfull");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }
    }
}
