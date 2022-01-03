using System;

namespace DragRace
{
    public class Tesla : Car
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 80;
        }

        public void SlowDown()
        {
            currentSpeed -= 40;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "-- silence ---";
        }
    }
}