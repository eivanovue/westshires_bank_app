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
    public partial class Form4 : Form
    {
        string Account;
        double overdraft1;
        private OleDbConnection connection = new OleDbConnection();
        public Form4()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/database/customers.accdb;Jet OLEDB:Database Password=Emo4ee123";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

      

        private void Form4_Load(object sender, EventArgs e)
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
                    comboBox1.Items.Add(reader["AccountNumber"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from customers where AccountNumber='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    customercode.Text = reader["CustomerCode"].ToString();
                    accountnumber.Text = reader["AccountNumber"].ToString();
                    customername.Text = reader["CustomerName"].ToString();
                    
                    Account = reader["Account"].ToString();
                    accountnickname.Text = reader["AccountNickname"].ToString();
                    overdraft.Text = reader["Overdraft"].ToString();

                  
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

       
        private void change_nickname_Click(object sender, EventArgs e)
        {
           
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update customers set [CustomerCode]='" + customercode.Text + "',[CustomerName]='" + customername.Text + "',[Overdraft]='" + overdraft.Text + "',[AccountNickname]='" + accountnickname.Text + "' where AccountNumber='" + accountnumber.Text + "'";
               MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data updated successfuly!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            connection.Close();
        }

        

        private void overdraft_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void overdraft_MouseClick(object sender, MouseEventArgs e)
        {
            if (Account == "Prestige")
            {

            }
            else
            {
                
                MessageBox.Show("You cannot change the overdraft limit on this type of account: " + Account);

                overdraft.Enabled = false;
            }
        }
    }
}
