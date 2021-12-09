using System.Linq;

namespace Exercise7
{
    class Dog
    {
        private string _name { get; set; }
        private string _sex { get; set; }
        private string _mother { get; set; }
        private string _father { get; set; }

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public void FatherAndMother(Dog mother, Dog father)
        {
            _mother = mother._name;
            _father = father._name;
        }

        public string FathersName()
        {
            if (_father != null)
            {
                return $"{_father}";
            }

            return "Unknown";
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (_mother == otherDog._mother)
            {
                return true;
            }

            return false;
        }

        public string Display()
        {
            if (_father != null || _mother != null)
            {
                return $"{_name},{_sex} has a mother {_mother} has a father {_father}";
            }

            return $"{_name},{_sex}";
        }
    }
}
