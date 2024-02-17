using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsole
{
    internal abstract class AnimalClass:IAnimal
    {
        public abstract string Name { get; set; }
        public abstract string SoundName { get; set; }
        public abstract void Move(int steps);

        // virtual means can inherit if you want
        public virtual void MakeSound()
        {
            var sound = new List<string>()
            {
                SoundName,
                SoundName,
                SoundName
            };
            Console.WriteLine(string.Join(", ", sound));
        }
    }
}
