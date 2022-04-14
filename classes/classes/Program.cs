using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            float Number1 = 23;
            float Number2 = 16;

            Rekenmachine rekenmachine = new Rekenmachine();
            rekenmachine.keer(Number1, Number2);
            rekenmachine.delen(Number1, Number2);
            rekenmachine.plus(Number1, Number2);
            rekenmachine.min(Number1, Number2);

            Console.WriteLine(Number1 + " x " + Number2 + " = " + rekenmachine.keer(Number1, Number2));
            Console.WriteLine(Number1 + " / " + Number2 + " = " + rekenmachine.delen(Number1, Number2));
            Console.WriteLine(Number1 + " + " + Number2 + " = " + rekenmachine.plus(Number1, Number2));
            Console.WriteLine(Number1 + " - " + Number2 + " = " + rekenmachine.min(Number1, Number2));


        }
    }






internal class Rekenmachine
    {
       public float keer(float Number1, float Number2)
        {
          float Antwoord;
          Antwoord = Number1 * Number2;
          return Antwoord;
        }
        public float delen(float Number1, float Number2)
        {
         float Antwoord;
         Antwoord = Number1 / Number2;
         return Antwoord;
        }
        public float plus(float Number1, float Number2)
        {
         float Antwoord;
         Antwoord = Number1 + Number2;
         return Antwoord;
            }
        public float min(float Number1, float Number2)
        {
           float Antwoord;
           Antwoord = Number1 - Number2;
            return Antwoord;
        }
    }
}

