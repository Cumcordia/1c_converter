using Npgsql;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            var connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=123";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
        }
    }
}