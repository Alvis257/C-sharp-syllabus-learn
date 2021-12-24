﻿using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal>();
            int i = 0;

            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                if (input[0].ToLower() == "end")
                {
                    break;
                }

                string animalType = input[0];
                string name = input[1];
                double animalWeight = double.Parse(input[2]);
                string livingRegion = input[3];
                int foodEaten = 0;
                string foodType = string.Empty;

                switch (animalType.ToLower())
                {
                    case "cat":
                        string breed = input[4];
                        animalList.Add(new Cat(name, animalType, animalWeight, foodEaten, livingRegion, breed));
                        break;
                    case "tiger":
                        animalList.Add(new Tiger(name, animalType, animalWeight, livingRegion, foodEaten));
                        break;
                    case "zebra":
                        animalList.Add(new Zebra(name, animalType, animalWeight, livingRegion, foodEaten));
                        break;
                    case "mouse":
                        animalList.Add(new Mouse(name, animalType, animalWeight, livingRegion, foodEaten));
                        break;
                    default:
                        Console.WriteLine("Incorrect type");
                        return;
                }

                Console.WriteLine(animalList[i].MakeSound());
                input = Console.ReadLine().Split(' ');
                foodType = input[0];
                Food food = null;

                switch (input[0].ToLower())
                {
                    case "vegetable":
                        if (animalList[i].FoodType(foodType))
                        {
                            food = new Vegetable(int.Parse(input[1]));
                            animalList[i].Eat(food);
                            Console.WriteLine(animalList[i].ToString());
                        }
                        else Console.WriteLine($"{animalList[i].GetSetAnimalName} are not eating that type of food!");

                        break;
                    case "meat":
                        if (animalList[i].FoodType(foodType))
                        {
                            food = new Meat(int.Parse(input[1]));
                            animalList[i].Eat(food);
                            Console.WriteLine(animalList[i].ToString());
                        }
                        else Console.WriteLine($"{animalList[i].GetSetAnimalName} are not eating that type of food!");

                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        return;
                }

                i++;
            }

            foreach (var animal in animalList)
            {
                Console.Write(animal.ToString());
                if (animalList.IndexOf(animal) != animalList.Count - 1)
                {
                    Console.Write(",");
                }
            }

            Console.ReadKey();
        }
    }
}