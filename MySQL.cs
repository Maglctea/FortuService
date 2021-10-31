﻿using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace FortuService
{
    public class MySQL
    {
        public readonly MySqlConnection connection = new("Server=94.103.81.106;" +
                                                        "Port=3307;" +
                                                        "Database=FortuService;" +
                                                        "User Id=Fortunella;" +
                                                        "Password=Mexanik_X3000;" +
                                                        "Allow User Variables=True;");
    
        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataTable GetTable(string request)
        {

            MySqlDataAdapter adapter = new();
            DataTable table = new();
            MySqlCommand command = new(request, connection);

            adapter.SelectCommand = command;


            adapter.Fill(table);

            return table;
        }

        public MySqlDataReader GetReader(string request)
        {
            MySqlCommand command = new(request, connection);
            OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

    }
}
