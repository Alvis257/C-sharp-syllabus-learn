using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sounds = new List<ISound> {new Firework(), new Radio(), new Parrot()};

            foreach (var sound in sounds)
            {
                sound.PlaySound();
            }

            Console.WriteLine();
        }
    }
}