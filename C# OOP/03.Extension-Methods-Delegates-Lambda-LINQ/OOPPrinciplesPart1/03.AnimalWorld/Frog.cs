﻿namespace _03.AnimalWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Frog : Animal
    {
        public Frog(string name, int age, bool isMale)
        {
            base.Name = name;
            base.Age = age;
            base.IsMale = isMale;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Croak");
        }
    }
}
