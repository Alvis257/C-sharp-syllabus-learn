using System;

namespace DragRace
{
    public class Bmw : Car
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 70;
        }

        public void SlowDown()
        {
            currentSpeed -= 10;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}