using System;
using System.Collections.Generic;
using System.Text;

namespace Project_file_Assignment_2
{
    public class SavingsAccount : BankAccount, ITransaction
    {
        public double InterestRate { get; set; }
        public SavingsAccount(string name, string account_number, double balance, double interestrate) : base(name, account_number, balance)
        {
            InterestRate = interestrate;
        }
        public override void CalculateInterest(double amountr)
        {
            double a = amountr * (InterestRate / 100);
            Console.WriteLine($"The total amount of interest we got is {a}");
        }
        public override void Deposit(double amountd)
        {
            Transaction transfer = new Transaction($"Amount {amountd} Deposit");
            Transactions1.Add(transfer);
            TransactionTypes["Deposit"].Add(transfer);
            Balance += amountd * (1 + InterestRate / 100);
            Console.WriteLine($"The amount now deposited is {amountd}");
            Console.WriteLine($"The total amount after deposit and interest rate is: {Balance}");
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"The Account Holder Name:  {Name}");
            Console.WriteLine($"The Account Number:  {Account_Number}");
            Console.WriteLine($"The Account Balance: {Balance}");
            Console.WriteLine("____________________");
        }

    }
}

