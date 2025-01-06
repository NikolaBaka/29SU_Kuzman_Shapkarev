using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Балансът е отрицателен.");
                }
            }
        }

        // Конструктор - създава шаблона и правилата,
        // по които ще се създаде обеката
        public BankAccount(decimal initialBalance)
        {
            if (initialBalance > 0)
            {
                balance = initialBalance;
            }
            else
            {
                balance = 0;
                Console.WriteLine("The initial balance is negative. The balance is equal to 0");
            }
        }

        // Метод за въвеждане на пари в сметка

        public void deposit(decimal amount)
        {
            if(amount >= 0)
            {
                Balance = Balance + amount;
                Console.WriteLine($"Deposit money: {amount}| Balance money: {Balance} ");
            }
            else
            {
                Console.WriteLine("The amount is negative.");
            }
        }

        // Метод за изтегляне на пари от сметка
        public void withdraw (decimal amount)
        {
            if(amount <= Balance && amount >= 0)
            {
                Balance = Balance - amount;
                Console.WriteLine($"Withdraw money: {amount}| Balance money: {Balance} ");
            }
            else
            {
                if(amount < 0)
                {
                    Console.WriteLine("The amount is negative");
                }
                else
                {
                    Console.WriteLine("The amount is bigger than Balance.");
                }
            }
        }


    }
}
