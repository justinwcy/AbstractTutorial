﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsole
{
    internal class Dog : AnimalClass
    {
        public Dog(string name)
        {
            _name = name;
        }

        private string _name;

        public override string Name
        {
            get => _name;
            set => _name = value;
        }

        public override string SoundName { get; set; } = "Woof";
        public override void Move(int steps)
        {
            Console.WriteLine($"{Name} moved by {steps} steps");
        }
    }
}
