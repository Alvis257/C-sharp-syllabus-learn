using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDictionary
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

            return string.Empty;
        }

        public string GetNumber(string name)
        {
            if (_data.ContainsKey(name))
            {
                return _data[name];
            }

            return string.Empty;
        }

        public void PutNumber(string name, string number)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number))
            {
                throw new Exception("name and number cannot be null");
            }

            _data.Add(name, number);
        }

        public Dictionary<string, string> DisplayDictionary()
        {
            var newPhoneBook = new Dictionary<string, string>();
            int index = 0;

            foreach (var phoneBook in _data)
            {
                newPhoneBook.Add(phoneBook.Key, phoneBook.Value);
                index++;
            }

            return newPhoneBook.Any() ? newPhoneBook : throw new Exception("Doesn't Contain Phone Number");
        }
    }
}