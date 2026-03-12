using System;

namespace AbstractConsole
{
    internal class Dog : AnimalClass
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
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

        /// <summary>
        /// Sound that the dog makes, overriden from AnimalClass
        /// </summary>
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
