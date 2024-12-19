namespace Day08
{
    public class Account
    {
        private int accountId;
        private string accountHolder;
        private decimal balance;

        public Account(int id, string holder, decimal initialBalance)
        {
            accountId = id;
            accountHolder = holder;
            balance = initialBalance;
        }

        public int AccountId => accountId;
        public string AccountHolder => accountHolder;
        public decimal Balance => balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
    }
}
