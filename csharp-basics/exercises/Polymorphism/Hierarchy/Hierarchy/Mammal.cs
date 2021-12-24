namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string animalName, string animalType,
            double animalWeight, string livingRegion, int foodEaten) : base(animalName, 
            animalType, animalWeight, foodEaten)
        {
            GetSetAnimalName = animalName;
            GetSetAnimalWeigt = animalWeight;
            GetSetRegion = livingRegion;
            _livingRegion = livingRegion;
        }

        public string GetSetRegion
        {
            get { return _livingRegion; }
            set => _livingRegion = value;
        }
    }
}
