using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataBaseManager
{
    public partial class InsertData : Form
    {
        public Database data;
        public string table;
        public InsertData(Database data, string table)
        {
            this.data = data;
            this.table = table;
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (firstNameBox.Text != null && lastNameBox.Text != null && professionBox.Text != null)
            {
                data.InsertData(firstNameBox.Text, lastNameBox.Text, professionBox.Text, table);
                MessageBox.Show("suceed");
                Hide();
            }
        }
    }
}
