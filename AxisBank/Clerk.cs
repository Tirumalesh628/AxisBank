using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBank
{
    public class Clerk
    {
        //Create Account

        //Deposit Money

        //Withdraw Money

        //Check Balance

        //Display All Accounts

        //Exitdouble Amount;
        byte clerkwork;
        double Amount;
        static int i;

        Account[] accounts = new Account[100];
        Account acc;

        public void ClearWork()
        {  
            do
            {
                
                Console.WriteLine("Choose Option to perform\n1.Create Account\n2.Deposit\n3.Withdraw\n4.CheckBalance\n5.ShowAccountDetails\n6.Diaplay All Accounts\n0.To Close Work");
                clerkwork=Convert.ToByte(Console.ReadLine());
                if (clerkwork == 1) { CreateAccount(); Console.WriteLine(); }                
                else if (clerkwork == 2) {
                    acc = GetAccountDetailswithID();
                    if (acc != null)
                    {
                        
                        Deposit(acc); Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No account available with that ID.");
                    }

                    }
                else if (clerkwork == 3) {
                    acc = GetAccountDetailswithID();
                    if (acc != null)
                    {
                        withdra(acc); Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No account available with that ID.");
                    }
                    }
                else if (clerkwork == 4) {
                    acc = GetAccountDetailswithID();
                    if (acc != null)
                    {
                        CheckBalance(acc); Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No account available with that ID.");
                    }
                }
                else if (clerkwork == 5) {
                    acc = GetAccountDetailswithID();
                    if (acc != null)
                    {
                        AccountDetails(acc); Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No account available with that ID.");
                    }
                }
                else if (clerkwork == 6) { GetAccountDetails(); Console.WriteLine(); }
                else if (clerkwork == 0) { break; }
                else Console.WriteLine("Choose correct Option");

            } while (clerkwork != 0);
        }
        public void CreateAccount()
        {
            accounts[i] = new Account();
            Console.WriteLine("Enter Account Holder Name");
            accounts[i].Name = Console.ReadLine();
            Console.WriteLine("Enter Account Holder Address");
            accounts[i].Address = Console.ReadLine();
            Console.WriteLine("Choose option for  AccountType");

            while (true)
            {
                Console.WriteLine("1.Savings Account\n2.Current Account\n3.Salary Account\n4.Fixed Deposit.");
                int option = Int32.Parse(Console.ReadLine());
                if (option == 1) { accounts[i].AccountType = "Savings Account"; break; }
                else if (option == 2) { accounts[i].AccountType = "Current Accoun"; break; }
                else if (option == 3) { accounts[i].AccountType = "Salary Account"; break; }
                else if (option == 4) { accounts[i].AccountType = "Fixed Deposit"; break; }
                else Console.WriteLine("Choose correct Option");
            }
            while (true)
            {
                Console.WriteLine("Enter Account tyep going Create 1.Zero Balance account\n2.Minimum Balance Account(1000).");
                byte accountBalanceType = byte.Parse(Console.ReadLine());
                if (accountBalanceType == 1)
                { accounts[i].Balance = 0f; break; }
                else if (accountBalanceType == 2)
                {
                    accounts[i].Balance = 1000f; break;
                }
                else
                    Console.WriteLine("Choose correct Balance Type Account");
            }

            AccountDetails(accounts[i]);
            if (i < 3)
                i++;
            else
                Console.WriteLine("Memory is full increase arrya size in this case");
        }
        public void AccountDetails(Account account) {
            account.AccountDetails();
            Console.WriteLine("-----------------------------------------------");
        }
        public void Deposit(Account account)
        {
            Console.WriteLine("Eneter Amount to deposit");
            Amount = Convert.ToDouble(Console.ReadLine());
            account.Deposit(Amount);

        }
        public void withdra(Account account)
            {
               Console.WriteLine("Eneter Amount to WithDraw");
               Amount = Convert.ToDouble(Console.ReadLine());
               account.withdraw(Amount);
         }
        public void CheckBalance(Account account)
        {
            
            account.AccountBalance();
        }
        public Account GetAccountDetailswithID()
        {
            Console.WriteLine("Enter Account ID");
            int ID=Int32.Parse(Console.ReadLine());
            for (int i=0;i<accounts.Length;i++)
            {
                if (accounts[i] != null && accounts[i].AccountId == ID)
                {
                    return accounts[i];
                    break;
                }
              
            }
            return null;
        }
        public void GetAccountDetails()
        {
            foreach (Account account in accounts)
            {
                if (account != null)
                    AccountDetails(account);
                else
                {
                    Console.WriteLine("Acounts list Ends Here");
                    break;
                }
            }

        }

    }


}
