namespace DragRace
{
    public class Audi : Car
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 70;
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
            return "Rrrrrrr.....";
        }
    }
}