using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsole
{
    internal interface IAnimal
    {
       
        string Name { get; set; }
        string SoundName { get; set; }

        void Move(int steps);
        void MakeSound();

    }
}
