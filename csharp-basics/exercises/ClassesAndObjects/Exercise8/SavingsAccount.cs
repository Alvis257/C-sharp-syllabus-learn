using System;

namespace Exercise8
{
    class SavingsAccount
    {
        private double currentBalanc { get; set; }
        private double _withDrawal { get; set; }
        private double added { get; set; }
        private double _interestRate { get; set; }
        private double sumInterest { get; set; }

        public SavingsAccount(double startBalance, double interestRate)
        {
            currentBalanc = startBalance;
            _interestRate = interestRate / 12;
        }

        private double WithDrawal(double withDrawed)
        {
            _withDrawal += withDrawed;
            return currentBalanc -= withDrawed;
        }

        private double Adding(double sumAdded)
        {
            added += sumAdded;
            return currentBalanc += sumAdded;
        }

        private double Interest()
        {
            sumInterest += currentBalanc * _interestRate;
            currentBalanc += currentBalanc * _interestRate;
            return sumInterest;
        }

        public void Calculate(double withDraw, double sumAdd)
        {
            WithDrawal(withDraw);
            Adding(sumAdd);
            Interest();
        }

        public void Display()
        {
            Console.WriteLine($"Total deposited: ${Math.Round(added, 2)}");
            Console.WriteLine($"Total withdrawn: ${Math.Round(_withDrawal, 2)}");
            Console.WriteLine($"Interest earned: ${Math.Round(sumInterest, 2)}");
            Console.WriteLine($"Ending balance: ${Math.Round(currentBalanc, 2)}");
        }
    }
}
