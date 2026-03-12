using System;

namespace AbstractConsole
{
    /// <summary>
    /// Cat class
    /// </summary>
    internal class Cat : AnimalClass
    {
        /// <summary>
        /// Constructor for cat class
        /// </summary>
        /// <param name="name"></param>
        public Cat(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Initiated from the constructor or can be set outside also
        /// </summary>
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
