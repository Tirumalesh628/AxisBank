using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AxisBank
{
    public class Account
    {
        static int AxisAcountID = 1000;
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }

        public Account() { AccountId = AxisAcountID++; }

        public void AccountDetails()
        {
            Console.WriteLine("{0} Axis Bank account Created Succcessfully with Below details.",Name);
            Console.WriteLine("Account Number:{0}",AccountId);
            Console.WriteLine("Name:{0}",Name);
            Console.WriteLine("Address:{0}",Address);
            Console.WriteLine("Account Type:{0}",AccountType);
            Console.WriteLine("Available Balance:{0}",Balance);
        }

        public void AccountBalance()
        {
            Console.WriteLine("Available Balance:{0}",Balance);
        }

        public void withdraw(double Amount)
        {
            if(Amount<Balance)
            {
                Balance-=Amount; 
            }
            else
            {
                Console.WriteLine("Low Balance");
            }
                AccountBalance();
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                AccountBalance();
            }
            else
            {
                Console.WriteLine("Enter Correct Amount");
            }
        }

        
    }
}
