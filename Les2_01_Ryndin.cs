using System;

namespace Lesson2_01_Ryndin
{
    class Program
    {
        static void Main(string[] args)
        {
            int ResultOfDividing;
            int Remainder;

            int VisitorMoney = 59;

            int BeerPrice1 = 80;
            int BeerPrice2 = 70;
            int BeerPrice3 = 60;
            int BeerPrice4 = 7;

            string BeerName1 = "Leffe";
            string BeerName2 = "Hoegarden";
            string BeerName3 = "StellaArtois";
            string BeerName4 = "Obolon";

            Console.WriteLine($"У гостя {VisitorMoney} грн -> ви можете купити:");

            if (VisitorMoney >= BeerPrice1)
            {
                ResultOfDividing = VisitorMoney / BeerPrice1;
                Remainder = VisitorMoney % BeerPrice1;
                Console.WriteLine($"{ResultOfDividing} {BeerName1}, решта {Remainder}");
            }
            else if(VisitorMoney >= BeerPrice2) {
                ResultOfDividing = VisitorMoney / BeerPrice2;
                Remainder = VisitorMoney % BeerPrice2;
                Console.WriteLine($"{ResultOfDividing} {BeerName2}, решта {Remainder}");
            }
            else if(VisitorMoney >= BeerPrice3)
            {
                ResultOfDividing = VisitorMoney / BeerPrice3;
                Remainder = VisitorMoney % BeerPrice3;
                Console.WriteLine($"{ResultOfDividing} {BeerName3}, решта {Remainder}");
            }
            else if (VisitorMoney >= BeerPrice4)
            {
                ResultOfDividing = VisitorMoney / BeerPrice4;
                Remainder = VisitorMoney % BeerPrice4;
                Console.WriteLine($"{ResultOfDividing} {BeerName4}, решта {Remainder}");
            }

         
        }
    }
}
