using System;
using System.Collections.Generic;
using System.Text;

namespace Project_file_Assignment_2
{
    public class LoanAccount : BankAccount, ITransaction
    {
        public double LoanDuration { get; set; }
        public double InterestRate { get; set; }
        public double LoanAmount { get; set; }
        double a = 0;
        public LoanAccount(string name, string account_number, double balance, double interestrate, double loanduration) : base(name, account_number, balance)
        {
            InterestRate = interestrate;
            LoanDuration = loanduration;
        }
        public override void TakeLoan(double amountl)
        {
            LoanAmount += amountl;
            Console.WriteLine($"The amount of loan {amountl} is intiated.");
        }
        public override void Deposit(double amountd)
        {

            LoanAmount -= amountd;
            Console.WriteLine($"The amount now deposited after loan is {amountd}");
            Console.WriteLine($"The total loan amount after deposit  is: {LoanAmount}");
        }
        public override void Withdraw(double amountw)
        {

            LoanAmount += amountw;
            Console.WriteLine($"The amount now withdrawn after loan is {amountw}");
            Console.WriteLine($"The total loan amount after withdraw  is: {LoanAmount}");
        }
        public override void ExecuteTransaction(double amountt)
        {
            Console.WriteLine($"The transaction amount of {amountt } is executed");
        }
        public override void PrintTransaction()
        {
            Console.WriteLine($"Your Transaction has been done.");
        }
        public override void CalculateInterest(double amountr)
        {
            double a = amountr * (InterestRate / 100);
            Console.WriteLine($"The total amount of interest we got is {a}");
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"The Account Holder Name:  {Name}");
            Console.WriteLine($"The Account Number:  {Account_Number}");
            Console.WriteLine($"The Account Balance: {Balance}");
            
            Console.WriteLine($"Total Loan due is " + (a + LoanAmount));

            Console.WriteLine("Your Account is Loan Account.");
            Console.WriteLine("____________________");
        }

    }
}

