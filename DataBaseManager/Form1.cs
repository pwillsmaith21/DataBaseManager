using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace DataBaseManager
{
    public partial class Form1 : Form 
    {
        public static Database data = new Database();
        public string table;
        public Form1()
        {

            this.table = string.Empty;
            InitializeComponent();
            AddtabletoList();
        }
        public void AddtabletoList()
        {
            tableOption.Items.Add("person");
            tableOption.Items.Add("superhero");
            databaseBox.Text = "testData";

        }
        private void Connect_Click(object sender, EventArgs e)
        {

            this.table = tableOption.SelectedItem.ToString();
            Form2 form = new Form2(data,table);
            Hide();
            form.Show();

        }

    }
}
