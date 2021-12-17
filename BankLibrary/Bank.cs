using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankLibrary
{
    public enum AccType
    {
        current,
        Savings
    }
    class Bank
    {
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
            set { Balance = value; }
        }
        private AccType AccountType { get; set; }

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
            }
        }
        public void PutMoney(int temp)
        {
            Balance += temp;
            temp.ToString();
            BankTransaction_ btrans2 = new BankTransaction_(temp);
            bankTransaction_s.Enqueue(btrans2);
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
            string path = @"C:\SomeDir3";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            for (int i = 0; i < bankTransaction_s.Count; i++)
            {
                //using (FileStream fstream = new FileStream($"{path}\note.txt", FileMode.OpenOrCreate))
                //{
                //    byte[] array = Encoding.Default.GetBytes(item);
                //    // асинхронная запись массива байтов в файл
                //    await fstream.WriteAsync(array, 0, array.Length);
                //}

                var queueElement = bankTransaction_s.Dequeue(); //теперь очередь 5, 8
                Console.WriteLine(queueElement);
            }



        }
    }
}
