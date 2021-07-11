using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataBaseManager
{
    public partial class Form2 : Form
    {
        public Database data;
        public string table;
        public Form2(Database data, string table)
        {
            this.data = data;
            this.table = table;
            InitializeComponent();
            AddDataTolist();
        }
        public void AddDataTolist()
        {
            List<string> dataList = data.DisplayData(table);
            //for( int i = 0; i < sb.Length; i++)
            //{
            //    dataBox.Items.Add(sb[i].ToString());
            //}
            dataBox.DataSource = dataList;


        }
      

        private void insertData_Click(object sender, EventArgs e)
        {
            InsertData form = new InsertData(data, table);
            form.Show();
            AddDataTolist();

        }

        private void dataBox_DoubleClick(object sender, EventArgs e)
        {
            int index = dataBox.SelectedItem.ToString().ToCharArray()[0]-48;
            data.deleteItem(index, table);
            AddDataTolist();
        }
    }
}
