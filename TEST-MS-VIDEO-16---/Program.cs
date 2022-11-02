using System;

//OO-programming
namespace TEST_MS_VIDEO_16___
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 initialize new object, bank account
            var account = new BankAccount("Damjan", 500000);

            //6 write out
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
        }
    }
}