/*
 * Names: Malcolm White, Mike Fontaine, Bryce Nichol
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2024-01-29
 * Updated: 2024-01-29
 */

using System;

namespace ADEV_2008_Mod2_GroupActivity
{
    /// <summary>
    /// 
    /// </summary>
    public class SavingsBankAccount : BankAccount
    {
        private decimal interestRate;

        /// <summary>
        /// Gets and sets the interestRate.
        /// </summary>
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                this.interestRate = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="holderName"></param>
        /// <param name="balance"></param>
        /// <param name="interestRate"></param>
        public SavingsBankAccount(int accountNumber, string holderName, decimal balance, decimal interestRate)
            : base(accountNumber, holderName, balance)
        {
            InterestRate = interestRate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentException"></exception>
        public override void DepositFunds(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit must be positive.", "amount");
            }

            Balance += amount;
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
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw must be positive.", "amount");
            }
            else if (amount > Balance)
            {
                throw new ArgumentException("Amount exceeds available balance.", "amount");
            }
            Balance -= amount;
            Console.WriteLine($"You have withdrawn {amount:C} to account" +
                              $" {AccountNumber}.\nRunning Balance: {Balance:C}\n");
        }

        /// <summary>
        /// Applies interest to the bank balance.
        /// </summary>
        public void ApplyInterest()
        {
            decimal interestToApply = (InterestRate / 100) * Balance;
            Balance += interestToApply;
            Console.WriteLine($"Applied {interestToApply:C} in interest to account " +
                              $"{AccountNumber}.\nRunning balance: {Balance:C}\n");
        }

        /// <summary>
        /// Returns the string representation of the BankAccount, including the interest rate.
        /// </summary>
        /// <returns>The string representation of the BankAccount.</returns>
        public override string ToString()
        {
            return $"{base.ToString()}Interest rate: {interestRate}%\n";
        }
    }
}
