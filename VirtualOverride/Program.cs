using System;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sif",50);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}
