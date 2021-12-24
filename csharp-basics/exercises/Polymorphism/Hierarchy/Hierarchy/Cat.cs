namespace Hierarchy
{
    class Cat : Felime
    {
        private string _breed;

        public Cat(string animalName, string animalType,
            double animalWeight, int foodEaten, string livingRegion, string breed) : base(animalName, animalType,
            animalWeight, livingRegion, foodEaten)
        {
            _breed = breed;
        }

        public string GetSetBreed
        {
            get { return _breed; }
            set => _breed = value;
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override bool FoodType(string foodType)
        {
            if (foodType == "Vegetable" || foodType == "Meat")
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{GetSetAnimalType},[{GetSetAnimalName}, " +
                   $"{GetSetBreed}, {GetSetAnimalWeigt}, {GetSetRegion}, " +
                   $"{GetSetFood}]";
        }
    }
}
