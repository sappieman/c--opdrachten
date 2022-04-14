using System;

namespace functies_return
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ProgramInstance = new Program();

            int num3 = ProgramInstance.Add(12, 37);
            Console.WriteLine(num3);

        }
       
        private int Add(int num1, int num2)
        {
            
            
            int num3 = num1 + num2;
            return num3;
        }
    }
}
