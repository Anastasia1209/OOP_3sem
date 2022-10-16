using System;
using System.Collections.Generic;

namespace Lab05
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

           // Bouquet bouquet = new Bouquet(20);
            Rose rose = new Rose("red", 10);
            Rose rose1 = new Rose("white", 15);
            Rose rose2 = new Rose("pink", 9);
          //  bouquet = rose as Bouquet;
            if (rose is Bouquet)
            {
                Console.WriteLine("YES!");
            }

            Gladiolus gladiolus1 = new Gladiolus(5, 6);
            Gladiolus gladiolus2 = new Gladiolus(6, 9);
            Gladiolus gladiolus3 = new Gladiolus(3, 5);

            Paper paper1 = new Paper("Organza", 3);
            Paper paper2 = new Paper("Netting", 2);
            Paper paper3 = new Paper("Felt", 4);
            Paper paper4 = new Paper("Paper", 4);

            Container bouquet1 = new Container();
            bouquet1.Add(paper1);
            bouquet1.Add(rose1);
            bouquet1.Add(rose2);
            bouquet1.Add(gladiolus1);
        }
    }
}
