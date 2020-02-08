using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn.Database
{
    class DatabaseOperations
    {
        string connectionString, sqlQuery, output;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet dataSet;
        
        public static void Main()
        {

        }

        /// <summary>
        /// Database name: Demodb
        ///Username: sa
        ///Password: demo123
        /// Table Name: tableName
        /// Columns to be selected: columnName1, columnName2
        /// </summary>
        public void connectToDatabase()
        {
            connectionString = @"Data Source=WIN-123KL987;Initial Catalog=Demodb;User ID=sa;Password=demol23"; ;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void readDataFromDatabase()
        {
            connectToDatabase();
            sqlQuery = "SELECT columnName1, columnName2 FROM tableName";
            command = new SqlCommand(sqlQuery, connection);
            dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                output = output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + "\n";
            }

            Console.WriteLine("Database Data: "+ output);
            dataReader.Close();
            command.Dispose();
            connection.Close();
        }

        public void insertDataIntoDatabase()
        {
            connectToDatabase();
            sqlQuery = "INSERT INTO tableName values(1, '" + "C#" + "')";
            command = new SqlCommand(sqlQuery, connection);
            dataAdapter.InsertCommand = command;
            int i = dataAdapter.InsertCommand.ExecuteNonQuery();
            
            Console.WriteLine("The number of affected rows: {0}", i);
            command.Dispose();
            dataAdapter.Dispose();
            connection.Close();
        }

        public void updateDataIntoDatabase()
        {
            connectToDatabase();
            sqlQuery = "UPDATE tableName SET columnName2 = '"+ "VB.Net"+ "' where columnName1 = 1";
            command = new SqlCommand(sqlQuery, connection);
            dataAdapter.UpdateCommand = command;
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        public void deleteFromDatabase()
        {
            connectToDatabase();
            sqlQuery = "DELETE FROM tableName WHERE columnName1 = 3";
            command = new SqlCommand(sqlQuery, connection);
            dataAdapter.DeleteCommand = command;
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        //public void closeAllDatabaseConnectionObjects()
        //{
        //    dataReader.Close();
        //    command.Dispose();
        //    connection.Close();
        //}


    }
}
