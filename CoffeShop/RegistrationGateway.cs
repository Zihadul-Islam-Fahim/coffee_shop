using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    class RegistrationGateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        RegistrationClass registrationClass = null;
        List<RegistrationClass> registrationList = null;

        public RegistrationGateway()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }

        public void InsertIntoRegistrationTable(RegistrationClass registrationClass)
        {
            connection.Open();
            string insertString = "INSERT INTO registrationTable VALUES('" + registrationClass.Firstname + "','" + registrationClass.LastName + "','" + registrationClass.Username + "','" + registrationClass.Password + "')";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
        public List<RegistrationClass> RetrieverRegistrationClassFromRegistrationTable()
        {
            connection.Open();
            string queryString = "SELECT * FROM registrationTable";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            Console.WriteLine(dataReader.ToString());

            registrationList = new List<RegistrationClass>();

            while (dataReader.Read())
            {
                registrationClass = new RegistrationClass();
                registrationClass.Firstname = dataReader["firstName"].ToString();
                registrationClass.LastName = dataReader["lastName"].ToString();
                registrationClass.Username = dataReader["username"].ToString();
                registrationClass.Password = dataReader["password"].ToString();

                registrationList.Add(registrationClass);
            }

            connection.Close();
            return registrationList;
        }
    }
}
