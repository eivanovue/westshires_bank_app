using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Westshires
{
    public class Account
    {
        private string accountnumber;
        protected double accountBalance;
        protected double accountOverdraft;
        protected double annualFees;
        protected double accountInterest;
        protected string ATMPossible;
        protected string nickname;

        public string AccountNumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }
        public virtual string AccountNickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
       
        public virtual double AccountOverdraft
        {
            get { return accountOverdraft; }
            set { accountOverdraft = value; }
        }
        public virtual double AccountFees
        {
            get { return annualFees; }
            set { annualFees = value; }
        }
        public virtual double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }
        public virtual double AccountInterest
        {
            get { return accountInterest; }
            set { accountInterest = value; }
        }
        public virtual string ATM
        {
            get { return ATMPossible; }
            set { ATMPossible = value; }
        }



    }
    class Saver : Account
    {

        double interest = 6;
        string ATMm = "No";
        double overdraft = 500;
        string nick;
        double ballanz = 0;

        override public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = ballanz; }
        }
       
       override public double AccountInterest
        {
            get { return accountInterest; }
            set { accountInterest = interest; }
        }
       override public string ATM
       {
           get { return ATMPossible; }
           set { ATMPossible = ATMm; }
       }
      override public string AccountNickname
       {
           get { return nickname; }
           set { nickname = nick; }
       }
    }
    class Classic : Account
    {
        double interest = 2;
        string ATMm = "Yes";
        double overdraft = 500;
        string nick;
        double ballanz=0;
        override public double AccountOverdraft
        {
            get { return accountOverdraft; }
            set { accountOverdraft = overdraft; }
        }
        override public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = ballanz; }
        }
           override public double AccountInterest
        {
            get { return accountInterest; }
            set { accountInterest = interest; }
        }
           override public string ATM
           {
               get { return ATMPossible; }
               set { ATMPossible = ATMm; }
           }
          override public string AccountNickname
           {
               get { return nickname; }
               set { nickname = nick; }
           }
        
    }
    class Prestige : Account
    {
        double interest = 4;
        string ATMm = "Yes";
        double overdraft = 500;
        double fees=25;
        string nick;
        double ballanz = 0;

        override public double AccountFees
        {
            get { return annualFees; }
            set { annualFees = fees; }
        }
        override public double AccountOverdraft
        {
            get { return accountOverdraft; }
            set { accountOverdraft = overdraft; }
        }
        override public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = ballanz; }
        }
        override public double AccountInterest
        {
            get { return accountInterest; }
            set { accountInterest = interest; }
        }
        override public string ATM
        {
            get { return ATMPossible; }
            set { ATMPossible = ATMm; }
        }
       override public string AccountNickname
        {
            get { return nickname; }
            set { nickname = nick; }
        }
    }

}
