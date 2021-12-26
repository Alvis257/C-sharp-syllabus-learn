using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Karlis", "Zarins", "lauku 19", 1);
            Student student = new Student("Karlibs", "Zariugs", "lauku 30", 2, 5.65);
            Employee employee = new Employee("Krins", "Zaugs", "lauku 15", 3, "FullStackDeveloper");
            person.Display();
            student.Display();
            employee.Display();
            Console.ReadKey();
        }
    }
}