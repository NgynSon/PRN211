using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;


namespace Q1
{
    public partial class Form1 : Form
    {
        private string selectedGender;

        public Form1()
        {

            InitializeComponent();
            radioButton1.Checked = true;
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectionChangeCommitted += new EventHandler(comboBox1_SelectedIndexChanged);
            /*dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);*/
        }

        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConnection = config["ConnectionStrings:MyDatabase"];
            return strConnection ?? string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowEmployeeInformation();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells["Name"].Value.ToString();
                string Sex = selectedRow.Cells["Sex"].Value.ToString();
                selectedGender = dataGridView1.SelectedRows[0].Cells["Sex"].Value.ToString();

                if (Sex == "Male")
                {
                    radioButton2.Checked = true;
                }
                else if (Sex == "Female")
                {
                    radioButton3.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }
            }
        }

        private void ShowEmployeeInformation()
        {
            try
            {
                string connectionString = GetConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string positionFilter = "";
                    string query = $"SELECT * FROM Employee{positionFilter}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPosition = comboBox1.SelectedItem.ToString();

            if (selectedPosition != "All positions")
            {
                try
                {
                    string connectionString = GetConnectionString();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT * FROM Employee WHERE Position = @Position";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Position", selectedPosition);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                dataGridView1.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                ShowEmployeeInformation();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedGender("Male/Female");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedGender("Male");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedGender("Female");
        }

        private void UpdateSelectedGender(string gender)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Sex"].Value = gender;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Name"].Value = textBox1.Text;
            }
        }
    }
}
