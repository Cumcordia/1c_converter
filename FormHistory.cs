using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class FormHistory : Form
    {
        private DataTable DataTable = new DataTable();
        private string connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=123";

        public FormHistory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            LoadDataFromDatabase();
            InitializeDateTimePicker();
        }

        private void InitializeDataTable()
        {
            DataTable.Columns.Add("Id");
            DataTable.Columns.Add("Дата");
            DataTable.Columns.Add("Оригинальное название");
            DataTable.Columns.Add("Название после конвертации");
            dataGridView1.DataSource = DataTable;

            //dataGridView1.Sort(dataGridView1.Columns["Дата"], System.ComponentModel.ListSortDirection.Descending);
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                DataTable.Clear();

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM \"DataModel\"";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Id = reader.GetInt32(0);
                            DateTime ConvertDateAndTime = reader.GetDateTime(1);
                            string FileOriginalName = reader.GetString(2);
                            string FileConvertedName = reader.GetString(3);
                            DataTable.Rows.Add(Id, ConvertDateAndTime, FileOriginalName, FileConvertedName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void InitializeDateTimePicker()
        {
            DateStart.ValueChanged += new EventHandler(DateTimePicker1_ValueChanged);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DateStart.Value.Date;

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM \"DataModel\" WHERE date_trunc('day', \"ConvertDateAndTime\") = @selectedDate";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogOut = folderBrowserDialogHistory.ShowDialog();
            if (dialogOut == DialogResult.OK)
            {
                outputTextHistory.Text = folderBrowserDialogHistory.SelectedPath;
            }

            string connString = connectionString;
            string outputDirectory = outputTextHistory.Text;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT filename, filedata FROM files", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string filename = reader.GetString(0);
                            byte[] fileData = (byte[])reader["filedata"];

                            string outputPath = Path.Combine(outputDirectory, filename);
                            File.WriteAllBytes(outputPath, fileData);
                        }
                    }
                }
            }
        }


        /*private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateStart = DateStart.Value.Date;
            string outputDirectory = outputTextHistory.Text + "\\";
            string connString = connectionString;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT filename, filedata FROM files WHERE upload_date = @dateStart", conn))
                {
                    cmd.Parameters.AddWithValue("dateStart", NpgsqlTypes.NpgsqlDbType.Timestamp, dateStart);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string filename = reader.GetString(0);
                            byte[] fileData = (byte[])reader["filedata"];

                            string outputPath = Path.Combine(outputDirectory, filename);
                            File.WriteAllBytes(outputPath, fileData);
                        }
                    }
                }
            }
            MessageBox.Show("Файлы успешно загружены.");
        }*/


        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
