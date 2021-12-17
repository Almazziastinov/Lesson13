using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m
{
    class BankTransaction_
    {
        readonly int Sum;
        DateTime Date;
        public BankTransaction_(int sum)
        {
            Sum = sum;
            
            Date = DateTime.Now;
            Date.ToString();

            Console.WriteLine($"Сумма {Sum},Время {Date}");
        }
        
    }
}
