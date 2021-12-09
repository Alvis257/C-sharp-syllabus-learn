using System;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male");
            Dog rocky = new Dog("Rocky", "male");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog coco = new Dog("Coco", "female");

            max.FatherAndMother(lady, rocky);
            coco.FatherAndMother(molly, buster);
            rocky.FatherAndMother(molly, sam);
            buster.FatherAndMother(lady, sparky);

            Console.WriteLine(max.Display());
            Console.WriteLine(lady.Display());
            Console.WriteLine($"Coco has as father {coco.FathersName()}");
            Console.WriteLine($"Molly has a father {molly.FathersName()}");
            Console.WriteLine($"Max has the same mother as Buster :{max.HasSameMotherAs(buster)}");
            Console.WriteLine($"Lady has the same mother as Rocky :{lady.HasSameMotherAs(rocky)}");

            Console.ReadKey();
        }
    }
}
