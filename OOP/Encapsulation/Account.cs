namespace OOP.Encapsulation
{
    public class Account
    {
        private float _balance;

        public float Balance
        {
            get => _balance;
        }

        public void Deposit(float amount)
        {
            if (amount > 0)
                _balance += amount;
        }

        public void Withdraw(float amount)
        {
            if (amount > 0)
                _balance -= amount;
        }
    }
}