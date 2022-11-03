using System;
using BankLibrary;
using Humanizer;

//OO-programming
namespace TEST_MS_VIDEO_16___
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----CREATE A NEW BANK ACCOUNT

            //5 initialize new object, bank account
            var account = new BankAccount("Damjan", 500000);
            //6 write out
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            //30 make a  test, call MakeWithDrawal method from BankAccount class
            account.MakeWithDrawal(500, DateTime.Now, "Protein");

            //31 check the current balance
            Console.WriteLine(account.Balance);

            //41 print the account history by callong method in object
            Console.WriteLine(account.GetAccountHistory());

            //-----TEST

            //32 test the program, with exception the program continues in spite of error
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            //33 catch errors, e is target, in the catch code block
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }


            //34 test of withdrawal (too much)
            try
            {
                account.MakeWithDrawal(1000000, DateTime.Now, "Tesla car");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught withdrawing too much funds/not enough balance");
                Console.WriteLine(e.ToString());
            }
            


            //-----DOTNET

            //DOTNET 1-humanizer package code ex Pluralize()-- NuGet
            Console.WriteLine("car".Pluralize());
            Console.WriteLine("bus".Pluralize());
            Console.WriteLine(666.ToWords());


            //41 DOTNET-videos
            account.MakeWithDrawal(500, DateTime.Now, "Protein2");
            account.MakeWithDrawal(500, DateTime.Now, "Protein3");
            account.MakeWithDrawal(500, DateTime.Now, "Protein4");
            account.MakeWithDrawal(50000, DateTime.Now, "Protein5");
            account.MakeWithDrawal(500, DateTime.Now, "Protein6");
        }
    }
}