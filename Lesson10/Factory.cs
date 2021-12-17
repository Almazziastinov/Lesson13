using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m
{
    
    class Factory
    {
        private Hashtable hashtable = new Hashtable();
        public int Create()
        {
            Bank bank = new Bank();
            hashtable[Bank.num] = bank;
            return Bank.num;
        }

        public int Create(int balance)
        {
            Bank bank = new Bank(balance);
            hashtable[Bank.num] = bank;
            return Bank.num;
        }

        public int Create(int balance, AccType type)
        {
            Bank bank = new Bank(balance, type);
            hashtable[Bank.num] = bank;
            return Bank.num;
        }

        public void Delete(int Id)
        {
            hashtable.Remove(Id);
        }
    }
}
