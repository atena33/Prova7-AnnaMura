using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7_AnnaMura
{
    class DbManager
    {
        const string connectionString = @"Data Source= (localdb)\MSSQLLocalDB;" +
                                          "Initial Catalog = Utenti;" +
                                          "Integrated Security=true;";


        public static void GetUsers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection; 
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "select * from dbo.Utente";

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        string nome = (string)reader["Nome"];
                        string cognome = (string)reader["Cognome"];

                        Console.WriteLine($"Utente: {nome} {cognome} \t");
                    }


                    connection.Close();
                    
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }
        }
    }
    
}
