using MyStore.Models;

namespace MyStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loaddata_Click(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            MyStoreContext context = new MyStoreContext();

            var ct = context.Categories.Select(x => new
            {
                CatID = x.CategoryId,
                CatName = x.CategoryName
            });
            dataGridView1.DataSource = ct.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n >= 0)
            {
                textBox.Text = dataGridView1[1, n].Value.ToString();
                numberic.Value = (int)dataGridView1[0, n].Value;
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            int id = (int) numberic.Value;
            MyStoreContext con = new MyStoreContext();
            var x = con.Categories.Find(id);
            if (x == null)
            {
                string name = textBox.Text;
                Category cat = new Category()
                {
                    //CategoryId = id,
                    CategoryName = name,
                };
                con.Categories.Add(cat);
                con.SaveChanges();
                LoadData();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = (int)numberic.Value;
            MyStoreContext con = new MyStoreContext();
            var x = con.Categories.SingleOrDefault(c => c.CategoryId == id);
            if (x != null)
            {
                con.Categories.Remove(x);
                con.SaveChanges();
                LoadData();
            }
        }
    }
}