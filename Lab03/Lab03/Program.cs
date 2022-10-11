using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab03.MySet;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            MySet set1 = new MySet(1);
            set1.AddItem("Masha");
            set1.AddItem("Katya");

            MySet set2 = new MySet(2);
            set2.AddItem("Nastya");
            set2.AddItem("Artyom");
            set2.AddItem("Polina");
            set2.AddItem("Irina");

            MySet set3 = new MySet(3);
            set3.AddItem("Andrey");
            set3.AddItem("Pavel");
            set3.AddItem("Dima");

            MySet set4 = new MySet(4);
            set4.AddItem("Yana");
            set4.AddItem("");
            set4.AddItem("Yura");

            Console.WriteLine("Перегрузка оператора -");
            string name = "Artyom";
            set2 = set2 - name;
            set2.Show();

            Console.WriteLine("Перегрузка оператора *");
            set2 = set2 * set1;
            set2.Show();

            Console.WriteLine("Перегрузка оператора <");
            Console.WriteLine(set2 < set1);

            Console.WriteLine("Перегрузка оператора >");
            Console.WriteLine(set2 > set1);

            Console.WriteLine("Перегрузка оператора &");
            set3 = set3 & set1;
            set3.Show();

            Console.WriteLine("Разница между максимальным и минимальным");
            set3.Show();
            int a = set3.DiffMaxMin();
            Console.WriteLine(a);


            Console.WriteLine("Id, Developer, Organization:");
            Developer dev = new Developer(4, "Golodok Anastasiya", "fit");
            dev.Show();

            Production prod = new Production(12, "BSTU");
            prod.Show();



        }
    }
}
