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
    /// Represents a bank account.
    /// </summary>
    public abstract class BankAccount
    {
        private int accountNumber;
        private decimal balance;
        private string holderName;

        /// <summary>
        /// Gets and sets the accountNumber.
        /// </summary>
        public int AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Gets and sets the balance.
        /// </summary>
        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }

        }

        /// <summary>
        /// Gets and sets the holderName.
        /// </summary>
        public string HolderName
        {
            get
            {
                return this.holderName;
            }

            set
            {
                this.holderName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="holderName"></param>
        /// <param name="balance"></param>
        public BankAccount(int accountNumber,
                           string holderName,
                           decimal balance
                           )
        {
            AccountNumber = accountNumber;
            Balance = balance;
            HolderName = holderName;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="holderName"></param>
        public BankAccount(int accountNumber, string holderName) 
            : this(accountNumber, holderName, 0)
        {
            //Invokes BankAccount(int, string, decimal)
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public abstract void DepositFunds(decimal value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public abstract void WithdrawFunds(decimal value);
        
        /// <summary>
        /// Returns the string representation of the BankAccount.
        /// </summary>
        /// <returns>The string representation of the BankAccount.</returns>
        public override string ToString()
        {
            return string.Format("Account: {0}\nBalance: {1:C}\nHolder name: {2}\n",
                AccountNumber,
                Balance,
                HolderName);
        }
    }
}
