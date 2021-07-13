using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;
namespace DataBaseManager
{
    public class Database
    {
       
        public bool InsertData(string firstname, string lastname, string profession, string table)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("testData")))
            {
                try
                {
                    string query = ($@"Exec insertValues @firstname = '{firstname}', @lastname = '{lastname}', @work = '{profession}'");

                    connection.Execute(query);
                }
                catch (System.Data.SyntaxErrorException e)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
            return true;


        }

        internal void deleteItem(int index)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("testData")))
            {
                Console.WriteLine(index);
                string query = $"Exec deleteItem @id = {index}";
                Console.WriteLine(connection.Execute(query));
            }        
        }

        public bool VerifyTable(string table)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("testData")))
            {
                string query = "select * from INFORMATION_SCHEMA.TABLES";
                var reader = connection.ExecuteReader(query);
                while (reader.Read())
                {
                    if (reader[2].ToString().Equals(table))
                    {
                        reader.Close();
                        return true;
                    }
                }
            }
            return false;
        }
        public List<person> DisplayData(string table)
        {
            if (VerifyTable(table))
            {
                using (var connection = new SqlConnection(Helper.CnnVal("testData")))
                {
                    string query = ($"select * from {table}");
                    List<person> dataList = connection.Query<person>(query).AsList();

                    return dataList;
                }
            }
            return new List<person>();
                }
    }
}