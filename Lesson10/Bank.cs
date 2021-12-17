using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Lesson10;

namespace m
{
    public enum AccType
    {
        current,
        Savings
    }
    [DevelopementInfo("Almaz", "KPFU")]
    class Bank
    {
        //1 задание
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"ID Аккаунта {num}");
            Console.WriteLine($"Кол-во хранящихся транзакций:{bankTransaction_s.Count}");
        }
        //конец 1 задания
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"{num}. Тип: {AccountType}, баланс: {AccBalanc}";
        }
        public static bool operator ==(Bank bank1, Bank bank2)
        {
            return bank1.AccountType == bank2.AccountType && bank1.AccBalanc == bank2.AccBalanc;
            
        }
        public static bool operator !=(Bank bank1, Bank bank2)
        {
            return bank1.AccountType != bank2.AccountType && bank1.AccBalanc != bank2.AccBalanc;
        }
        public override bool Equals(object obj)
        {
            if (obj is Bank)
            {
                return this == (obj as Bank);
            }
            else
            {
                return false;
            }
        }
        private Queue<BankTransaction_> bankTransaction_s = new Queue<BankTransaction_>();

        internal Bank()
        {
            num++;
        }

        internal Bank(int balance)
        {
            Balance = balance;
            num++;
        }
        internal Bank(AccType type)
        {
            AccountType = type;
            num++;
        }

        internal Bank(int balance, AccType type)
        {
            Balance = balance;
            AccountType = type;
            num++;

        }

        private int Balance;
        static public int num = 0;

        public int AccBalanc
        {
            get { return Balance; }
           
        }
        private AccType AccountType { get; }
        public int Num
        {
            get { return num; }
        }
        public void GetMoney(int temp)
        {
            if (temp > Balance)
            {
                Console.WriteLine("недостаточо средств");
            }
            else
            {
                Balance -= temp;
                temp.ToString();
                BankTransaction_ btrans1 = new BankTransaction_(temp);
                bankTransaction_s.Enqueue(btrans1);
                Console.WriteLine($"сумма {btrans1.SumfoRead}, Дата {btrans1.DatefoRead}");
            }
        }
        public void PutMoney(int temp)
        {
            Balance += temp;
            temp.ToString();
            BankTransaction_ btrans2 = new BankTransaction_(temp);
            bankTransaction_s.Enqueue(btrans2);
            Console.WriteLine($"сумма {btrans2.SumfoRead}, Дата {btrans2.DatefoRead}");
        }

        public void Print(Bank bank)
        {
            Console.WriteLine($"{num}, {Balance}, {AccountType}");
        }

        public void Transfer(Bank bank, int sum)
        {
            this.GetMoney(sum);
            bank.PutMoney(sum);
        }
        public async void Dispose()
        {
            List<string> transactionInfo = new List<string>();
            foreach (var item in bankTransaction_s)
            {
                transactionInfo.Add(item.ToString());
            }
            File.AppendAllLines($"report {num}.txt", transactionInfo);
            GC.SuppressFinalize(this);

        }
    }
}
