using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// main changes 1
// main changes 2
// main changes 3
// main changes 4
// main changes 5
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
        public override void MakeSound()
        {
            Console.WriteLine("Dog is making a sound");
            base.MakeSound();
        }
    }
}
