using BankLibrary;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //small test
            Assert.True(true);
        }


        [Fact]
        public void Test2()
        {

            //1 initiate object
            var account = new BankAccount("Damjan", 500000);

            //2 test for negative balance; if test OK -> too much withdraw
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithDrawal(100000000, DateTime.Now, "Tesla car")
                );
        }

        [Fact]
        public void Test3()
        {
            //3 test for initial balance; if test OK -> 0 or negatice balance
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("invalid", -55)
                );

        }
    }
}