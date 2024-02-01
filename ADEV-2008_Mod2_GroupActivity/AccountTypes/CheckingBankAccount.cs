/*
 * Names: Malcolm White, Mike Fontaine, Bryce Nichol
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2024-01-29
 * Updated: 2024-01-29
 */

using System;
using System.ComponentModel;

namespace ADEV_2008_Mod2_GroupActivity
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckingBankAccount : BankAccount
    {
        private decimal overdraftLimit;

        /// <summary>
        /// Gets and sets the overdraftLimit.
        /// </summary>
        public decimal OverdraftLimit
        {
            get
            {
                return this.overdraftLimit;
            }

            set
            {
                this.overdraftLimit = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="holderName"></param>
        /// <param name="balance"></param>
        /// <param name="overdraftLimit"></param>
        public CheckingBankAccount(int accountNumber,
                                   string holderName,
                                   decimal balance, 
                                   decimal overdraftLimit
                                   ) : base (accountNumber, holderName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentException"></exception>
        public override void DepositFunds(decimal amount)
        {
            if (amount < 0) 
            {
                throw new ArgumentException(
                          "Deposit must be positive.",
                          "value"
                          );
            }

            Balance = Balance + amount;
            Console.WriteLine($"You have deposited {amount:C} to account" +
                $" {AccountNumber}.\nRunning Balance: {Balance:C}\n");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentException"></exception>
        public override void WithdrawFunds(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(
                          "Withdraw must be positive.", 
                          "amount"
                          );
            }

            else if (amount > Balance + overdraftLimit) 
            {
                throw new ArgumentException(
                          "Overdraft limit reached.", 
                          "amount"
                          );
            }

            Balance = Balance - amount;
            Console.WriteLine($"You have withdrawn {amount:C} from account " +
                $" {AccountNumber}.\nRunning Balance: {Balance:C}\n");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}

