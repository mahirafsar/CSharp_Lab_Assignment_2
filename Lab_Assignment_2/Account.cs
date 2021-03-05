using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2
{
    class Account
    {
        static int accountcount = 10001;
        private int accountNumber;
        private string accountName;
        private double balance;
        private double startingBalance=0.0;
        private string address;
        private string dateOfBirth;

        public int AccNumber()
        {
            accountNumber = accountcount;
            accountcount++;
            return accountNumber;
        }

        //public Account(string accountName, double balance, Address address)
        //{
        //    //accountNumber = accountcount;
        //    //accountcount++;
        //    this.accountName = accountName;
        //    this.balance = balance;
        //    this.address = address;
        //}
        public int AccountNumber
        {
            set { accountNumber = value; }
            get { return accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public double StartingBalance
        {
           // set { this.startingBalance = value; }
            get { return this.startingBalance; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public string DateOfBirth
        {
            set { this.dateOfBirth = value; }
            get { return this.dateOfBirth; }
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine(amount + " Taka Deposit Done");

            Console.WriteLine();
        }
        virtual public void Withdraw(double amount)
        {
            if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
                Console.WriteLine(amount + " Taka Withdraw Done");
                //this.ShowInformation();
                Console.WriteLine();
                //return true;
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
                //return false;
            }
        }

        public void Transfer(Account a, double amount)
        {

            if (this.balance >= amount)
            {
                this.balance += amount;
                a.balance -= amount;
                Console.WriteLine("Account of " + this.accountName + " becomes $ " + this.balance);
                Console.WriteLine("Account of " + a.accountName + " becomes $ " + a.balance);

            }
            else
            {
                Console.WriteLine("Transfer fails");
            }
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nAccount Balance:{2}\nAddress:{3}\nDate Of Birth:{4}", AccNumber(), this.accountName, this.balance,this.address,this.dateOfBirth);
            //this.address.PrintAddress();
            //Console.WriteLine(this.address.GetAddress());
        }
        //public void ShowAccountInformation()
        //{
        //    Console.WriteLine("Account No:{0}\nAccount Name:{1}\nAccount Balance:{2}", this.AccountNumber, this.accountName, this.balance);
        //    //this.address.PrintAddress();
        //    Console.WriteLine(this.address.GetAddress());
        //}

    }
}
