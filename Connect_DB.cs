using System;
using Npgsql; //import PostgreSQL data provider
using System.Data.SqlClient;

//First testing connection to the DB: Select data from table and display


namespace connect_DB //namespace: The name of project
{
    class Program  //class name: The name of .cs file
    {
        public static void Main(string[] args)  //main: main part ot program
        {
            //Connection settings
            var cs = "Host=; Username=; Password=; Database=; Port=";
            using var con = new NpgsqlConnection(cs); //connect to DB
            con.Open(); //Connect to DB

            /* Simple Select Query command
             var select = "SELECT * FROM \"webtest_proj\""; 
             var command = new NpgsqlCommand(select, con);
             NpgsqlDataReader reader = command.ExecuteReader();

            // Display the select query result
            while (reader.Read())
            {
                Console.WriteLine("Query result: {0} {1} {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

            }
            
            */

            /*
            //SQL Insert
            using (var cmd = new NpgsqlCommand("INSERT INTO \"webtest_proj\" (\"Name\", \"Desc\", \"TestResult\", \"CreateDate\", \"ModifyDate\")" +
                "VALUES (@v1, @v2, @v3, @v4, @v5)", con))
            {
                cmd.Parameters.AddWithValue("v1", "高雄市政府");
                cmd.Parameters.AddWithValue("v2", "高雄市政府測試");
                cmd.Parameters.AddWithValue("v3", "Testing");
                //Create Date
                DateTime CreateDate = DateTime.Parse("2021/3/16");
                cmd.Parameters.AddWithValue("v4", CreateDate);
                //Modify date
                DateTime localDate = DateTime.Now;
                cmd.Parameters.AddWithValue("v5", localDate);
                cmd.ExecuteNonQuery();
            }
            */
            
            //SQL Delete
            using (var cmd = new NpgsqlCommand("DELETE FROM \"webtest_proj\" WHERE \"Name\" = @value", con))
            {
                cmd.Parameters.AddWithValue("value", "高雄市政府");
                cmd.ExecuteNonQuery();
            }
            


            con.Close();
            

        }
        
    }
}
