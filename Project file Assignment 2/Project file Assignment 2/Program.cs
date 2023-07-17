using System;

namespace Project_file_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            SavingsAccount savingaccount = new SavingsAccount("Shoaib", "414862", 20000, 10);
            bank.AddBankAccount(savingaccount);
            savingaccount.Deposit(2000); 
            
            savingaccount.DisplayAccountInfo();
            


            CheckingAccount checkingaccount = new CheckingAccount("Shoaib", "512520", 25000, 12);
            bank.AddBankAccount(checkingaccount);
            bank.DepositToAccount(checkingaccount, 2500);
            bank.WithdrawFromAccount(checkingaccount, 3500);
            checkingaccount.Transaction_History();
            checkingaccount.DisplayAccountInfo();
           

            LoanAccount loanaccount = new LoanAccount("Zeeshan", "4563241", 20000, 11, 3);
            bank.AddBankAccount(loanaccount);
            loanaccount.TakeLoan(10000);
            loanaccount.ExecuteTransaction(10000);
            loanaccount.PrintTransaction();
            loanaccount.CalculateInterest(10000);
            loanaccount.DisplayAccountInfo();

            loanaccount.Transaction_History();
            
        }
    }
}
