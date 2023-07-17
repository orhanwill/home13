using System;
using System.Collections.Generic;
using System.Text;

namespace Project_file_Assignment_2
{
    public interface ITransaction
    {
        void ExecuteTransaction(double amount);
        void PrintTransaction();
    }
}