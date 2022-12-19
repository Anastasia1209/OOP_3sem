using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Flower
    {
        public string id;
        public string type;
        public string color;
        public int price;

        public static int countOfFlowers;

        static Flower()
        {
            countOfFlowers = 0;
        }

        public Flower(string id, string type, string color, int price)
        {
            this.id = id;
            this.type = type;
            this.color = color;
            this.price = price;
            Flower.countOfFlowers++;
        }

        public Flower()
        {
            id = "Undefined";
            type = "Undefined";
            color = "Undefined";
            price = 0;
            Flower.countOfFlowers++;
        }

        public static void InformationClass()
        {
            Console.WriteLine($" - - - - - Information of Class - - - - - - - ");
            Console.WriteLine($"Count flowers: {Flower.countOfFlowers}");

        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            {
                Flower flower = (Flower)obj;
                return  (color == flower.color) && (type == flower.type);
            }
        }

        public override string ToString()
        {
            return  "Type: " + type + ", Color: " + color;
        }

        public void WriteFlower(string typeFlower, Flower[] FLowerColection)
        {
            for (int i = 0; i < FLowerColection.Length; i++)
            {
                if (FLowerColection[i].type == typeFlower)
                {
                    Console.WriteLine($"{i + 1} flower: {FLowerColection[i].ToString()}");
                }
            }
        }

        public void WriteFlower(int temp, string type, Flower[] FLowerColection)
        {
            for (int i = 0; i < FLowerColection.Length; i++)
            {
                if (FLowerColection[i].type == type)
                {
                    if (FLowerColection[i].GetPrice() > temp)
                    {
                        Console.WriteLine($"{i + 1} car: {FLowerColection[i].ToString()}");
                        Console.WriteLine($"Term of operation: {FLowerColection[i].GetPrice()}");
                    }
                }
            }
        }

        public int GetPrice()
        {
            return  this.price - 10;
        }
    }
}
