using System;

namespace Gæt_et_tal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int i = 0;
            Console.WriteLine("Guess the number");
            int guess = int.Parse(Console.ReadLine());
            while (true)
            {
                if (guess == randomNumber)
                {
                    Console.WriteLine("Congrats you gussed it in " + i + " tries");
                    break;
                }
                else if (guess >= randomNumber)
                {
                    Console.WriteLine("You guess was too high");
                    i++;
                    guess = int.Parse(Console.ReadLine());
                }
                else if (guess <= randomNumber)
                {
                    Console.WriteLine("You guess was too low");
                    i++;
                    guess = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
