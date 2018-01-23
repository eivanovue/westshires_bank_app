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
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/database/customers.accdb;Jet OLEDB:Database Password=Emo4ee123";

        }
        double interest;
        double fees;
        string atm;
        string Account;
        double Overdraft;
        double ballance; 
        Saver saver = new Saver();
        Classic classic = new Classic();
        Prestige prestige = new Prestige();
            

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Account = "Saver";
          
            saver.AccountOverdraft = saver.AccountOverdraft;

            saver.AccountFees = saver.AccountFees;
            fees = saver.AccountFees;

            saver.AccountInterest = saver.AccountInterest;
            interest = saver.AccountInterest;

            saver.ATM = saver.ATM;
            atm = saver.ATM;

            saver.AccountBalance = saver.AccountBalance;
            ballance = saver.AccountBalance;

            Overdraft = saver.AccountOverdraft;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Account = "Classic";
   
            classic.AccountOverdraft = classic.AccountOverdraft;

            classic.AccountFees = classic.AccountFees;
            fees = classic.AccountFees;

            classic.AccountInterest = classic.AccountInterest;
            interest = classic.AccountInterest;

            classic.ATM = classic.ATM;
            atm = classic.ATM;

            classic.AccountBalance = classic.AccountBalance;
            ballance = classic.AccountBalance;

            Overdraft = classic.AccountOverdraft;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Account = "Prestige";
            prestige.AccountOverdraft = prestige.AccountOverdraft;
            prestige.AccountFees = prestige.AccountFees;
            fees = prestige.AccountFees;

            prestige.AccountInterest = prestige.AccountInterest;
            interest = prestige.AccountInterest;

            prestige.ATM = prestige.ATM;
            atm = prestige.ATM;
            prestige.AccountBalance = prestige.AccountBalance;
            ballance = prestige.AccountBalance;

            Overdraft = prestige.AccountOverdraft;
           
        }
        private void add_customer_Click(object sender, EventArgs e)
        {
           //SET FUNCTIONS
            Customer code = new Customer();
            code.CustomerCode = customercode.Text;
            Account number = new Account();
            number.AccountNumber = accountnumber.Text;
            Customer name = new Customer();
            name.Name = customername.Text;
            Customer address = new Customer();
            address.Address = customeraddress.Text;
            Customer phone = new Customer();
            phone.PhoneNumber = customerphone.Text;
            Account accnum = new Account();
            accnum.AccountNickname = accountnickname.Text;
            
            //Accounts

            


            //Database

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command = new OleDbCommand("INSERT INTO customers ([CustomerCode], [AccountNumber], [CustomerName], [Address], [PhoneNumber], [Account], [AccountNickname], [Overdraft], [Interest], [Fees], [ATMPossible]) VALUES (@CustomerCode,@AccountNumber,@CustomerName,@Address,@PhoneNumber,@Account,@AccountNickname, @Overdraft, @Interest, @Fees, @ATMPossible)", connection);
                command.Parameters.AddWithValue("@CustomerCode", customercode.Text);
                command.Parameters.AddWithValue("@AccountNumber", accountnumber.Text);
                command.Parameters.AddWithValue("@CustomerName", customername.Text);
                command.Parameters.AddWithValue("@Address", customeraddress.Text);
                command.Parameters.AddWithValue("@PhoneNumber", customerphone.Text);
                command.Parameters.AddWithValue("@Account", Account);
                command.Parameters.AddWithValue("@AccountNickname", accountnickname.Text);
                command.Parameters.AddWithValue("@Overdraft", Overdraft);
                command.Parameters.AddWithValue("@Interest", interest);
                command.Parameters.AddWithValue("@Fees", fees);
                command.Parameters.AddWithValue("@ATMPossible", atm);
                command.Parameters.AddWithValue("@Ballance", ballance);
                command.ExecuteNonQuery();
                MessageBox.Show("Data saved successfuly!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            connection.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
