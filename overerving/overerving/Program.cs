using System;

namespace Overerving
{
    class Animal
    {
        public void feed()
        {
            Console.WriteLine("chappings");
        }
    }
    class horse : Animal
    {
        public string ras = "Arabier";
    }
    class horseeat
    {
        static void Main(string[] args)
        {
            horse myanimal = new horse();
            myanimal.feed();
        }

    }
}