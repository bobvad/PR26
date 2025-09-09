using MySql.Data.MySqlClient;
namespace WorkingDB
{
    public class Connection
    {
        static readonly string strConnection = "server=localhost;database=airlines;uid=root;";
        public static MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(strConnection);
            connection.Open();
            return connection;
        }
        public static MySqlDataReader Query(string Sql,MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `airlines`.`new_table`;", connection);
            return command.ExecuteReader();
        }
        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);
        }
    }
}
