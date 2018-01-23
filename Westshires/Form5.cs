using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Westshires
{
    public partial class Form5 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form5()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/database/customers.accdb;Jet OLEDB:Database Password=Emo4ee123";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void removecustomer_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = " DELETE FROM customers WHERE [CustomerName] = '" + comboBox1.SelectedItem.ToString() + "'";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data deleted successfuly!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                customer_ID.Text = string.Empty;
            }
            else
            {
                customer_ID.Text = comboBox1.SelectedItem.ToString();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from customers";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["CustomerName"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            connection.Close();
           
        }
    }
}
