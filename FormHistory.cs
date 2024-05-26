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

        //инициализация формы
        public FormHistory()
        {
            InitializeComponent();

            DateStart.CustomFormat = "dd/MM/yyyy";
            DateStart.Format = DateTimePickerFormat.Custom;
            DateStart.Value = System.DateTime.Now;

            DateTime.CustomFormat = "HH:mm";
            DateTime.ShowUpDown = true;
            DateTime.Format = DateTimePickerFormat.Custom;
            DateTime.Value = System.DateTime.Now;
        }

        //инициализация методов
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            LoadDataFromDatabase();
            InitializeDateTimePicker();
        }

        //иницализация таблицы
        private void InitializeDataTable()
        {
            //DataTable.Columns.Add("Id");
            DataTable.Columns.Add("Дата");
            DataTable.Columns.Add("Оригинальное название");
            DataTable.Columns.Add("Название после конвертации");
            dataGridView1.DataSource = DataTable;
        }

        //загрузка таблицы из бд в datatable
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

        //инициализация ивента изменения datetimepicker
        private void InitializeDateTimePicker()
        {
            DateStart.ValueChanged += new EventHandler(DateTimePicker1_ValueChanged);
        }

        //действия при ивенте изменения datetimepicker
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DateStart.Value.Date;
            TimeSpan selectedTime = DateTime.Value.TimeOfDay;

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT " +
                    "convertdateandtime AS Дата, fileoriginalname AS \"Оригинальное название\", fileconvertedname AS \"Название после конвертации\" " +
                    "FROM \"DataModel\" " +
                    "WHERE date_trunc('day', convertdateandtime) = date_trunc('day', @selectedDate::timestamp) " +
                    "AND date_trunc('minute', convertdateandtime) = date_trunc('minute', @selectedTime::timestamp)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate);
                    cmd.Parameters.AddWithValue("@selectedTime", selectedTime);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }

        //кнопка загрузки файлов
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

                using (var cmd = new NpgsqlCommand("SELECT filename, filedata FROM \"DataModel\"", conn))
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

        //кнопка назад
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
