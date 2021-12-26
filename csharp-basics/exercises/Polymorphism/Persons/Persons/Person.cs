using System;

namespace Persons
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person(string firstName, string lastName, string address, int id)
        {
            _lastName = lastName;
            _firstName = firstName;
            _address = address;
            _id = id;
        }

        public string GetSetFirstName
        {
            get { return _firstName; }
            set => _firstName= value;
        }
        public string GetSetLastName
        {
            get { return _lastName; }
            set => _lastName = value;
        }
        public string GetSetAddress
        {
            get { return _address; }
            set => _firstName = value;
        }
        public int GetSeID
        {
            get { return _id; }
            set => _id = value;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name:{GetSetFirstName} Surname:{ GetSetLastName} Address:{GetSetAddress} Id:{GetSeID}");
        }
    }
}
