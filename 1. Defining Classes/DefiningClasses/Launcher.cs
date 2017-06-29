using System.Collections.Generic;
using System;

namespace DefiningClasses
{
    public class Launcher
    {
        public static void Main()
        {
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                string[] args = input.Split();
                string command = args[0];
                int accountID = int.Parse(args[1]);
                double amount = 0;

                if (args.Length > 2)
                {
                    amount = double.Parse(args[2]);
                }

                switch (command)
                {
                    case "Create":
                        Create(accountID, accounts);
                        break;

                    case "Deposit":

                        Deposit(accountID, accounts, amount);
                        break;

                    case "Withdraw":
                        amount = double.Parse(args[2]);
                        Withdraw(accountID, accounts, amount);
                        break;

                    case "Print":
                        Print(accountID, accounts);
                        break;
                }



                input = Console.ReadLine();
            }
        }

        private static void Print(int accountId, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(accountId))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine($"Account ID{accountId}, balance {accounts[accountId].Balance:F2}");
            }
        }

        private static void Withdraw(int accountId, Dictionary<int, BankAccount> accounts, double amount)
        {
            if (!accounts.ContainsKey(accountId))
            {
                Console.WriteLine("Account does not exist");
            }
            else if (accounts[accountId].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[accountId].Balance -= amount;
            }
        }

        private static void Deposit(int accountId, Dictionary<int, BankAccount> accounts, double amount)
        {
            if (!accounts.ContainsKey(accountId))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[accountId].Balance += amount;
            }
        }

        private static void Create(int accountId, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(accountId))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount currentAccount = new BankAccount();
                currentAccount.ID = accountId;
                accounts.Add(accountId, currentAccount);
            }
        }
    }
}

