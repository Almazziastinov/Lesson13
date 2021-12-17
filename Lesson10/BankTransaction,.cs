using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m
{
    class BankTransaction_
    {
        internal int Sum;
        DateTime Date;
        private static List<BankTransaction_> Transaction_s = new List<BankTransaction_>();
        public BankTransaction_ this[int index]
        {
            get { return Transaction_s[index]; }
            set { Transaction_s[index] = value; }
        }
        public int SumfoRead
        {
            get { return Sum; }
        }
        public DateTime DatefoRead
        {
            get { return Date; }
        }

        public BankTransaction_(int sum)
        {
            Sum = sum;
            
            Date = DateTime.Now;
            Date.ToString();

            Console.WriteLine($"Сумма {Sum},Время {Date}");
        }


        public override string ToString()
        {
            return $"Сумма {Sum},Время {Date}";
        }

    }
}
