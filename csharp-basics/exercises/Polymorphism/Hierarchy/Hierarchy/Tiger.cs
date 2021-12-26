namespace Hierarchy
{
    class Tiger : Felime
    {
        public Tiger(string animalName, string animalType,
            double animalWeight, string livingRegion, int foodEaten) : base(animalName, animalType,
            animalWeight, livingRegion, foodEaten)
        {
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }

        public override string ToString()
        {
            return $"{GetSetAnimalType},[{GetSetAnimalName}, " +
                   $"{GetSetAnimalWeigt}, {GetSetRegion},{GetSetFood}]";
        }

        public override bool FoodType(string foodType)
        {
            return foodType == "Meat";
        }
    }
}
