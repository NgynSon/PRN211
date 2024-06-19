using LoadDB_ADO_sample.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadDB_ADO_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string getConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
            IConfiguration conn = builder.Build();
            return conn.GetConnectionString("DBContext");
        }
        List<Student> student;
        private void LoadDB()
        {
            student = new List<Student>();
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                conn.Open();
                string sql = "select * from Student";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    student.Add(new Student((int)dr[0], (string)dr[1], (int)dr[2], (string)dr[4]);
                }
                conn.Close();
            }
            dgvDisplay.DataSource = student;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dvgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
