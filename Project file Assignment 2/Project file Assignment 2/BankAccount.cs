using System;
using System.Collections.Generic;
using System.Text;

namespace Project_file_Assignment_2
{
    
    public abstract class BankAccount : ITransaction
    {// Declaring an abstract class BankAccount.Abstraction allows complex world concepts to be represented in a simplified manner in a program.
     // get and set used to provide the specified name to constructure.
        public string Name { get; set; }
        public string Account_Number { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions1;
        //Providing the user with list of transaction and facility to access via string.
        public Dictionary<string, List<Transaction>> TransactionTypes { get; set; }

        public BankAccount(string name, string account_number, double balance)
        {//Examples of encapsulation using it via get set to get a parameter and provide the information.
            Name = name;
            Account_Number = account_number;
            Balance = balance;
            Transactions1 = new List<Transaction>();
            Transaction transfer = new Transaction($"Amount {balance} Added as initial balance");
            Transactions1.Add(transfer);
            TransactionTypes = new Dictionary<string, List<Transaction>>();

            TransactionTypes.Add("Deposit", Transactions1);
            
        }
        //Encapsulationto protects the data from outside interference and misuse.
        public virtual void Deposit(double amountd) { }
        public virtual void Withdraw(double amountw) { }
        public virtual void ExecuteTransaction(double amount) { }
        public virtual void PrintTransaction() { }
        public void Transaction_History()
        {
            foreach (Transaction i in Transactions1)
            {
                
                i.view();
                Console.WriteLine($"The balance added to {Name} with account with {Account_Number}");
            }
        }
        //Virtual method is to allow all the subclasses to be overridden when the need of the parameter vhnages according to need
        public virtual void TakeLoan(double amountl) { }
        public virtual void CalculateInterest(double amountr) { }

        //Declaring an abstract method gives us the facility to show and call it in child classes. There is no body available in abstract class.

        public abstract void DisplayAccountInfo();
    }
}
