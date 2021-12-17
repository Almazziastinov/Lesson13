using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    class Factory
    {
        private Hashtable hashtable = new Hashtable();
        public void Create()
        {
            Bank bank = new Bank();
            hashtable[Bank.num] = bank;
        }

        public void Create(int balance)
        {
            Bank bank = new Bank(balance);
            hashtable[Bank.num] = bank;
        }

        public void Create(int balance, AccType type)
        {
            Bank bank = new Bank(balance, type);
            hashtable[Bank.num] = bank;
        }
    }
}
