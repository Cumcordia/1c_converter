using Npgsql;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
            //CreateOrUpdateTable();

            var connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=123";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
        }



        /*static bool TableExists(NpgsqlConnection conn, string tableName)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT EXISTS (SELECT 1 FROM information_schema.tables WHERE table_schema = 'public' AND table_name = @tableName)";
                cmd.Parameters.AddWithValue("@tableName", tableName);
                return (bool)cmd.ExecuteScalar();
            }
        }

        static void CreateTable(NpgsqlConnection conn)
        {
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "CREATE TABLE DataModel (Id INT PRIMARY KEY, ConvertDateAndTime TIMESTAMP, FileOriginalName VARCHAR(255), FileConvertedName VARCHAR(255))";
                cmd.ExecuteNonQuery();
            }
        }

        static void CreateOrUpdateTable()
        {
            string connString = "Host=localhost;Username=postgres;Password=123;Database=postgres";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                if (!TableExists(conn, "DataModel"))
                {
                    CreateTable(conn);
                }
            }
        }*/
    }
}