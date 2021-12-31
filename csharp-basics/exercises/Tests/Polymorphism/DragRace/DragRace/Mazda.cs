using System;

namespace DragRace
{
    public class Mazda : Car, Boost
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 50;
        }

        public void SlowDown()
        {
            currentSpeed -= 20;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 100;
        }

        public string StartEngine()
        {
            return "Vrum....Vrum....";
        }
    }
}
