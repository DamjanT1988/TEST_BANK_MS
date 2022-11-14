using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    //step 1-5 is about make an object and defining it
    //classes have fields (properties) and methods (functions, prporties)
    //10-12 in transaction.cs - 10-18 about transactions
    public class BankAccount
    {
        //-----FIELDS (PROPERTIES) - GETTERS/SETTERS

        //1 declare public properties actually
        //(ex. template/form fields) with getters/setters 
        //string as some account numnbers have letters
        public string Number { get; }
        public string Owner { get; set; }

        //14 code getter to get balance for list
        //real properties
        public decimal Balance
        {
            get
            {
                //15 start balance at 0
                decimal balance = 0;
                //16 calculate all transactions, summarize
                foreach (var item in allTransactions)
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




        //------METHODS
        
        //3 create a constructor (ex. template or form of a bank account) for the bank account
        public BankAccount(string name, decimal initialBalance)
        {
            //4 assign methods to arguments, so it will be global access in class
            this.Owner = name;
            //this.Balance = initialBalance; --> do a deposit för 0 balance

            //29 use method MakeDeposit
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            //8 to string as some account numnbers have letters
            this.Number = accountNumberSeed.ToString();
            //9 adjust account number to new accounts by 1
            accountNumberSeed++;
        }

        
        //2-1 declare functions - methods
        //these declared can then interact
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
         /*   
            //exceptions guard the system
            //19 check of deposit is 0 or negative, if not then store the transaction/deposit
            if (amount <= 0)
            {
                //20 throw an exception (exceptional moment), otherwise stops the program as error
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive");
            }
         */

            //21 store the deposit, create a new transaction object
            var deposit = new Transaction(amount, date, note);
            //22 add to list of all transactions by Add
            allTransactions.Add(deposit);
        }



        //2-2 method
        public void MakeWithDrawal(decimal amount, DateTime date, string note)
        {
        /*
            //exceptions guard the system
            //23 check if withdrawal is 0 or negative
            if (amount <= 0)
            {
                //24 throw an exception (exceptional moment), otherwise stops the program as error
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive");
            }

            //25 check if there is balance enough for withdrawal
            if (Balance - amount <= 0)
            {
                //26 throw an exception, "invalid operations´"
                throw new InvalidOperationException("Not sufficient funds for the withdrawal1");
            }
        */

            //27 store the withdrawal, create a new transaction object
            var withdrawal = new Transaction(-amount, date, note);
            //28 update the transactions list--> 28 in bankaccount
            allTransactions.Add(withdrawal);
        }



        //35 create a log of all transactions
        public string GetAccountHistory()
        {
            //36 use a string builder, instead of using $"..."
            var report = new StringBuilder();
            //37 HEADER-make the table with AppendLine;  \t is a tab in line
            report.AppendLine("Date\t\tAmount\tNote");

            //38 go through all transaction items
            foreach (var item in allTransactions)
            {
                //39 ROWS-create the content
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            //40 return as a string
            return report.ToString();
        }
    }
}