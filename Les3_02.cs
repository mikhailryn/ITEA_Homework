using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); 
            int RandomNumber = random.Next(100);
            Console.WriteLine("You have 5 attempts to guess the number");
            const int maxAttempt = 5; 
            int attempt = 0;

            while(attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine($"Try #{attempt} enter your number:" );
                int value = Convert.ToInt32(Console.ReadLine());
                
                if(value < RandomNumber)
                {
                    Console.WriteLine("Wrong! My number is bigger");
                    continue;
                }
                if (value > RandomNumber)
                {
                    Console.WriteLine("Wrong! My number is lower");
                    continue;
                }
                if (value == RandomNumber)
                {
                    Console.WriteLine("You Win");
                    Console.ReadKey();
                }
               
            }
            Console.WriteLine("You lose");
            Console.ReadKey();
        }
    }

}