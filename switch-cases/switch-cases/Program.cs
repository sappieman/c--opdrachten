using System;



namespace Switch_Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            try
            {
                number = Int32.Parse(input);
                switch (number)
                {

                    case 0:
                        Console.WriteLine("0 heeft geen waarde");
                        Console.ReadLine();
                        return;
                    case 1:
                        Console.WriteLine("1 i have a smooth brain");
                        Console.ReadLine();
                        return;
                    case 2:
                        Console.WriteLine("2 als je dit min 2 doet heb je 0");
                        Console.ReadLine();
                        return;
                    case 3:
                        Console.WriteLine("3 griekse goden Zeus, Poseidon, Hades ");
                        Console.ReadLine();
                        return;
                    case 4:
                        Console.WriteLine("4 is hoelang london brande in 1666");
                        Console.ReadLine();
                        return;
                    case 5:
                        Console.WriteLine("5 is hoeveel olympische ringen er zijn");
                        Console.ReadLine();
                        return;

                    default:
                        Console.WriteLine("Je hebt het getal " + number + " ingevuld papzak :)");
                        Console.ReadLine();
                        return;
                }
            }
            catch
            {
                Console.WriteLine("Geen Getal");
            }
            Console.Read();
        }
    }
}



