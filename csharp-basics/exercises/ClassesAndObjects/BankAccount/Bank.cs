using System;

namespace BankAccount
{
    class Bank
    {
        private string _name;
        private int _sign;
        private double _balance;

        public Bank(string name, double balance)
        {
            _name = name;
            _balance = balance;
            _sign = Math.Sign(balance);
        }

        public string ShowUserNameAndBalance()
        {
            if (_sign > 0)
            {
                return $"{_name}, ${_balance:F2}";
            }

            return $"{_name}, -${_balance * -1:F2}";
        }
    }
}
