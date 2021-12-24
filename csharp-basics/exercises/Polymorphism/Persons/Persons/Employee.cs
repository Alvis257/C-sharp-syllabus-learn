using System;

namespace Persons
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName,
            lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public string GetSetJobTitle
        {
            get { return _jobTitle; }
            set => _jobTitle = value;
        }

        public override void Display()
        {
            base.Display();
            Console.Write($" Job Title:{GetSetJobTitle}");
        }
    }
}
