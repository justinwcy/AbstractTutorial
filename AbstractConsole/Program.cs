using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Doggie");
            Cat cat = new Cat("Meowth");

            dog.MakeSound();
            dog.Move(3);

            cat.MakeSound();
            cat.Move(4);

            Console.ReadLine();
        }
    }
}
