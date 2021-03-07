using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account savings = new SavingsAccount();
            Account checking = new CheckingAccounts();
            string choice, choice1,choice3;
            //choice = Console.ReadLine();
            int choice2,choice4,choice5,choice6;
            int savingsAccount = 0;
            int checkingAccount = 0;


            do
            {
                Console.WriteLine("Command 'open' for Open an account");
                Console.WriteLine("Command 'account' for Perform transections on an account");
                Console.WriteLine("Command 'quit' for Exit the application");

                Console.WriteLine("Please enter a command");
                choice = Console.ReadLine();



                switch (choice)
                {
                    case "open":
                        do
                        {
                            Console.WriteLine("Command 'savings' for open a Savings Account");
                            Console.WriteLine("Command 'checking' for open a Checking Account");
                            Console.WriteLine("Command 'quit' for Exit the application");
                            Console.WriteLine("Please enter a command");

                            choice1 = Console.ReadLine();
                            switch (choice1)
                            {
                                case "savings":
                                    Console.WriteLine("Enter a name:");
                                    string savingName = Console.ReadLine();
                                    savings.AccountName = savingName;

                                    Console.WriteLine("Enter date of birth:");
                                    string savingDateOfBirth = Console.ReadLine();
                                    savings.DateOfBirth = savingDateOfBirth;

                                    Console.WriteLine("Enter Address:");
                                    string savingAddress = Console.ReadLine();
                                    savings.Address = savingAddress;

                                    Console.WriteLine("Starting Balance: " + savings.StartingBalance);

                                    //Console.WriteLine("Account Number: "+savings.AccNumber());

                                    Console.WriteLine("Now Account is created");
                                    savingsAccount=1;
                                    break;

                                case "checking":
                                    Console.WriteLine("Enter a name:");
                                    string checkingName = Console.ReadLine();
                                    checking.AccountName = checkingName;

                                    Console.WriteLine("Enter date of birth:");
                                    string checkingDateOfBirth = Console.ReadLine();
                                    checking.DateOfBirth = checkingDateOfBirth;

                                    Console.WriteLine("Enter Address:");
                                    string checkingAddress = Console.ReadLine();
                                    checking.Address = checkingAddress;

                                    Console.WriteLine("Starting Balance: " + checking.StartingBalance);

                                    //Console.WriteLine("Account Number: " + checking.AccNumber());

                                    Console.WriteLine("Now Account is created");
                                    checkingAccount = 1;
                                    break;

                            }

                        } while (choice1!="quit");
                    break;

                    case "account":
                        do
                        {
                            Console.WriteLine("Command 'deposite' for Make a deposite");
                            Console.WriteLine("Command 'withdraw' for Make a withdraw");
                            Console.WriteLine("Command 'transfer' for Make a transfer");
                            Console.WriteLine("Command 'show' for Show the transaction");
                            Console.WriteLine("COmmand 'quit' for Exit the application");
                            choice3 = Console.ReadLine();
                           
                            switch (choice3)
                            {
                                case "deposite":
                                    do {
                                        Console.WriteLine("Select an option:");
                                        Console.WriteLine("1.Deposite amount to savings account");
                                        Console.WriteLine("2.Deposite amount to checking account");
                                        Console.WriteLine("3.Back");
                                        choice2 = Convert.ToInt32(Console.ReadLine());
                                        switch (choice2)
                                        {
                                            case 1:
                                                if (savingsAccount == 1)
                                                {
                                                    Console.WriteLine("insert deposite amount for savings account:");
                                                    double savingAmount = Convert.ToDouble(Console.ReadLine());
                                                    savings.Deposit(savingAmount);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("There is no savings account");
                                                }
                                                break;

                                            case 2:
                                                if (checkingAccount == 1)
                                                {
                                                    Console.WriteLine("insert deposite amount for checking account:");
                                                    double checkingAmount = Convert.ToDouble(Console.ReadLine());
                                                    checking.Deposit(checkingAmount);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("There is no checking account");
                                                }
                                                break;
                                        }
                                    } while (choice2!=3);
                                    break;

                                case "withdraw":
                                    do
                                    {
                                        Console.WriteLine("Select an option:");
                                        Console.WriteLine("1.Withdraw amount to savings account");
                                        Console.WriteLine("2.Withdraw amount to checking account");
                                        Console.WriteLine("3.Back");
                                        choice4 = Convert.ToInt32(Console.ReadLine());
                                        switch (choice4)
                                        {
                                            case 1:
                                                if (savingsAccount == 1)
                                                {
                                                    Console.WriteLine("insert withdraw amount for savings account:");
                                                    double savingWithdraw = Convert.ToDouble(Console.ReadLine());
                                                    savings.Withdraw(savingWithdraw);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("There is no savings account");
                                                }
                                                break;

                                            case 2:
                                                if (checkingAccount == 1)
                                                {
                                                    Console.WriteLine("insert withdraw amount for checking account:");
                                                    double checkingWithdraw = Convert.ToDouble(Console.ReadLine());
                                                    checking.Withdraw(checkingWithdraw);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("There is no checking account");
                                                }
                                                break;
                                        }
                                    } while (choice4 != 3);
                                    break;

                                case "transfer":
                                    do
                                    {
                                        Console.WriteLine("Select an option:");
                                        Console.WriteLine("1.Transfer from savings account to checking account");
                                        Console.WriteLine("2.Transfer from current account to savings account");
                                        Console.WriteLine("3.Back");
                                        choice5 = Convert.ToInt32(Console.ReadLine());
                                        switch (choice5)
                                        {
                                            case 1:
                                                if (savingsAccount == 1 && checkingAccount==1)
                                                {
                                                    Console.WriteLine("Enter amount you want to transfer to checking account");
                                                    double am = Convert.ToDouble(Console.ReadLine());
                                                    checking.Transfer(savings,am);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Either checking or savings or both accounts are not created");
                                                }
                                                break;

                                            case 2:
                                                if (savingsAccount == 1 && checkingAccount == 1)
                                                {
                                                    Console.WriteLine("Enter amount you want to transfer to savings account");
                                                    double bm = Convert.ToDouble(Console.ReadLine());
                                                    savings.Transfer(checking,bm);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Either checking or savings or both accounts are not created");
                                                }
                                                break;
                                        }
                                    } while (choice5 != 3);
                                    break;

                                case "show":
                                    do
                                    {
                                        Console.WriteLine("Select an option:");
                                        Console.WriteLine("1.Show the saving account information");
                                        Console.WriteLine("2.Show the checking account information");
                                        Console.WriteLine("3.Back");
                                        choice6 = Convert.ToInt32(Console.ReadLine());
                                        switch (choice6)
                                        {
                                            case 1:

                                                savings.ShowAccountInformation();
                                                break;

                                            case 2:

                                                checking.ShowAccountInformation();
                                                break;
                                        }
                                    } while (choice6 != 3);
                                    break;

                            }

                        } while (choice3!="quit");

                    break;
                
                }


            } while (choice!="quit");

         
        }
    }
}
