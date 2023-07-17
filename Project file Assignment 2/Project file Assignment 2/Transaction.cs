using System;
using System.Collections.Generic;
using System.Text;

namespace Project_file_Assignment_2
{
    public class Transaction
    {
        public String Transaction1_;
        public Transaction(string transection)
        {
            Transaction1_ = transection;
        }
        public void view()
        {
            Console.WriteLine(Transaction1_);
        }
    }
}

