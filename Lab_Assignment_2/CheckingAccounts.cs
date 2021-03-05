using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2
{
    class CheckingAccounts:Account
    {
        override public void Withdraw(double amount)
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

    }
}
