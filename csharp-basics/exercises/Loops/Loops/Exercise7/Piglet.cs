using System;

namespace Exercise7
{
    class Piglet
    {
        private static int sum = 0;
        private static Random rnd = new Random();

        public Piglet()
        {
        }

        public static int Count(bool answer)
        {
            if (answer == true)
            {
                int rndNumber = rnd.Next(1, 7);

                if (rndNumber == 1)
                {
                    sum = 0;
                    return rndNumber;
                }
                else sum += rndNumber;

                return rndNumber;
            }
            else return sum;
        }
    }
}
