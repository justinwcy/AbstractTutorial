using System;

namespace AbstractConsole
{
    /// <summary>
    /// Cat class
    /// </summary>
    internal class Cat : AnimalClass
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
