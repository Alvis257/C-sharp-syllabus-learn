namespace Hierarchy
{
    public abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeigth;
        private int _foodEaten;

        public Animal(string animalName,
            string animalType, double animalWeigth, int foodEaten)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeigth = animalWeigth;
            _foodEaten = foodEaten;
        }

        public string GetSetAnimalName
        {
            get { return _animalName; }
            set => _animalName = value;
        }

        public string GetSetAnimalType
        {
            get { return _animalType; }
            set => _animalType = value;
        }

        public double GetSetAnimalWeigt
        {
            get { return _animalWeigth; }
            set => _animalWeigth = value;
        }

        public int GetSetFood
        {
            get { return _foodEaten; }
            set => _foodEaten = value;
        }

        public abstract string MakeSound();

        public virtual int Eat(Food food)
        {
            return GetSetFood = food.GetSetQuantaty;
        }

        public abstract bool FoodType(string foodType);
        public abstract string ToString();
    }
}
