using System;
using System.Collections.Generic;
using System.Text;

namespace Project_file_Assignment_2
{
    public class Bank
    {
        //The Bank class represents a collection of BankAccount objects
        //Aggregation we can say that in case of zoo as zoo was existing with habitats.
        public List<BankAccount> BankAccounts { get; set; }
        //List<BankAccount. is a list of all the bank accounts. 
        public Dictionary<string, BankAccount> Dict_BankAccounts { get; set; }
        public Bank()
        {   //In Dict_BankAccounts we are providing the parameter with the bank accounts and number so that we can acces then string.
            BankAccounts = new List<BankAccount>();
            Dict_BankAccounts = new Dictionary<string, BankAccount>();
        }
        public void AddBankAccount(BankAccount account)
        {//Adding bank accoount to list
            Dict_BankAccounts[account.Account_Number] = account;
            BankAccounts.Add(account);
            Console.WriteLine($"Acc No: {account.Name }  with {account.Account_Number} has been added.");
        }
        
        public void DepositToAccount(BankAccount acc1, double money)
        {//Finding an account out of the accounts list and deposit and amount to it via function.
            foreach (BankAccount account in BankAccounts)
            {
                if (account == acc1)
                {//Adding to the balance if account is avaiable
                    acc1.Balance += money;
                    Console.WriteLine($"The total amount deposited is:  {money}");
                    Console.WriteLine($"The total amount we got is:  {acc1.Balance}");
                }



            }
        }
        
        public void WithdrawFromAccount(BankAccount acc1, double money)
        {//Finding an account out of the accounts list and withdraw and amount to it via function.
            foreach (BankAccount account in BankAccounts)
            {
                if (account == acc1)
                {
                    acc1.Balance -= money;
                    Console.WriteLine($"The total amount withdrawn is:  {money}");
                    Console.WriteLine($"The total amount we got is:  {acc1.Balance}");
                }
                

            }
        }
        public Dictionary<string, BankAccount> GetKeyValuePairs()
        {//A dictionary for key value parameters.
            return Dict_BankAccounts;
        }


    }
}
