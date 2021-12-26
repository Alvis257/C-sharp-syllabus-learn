using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    class Porche : Car
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 100;
        }

        public void SlowDown()
        {
            currentSpeed -= 20;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Brummm.....");
        }
    }
}
