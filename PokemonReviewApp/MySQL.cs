//using System;
//using MySql.Data.MySqlClient;

//namespace PokemonReviewApp
//{
//    public class MySQL
//    {
//        static MySqlConnection con;

//        public static void Connect()
//        {
//            con = new MySqlConnection();

//            try
//            {
//                string connectionString = "Server=localhost;" +
//              "Database=Pokemonreviewer;" +
//              "Uid=root;" +
//              "Pwd=Mohammed;" + // Leave password empty
//              "SslMode=None;";// Set SSL mode to None
//                con.ConnectionString = connectionString;
//                con.Open();
//                Console.WriteLine("Successfully connected to MySQL database!");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Connection to MySQL database failed! Error: " + e.ToString());
//            }
//        }
//    }
//}
