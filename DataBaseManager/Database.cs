using System;
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
        public bool InsertData(string firstname, string lastname, string profession, string table)
        {
            try
            {
                string query = ($@"Insert into {table} values('{firstname}','{lastname}', '{profession}')  ");

                SqlDataAdapter dWriter = new SqlDataAdapter();
                dWriter.InsertCommand = new SqlCommand(query, connection);
                dWriter.InsertCommand.ExecuteNonQuery();
            }
            catch (System.Data.SyntaxErrorException e)
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

        internal void deleteItem(int index, string table)
        {
            string query = $"Delete from {table} where ID = {index}";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public bool VerifyTable(string table)
        {
            string query = "select * from INFORMATION_SCHEMA.TABLES";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                if (reader[2].ToString().Equals(table)){
                    reader.Close();
                    return true;
                }
            }
            return false;
        }
        public List<string> DisplayData(string table)
        {
            if (VerifyTable(table))
            {
                string query = ($"select * from {table}");
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dreader = command.ExecuteReader();
                List<string> dataList = new List<string>();
                while (dreader.Read())
                {
                    dataList.Add($"{dreader[3]} Firstname: {dreader[0]} Lastname: { dreader[1]} Profession: { dreader[2]}");

                }
                dreader.Close();
                return dataList;
            }
            return new List<string>();
                }
    }
}