﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace DataBaseManager
{
    public class Database
    {
        protected string constr = @"Data Source= DESKTOP-BQ1O4AU; Initial Catalog=testData;Integrated Security=True;";
        SqlConnection connection;
        public void ConnectToDataBase()
        {
            connection = new SqlConnection(constr);
            connection.Open();

        }
        public bool InsertData(string firstname, string lastname, string profession)
        {
            try
            {
                string query = ($@"Insert into person values('{firstname}','{lastname}', '{profession}')  ");

                SqlDataAdapter dWriter = new SqlDataAdapter();
                dWriter.InsertCommand = new SqlCommand(query, connection);
                dWriter.InsertCommand.ExecuteNonQuery();
            }
            catch (System.IndexOutOfRangeException e)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
            return true;


        }
        public string DisplayData()
        {
            string query = (" select * from person");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dreader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
        while( dreader.NextResult() != null)
            {
                dreader.Read();
                sb.Append(dreader.NextResult().ToString());
                
            }
            return sb.ToString();
                }
    }
}