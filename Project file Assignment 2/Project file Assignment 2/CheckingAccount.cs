using System;
using System.Collections.Generic;
using System.Text;

namespace Project_file_Assignment_2
{
    public class CheckingAccount : BankAccount, ITransaction
    {
        public double InterestRate { get; set; }
        public CheckingAccount(string name, string account_number, double balance, double interestrate) : base(name, account_number, balance)
        { InterestRate = interestrate; }
        public override void CalculateInterest(double amountr)
        {
            double a = amountr * (InterestRate / 100);
            Console.WriteLine($"The total amount of interest we got is {a}");
        }
        public override void ExecuteTransaction(double amountt)
        {
            Console.WriteLine($"The transaction amount of {amountt } is executed");
        }
        public override void PrintTransaction()
        {
            Console.WriteLine($"Your Transaction has been done.");
        }
        public override void Deposit(double amountw)
        {
            if (Balance < amountw)
            {
                Console.WriteLine("You have an unsufficient amount to withdraw");
            }
            else
            {
                if (TransactionTypes.ContainsKey("Withdraw"))
                {

                    Transaction transfer = new Transaction($"The Amount {amountw} is Withdrawn");
                    Transactions1.Add(transfer);
                    TransactionTypes["Withdraw"].Add(transfer);
                    Console.WriteLine($" The Amount {amountw} is Withdrawn");
                    Balance -= amountw;
                }
                else
                {

                    Transaction transfer = new Transaction($"The Amount {amountw} is Withdrawn");
                    Transactions1.Add(transfer);
                    TransactionTypes["Withdraw"].Add(transfer);
                    Console.WriteLine($"The Amount {amountw} is Withdrawn");
                    Balance -= amountw;
                }
            }

        }
        //public override void Deposit(double amountd)
        //{
        //    Transaction transfer = new Transaction($"Amount {amountd} Deposit");
        //    Transactions1.Add(transfer);
        //    TransactionTypes["Deposit"].Add(transfer);
        //    Balance += amountd * (1 + InterestRate / 100);
        //    Console.WriteLine($"The amount now deposited is {amountd}");
        //    Console.WriteLine($"The total amount after deposit and interest rate is: {Balance}");
        //}
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"The Account Holder Name:  {Name}");
            Console.WriteLine($"The Account Number:  {Account_Number}");
            Console.WriteLine($"The Account Balance: {Balance}");
            Console.WriteLine("____________________");
        }
    }
}

