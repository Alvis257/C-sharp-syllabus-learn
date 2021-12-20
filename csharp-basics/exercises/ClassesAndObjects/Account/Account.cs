namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double balance)
        {
            _name = name;
            _money = balance;
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }

        private double Withdrawal(double i)
        {
            _money -= i;
            return _money;
        }

        private void Deposit(double i)
        {
            _money += i;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
