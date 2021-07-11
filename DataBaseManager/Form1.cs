using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManager
{
    public partial class Form1 : Form 
    {
        public static Database data = new Database();
        public Form1()
        {
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
            data.ConnectToDataBase();
            Form2 form = new Form2();
            Hide();
            form.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void Insert_Click(object sender, EventArgs e)
        //{
        //    if( firstnameInput.Text != null && lastnameInput.Text != null && professionInput != null)
        //    {
        //        data.InsertData(firstnameInput.Text, lastnameInput.Text, professionInput.Text );
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
