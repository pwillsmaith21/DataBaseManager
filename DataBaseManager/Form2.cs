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
        public Form2(Database data)
        {
            this.data = data;
            InitializeComponent();
            AddDataTolist();
        }
        public void AddDataTolist()
        {
            List<string> dataList = data.DisplayData();
            //for( int i = 0; i < sb.Length; i++)
            //{
            //    dataBox.Items.Add(sb[i].ToString());
            //}
            dataBox.DataSource = dataList;


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
