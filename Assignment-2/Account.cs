using System;

namespace AccountClass
{
    using System;

    class Account
    {
        public string accountNumber;
        public string accountHolder;
        public double balance; 

        public Account(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        public virtual void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited {0} into account {1}. New balance: {2}", amount, accountNumber, balance);
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn {0} from account {1}. New balance: {2}", amount, accountNumber, balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds in account {0}", accountNumber);
            }
        }
    }

    class SavingsAccount : Account
    {
        public double interestRate;

        public SavingsAccount(string accountNumber, string accountHolder, double balance, double interestRate)
            : base(accountNumber, accountHolder, balance)
        {
            this.interestRate = interestRate;
        }

        public void CalculateInterest()
        {
            double interest = balance * interestRate / 100;
            Console.WriteLine("Interest : "+ interest);

        }
    }

    class CheckingAccount : Account
    {
        public double overdraftLimit;

        public CheckingAccount(string accountNumber, string accountHolder, double balance, double overdraftLimit)
            : base(accountNumber, accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= balance + overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn {0} from account {1}. New balance: {2}", amount, accountNumber, balance);
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeds overdraft limit for account {0}", accountNumber);
            }
        }
    }

}
