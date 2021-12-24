namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType,
            double animalWeight, string livingRegion, int foodEaten) : base(animalName,
            animalType, animalWeight, livingRegion, foodEaten)
        {
        }

        public override string MakeSound()
        {
            return "Scratching";
        }

        public override string ToString()
        {
            return $"{GetSetAnimalType},[{GetSetAnimalName}, " +
                   $"{GetSetAnimalWeigt}, {GetSetRegion},{GetSetFood}]";
        }

        public override bool FoodType(string foodType)
        {
            if (foodType == "Vegetable")
            {
                return true;
            }

            return false;
        }

    }
}
