using System;
using System.Collections.Generic;
using System.Text;

namespace Project_file_Assignment_2
{
    public interface IBankAccount
    {
        //Interface method is an exampole of polymorphism 
        //Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}