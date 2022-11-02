using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_MS_VIDEO_16___
{
    //step 1-5 is about make an object and defining it
    public class BankAccount
    {
        //1 declare public properties actually (ex. template/form fields) with getters & setters
        //string as some account numnbers have letters
        public string Number { get; }
        public string Owner { get; set; }
        //14 code getter to get balance for list
        public decimal Balance { get
            {
                //15 start balance at 0
                decimal balance = 0;
                //16 calculate all transactions, summarize
                foreach(var item in allTransactions)
                {
                    //17 add new transaction iten to existing balance
                    balance += item.Amount;
                }
                //18 return value to getter's caller
                return balance;
            } 
        }

        //7 private property for private number
        private static int accountNumberSeed = 1234567890;

        //13 make a new list of all transactions - have to always make a new object list
        private List<Transaction> allTransactions = new List<Transaction>();

        //3 create a constructor (ex. template or form of a bank account) for the bank account
        public BankAccount(string name)
        {
            //4 assign methods to arguments, so it will be global access in class
            this.Owner = name;
            //this.Balance = initialBalance; --> do a deposit för 0 balance

            //8 method to adjust the account number; to string as some account numnbers have letters
            this.Number = accountNumberSeed.ToString();
            //9 adjust account number to new accounts by 1
            accountNumberSeed++;
        }

        //2 declare functions - methods
        //these declared can then interact
        public void MakeDeposits (decimal amount, DateTime date, string note)
        {
            //19 check of deposit is 0 or negative, if not then store the transaction/deposit
            if(amount <= 0)
            {
                //20 throw an exception (exceptional moment), otherwise stops the program as error
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive");
            }
            //21 store the deposit as a new transaction
            var deposit = new Transaction(amount, date, note);
            //22 add to list of all transactions by Add
            allTransactions.Add(deposit);
        }

        public void MakeWithDrawal (decimal amount, DateTime date, string note)
        {
            //23 check if withdrawal is 0 or negative
            if (amount <= 0)
            {
                //24 throw an exception (exceptional moment), otherwise stops the program as error
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive");
            }

            //25 check if there is balance enough for withdrawal

        }
    }
}
