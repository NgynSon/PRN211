using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Q1_Demo3_ADO.DAO;
using System.Data;

namespace Q1_Demo3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            RoomDAO dao = new RoomDAO();
            InitializeComponent();
            var rooms = dao.executeQuery("Select * from Rooms");
            dataGridView1.DataSource = rooms;
        }

        static String getConnection()
        {
            var builder = new ConfigurationBuilder()
     .SetBasePath(Directory.GetCurrentDirectory())
     .AddJsonFile("appsettings.json", optional: false);

            IConfiguration configuration = builder.Build();
            return configuration.GetConnectionString("DBContext");
        }

        public void AddRoom(string title, int square, int floor, string des, string comment)
        {
            using (SqlConnection conn = new SqlConnection(getConnection()))
            {
                conn.Open();
                string sql = "INSERT INTO [dbo].[Rooms] VALUES (@title, @square, @floor, @des, @comment)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@square", square);
                cmd.Parameters.AddWithValue("@floor", floor);
                cmd.Parameters.AddWithValue("@des", des);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            RoomDAO dao = new RoomDAO();
            if (string.IsNullOrEmpty(title_input.Text))
            {
                MessageBox.Show("Ngu");
            }
            else
            {
                string insertQuery = "INSERT INTO [dbo].[Rooms] VALUES (@title, @square, @floor, @des, @comment)";
                SqlParameter[] insertParams = {
            new SqlParameter("@title", SqlDbType.VarChar) { Value = title_input.Text },
            new SqlParameter("@square", SqlDbType.TinyInt) { Value = Convert.ToInt32(comboBox1.SelectedItem) },
            new SqlParameter("@floor", SqlDbType.TinyInt) { Value = Convert.ToInt32(numericUpDown1.Value) },
            new SqlParameter("@des", SqlDbType.VarChar) { Value = des_input.Text.Trim() },
            new SqlParameter("@comment", SqlDbType.VarChar) { Value = comment_input.Text.Trim() }
        };
                bool insertSuccess = dao.executeNonQuery(insertQuery, insertParams);
                var rooms = dao.executeQuery("Select * from Rooms");
                dataGridView1.DataSource = rooms;
            }


            /*string title = title_input.Text;
            int square = Convert.ToInt32(comboBox1.SelectedItem);
            int floor = Convert.ToInt32(numericUpDown1.Value);
            string des = des_input.Text.Trim();
            string comment = comment_input.Text.Trim();
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Ngu");
            }
            else
            {
                AddRoom(title, square, floor, des, comment);

                title_input.Clear();
                comboBox1.SelectedIndex = 0;
                numericUpDown1.Value = 0;
                des_input.Clear();
                comment_input.Clear();
                MessageBox.Show("Hay");*/
        }
    }
}
