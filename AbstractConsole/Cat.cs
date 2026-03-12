using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsole
{
    internal class Cat:AnimalClass
    {
        public Cat(string name)
        {
            _name = name;
        }

        private string _name;

        public override string Name
        {
            get => _name;
            set => _name = value;
        }

        public override string SoundName { get; set; } = "Meow";
        public override void Move(int steps)
        {
            Console.WriteLine($"{Name} moved by {steps} steps");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat is making a sound");
            base.MakeSound();
        }
    }
}
