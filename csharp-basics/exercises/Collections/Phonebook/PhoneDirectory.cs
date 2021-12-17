using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private Dictionary<string, string> _data = new Dictionary<string, string>();
        private string _name;
        private string _number;

        public string GetName(string number)
        {
            if (_data.ContainsValue(number))
            {
                foreach (var name in _data.Keys)
                {
                    if (_data[name] == number)
                    {
                        return name;
                    }
                }
            }

            return null;
        }

        public string GetNumber(string name)
        {
            if (_data.ContainsKey(name))
            {
                return _data[name];
            }

            return null;
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            _data.Add(name, number);
        }

        public void DisplayDictionary()
        {
            Console.WriteLine("Phones numbers:");

            foreach (var phoneBook in _data)
            {
                Console.WriteLine(phoneBook);
            }
        }
    }
}