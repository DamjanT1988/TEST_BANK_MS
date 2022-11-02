using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_MS_VIDEO_16___
{
    public class Transaction
    {
        //10 declare properties for class
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }


        //11 declare class object with constructor
        public Transaction(decimal amount, DateTime date, string note)
        {
            //12 assign property to arguments
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
