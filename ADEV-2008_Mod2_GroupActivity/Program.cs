/*
 * Names: Malcolm White, Mike Fontaine, Bryce Nichol
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2024-01-29
 * Updated: 2024-01-29
 */

using System;
using System.Collections.Generic;

namespace ADEV_2008_Mod2_GroupActivity
{
    public class Program
    {
        static void Main()
        {
            //Creating a List of Bank Accounts
            List<BankAccount> listOfAccounts = new List<BankAccount>();

            //Instantiating Bank Accounts 
            CheckingBankAccount accountOne = new CheckingBankAccount(144768099, "Malcolm White", 300000, 2000);
            SavingsBankAccount accountTwo = new SavingsBankAccount(400125194, "Mike Fontaine", 250000, 2.0M);

            //Adding accounts to the List
            listOfAccounts.Add(accountOne);
            listOfAccounts.Add(accountTwo);

            //Printing initial state of the accounts
            foreach (var item in listOfAccounts)
            {
                Console.WriteLine(item.ToString());
            }

            //Depositing funds in both accounts
            accountOne.DepositFunds(30000);
            accountTwo.DepositFunds(70000);

            //Withdrawing funds from both accounts
            accountOne.WithdrawFunds(100000);
            accountTwo.WithdrawFunds(20000);

            //Verifying that overdraft limit is functional
            accountOne.WithdrawFunds(30000);

            //Applying interest to the savings account
            accountTwo.ApplyInterest();

            accountOne.WithdrawFunds(201000);
            Console.ReadKey();
        }
    }
}
