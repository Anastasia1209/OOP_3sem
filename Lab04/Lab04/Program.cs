using System;
using System.Collections.Generic;
namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bush bush = new Bush("1,5m", "Raspberry", "July-August");
            Flower flow = new Flower("yellow", "June");
            Cactus cactus = new Cactus(1500, "September");

            Plant pl = new Bush("1", "Currant", "June");
            Console.WriteLine(pl.ToString());

            Bouquet bouquet = new Bouquet(20);
            Rose rose = new Rose("red", 10);
            bouquet = rose as Bouquet;
            if (rose is Bouquet)
            {
                Console.WriteLine("YES!");
            }
        }
    }
}
