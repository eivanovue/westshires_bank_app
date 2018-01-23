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
    public partial class Form3 : Form
    {
        string Account;
        double Deposit;
        double Ballance;
        double Deposittxt;
        double Withdrawtxt;
        double Withdraw;
        double Overdraftadd;
        private OleDbConnection connection = new OleDbConnection();
        public Form3()
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



        private void Form3_Load(object sender, EventArgs e)
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
                    balance.Text = reader["Ballance"].ToString();
                    overdraft.Text = reader["Overdraft"].ToString();
                    txt_interest.Text = reader["Interest"].ToString() + "% Interest";
                    txt_fees.Text = "Annual fees: "+ reader["Fees"].ToString()+ "£";
                    txt_ATM.Text = "ATM possible: " +reader["ATMPossible"].ToString();

                    Account acc = new Account();
                    

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            Ballance = double.Parse(balance.Text);
            Deposittxt = double.Parse(txt_deposit.Text);
            Deposit = Ballance + Deposittxt;
 
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update customers set [CustomerCode]='" + customercode.Text + "',[CustomerName]='" + customername.Text + "',[Ballance]='" + Deposit + "' where AccountNumber='" + accountnumber.Text + "'";
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

        private void withdraw_Click(object sender, EventArgs e)
        {
            Ballance = double.Parse(balance.Text);
            Withdrawtxt = double.Parse(txt_withdraw.Text);
            Overdraftadd = double.Parse(overdraft.Text);

            if (Withdrawtxt > Ballance)
            {
                Ballance = 0;
                Overdraftadd = Overdraftadd - Withdrawtxt;
            }
            else if (Withdrawtxt > Ballance && Overdraftadd <=0)
            {
                Ballance = Ballance - Withdrawtxt;
                Overdraftadd = 0;
            }
            else
            {
                Ballance = Ballance - Withdrawtxt;
              
            }

            if (Ballance < 0)
            {
                MessageBox.Show("You have withdrawn more than your overdraft limit.");
            }
            else try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "update customers set [CustomerCode]='" + customercode.Text + "',[CustomerName]='" + customername.Text + "',[Ballance]='" + Ballance + "',[Overdraft]='" + Overdraftadd + "' where AccountNumber='" + accountnumber.Text + "'";
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
            
           
           
        }
     }      
