using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rose rose1 = new Rose("red", 15);
                Rose rose2 = new Rose("pink", 12);
                Rose rose3 = new Rose("white", 20);

                MySet<Rose> ros = new MySet<Rose>(3);
                ros.Add(rose1);
                ros.Add(rose2);
                ros.Add(rose3);

                ros.collection.Add(rose1);
                ros.collection.Add(rose2);
                ros.collection.Add(rose3);
                ros.InFile();


                MySet<string> set1 = new MySet<string>(1);
                set1.AddItem("Masha");
                set1.AddItem("Katya");

                MySet<string> set2 = new MySet<string>(2);
                set2.AddItem("Nastya");
                set2.AddItem("Artyom");
                set2.AddItem("Polina");
                set2.AddItem("Irina");

                MySet<string> set3 = new MySet<string>(3);
                set3.AddItem("Andrey");
                set3.AddItem("Pavel");
                set3.AddItem("Dima");

                MySet<string> set4 = new MySet<string>(4);
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

                Console.WriteLine("Id, Developer, Organization:");
                MySet<int>.Developer dev = new MySet<int>.Developer(4, "Golodok Anastasiya", "fit");
                dev.Show();

                MySet<int>.Production prod = new MySet<int>.Production(12, "BSTU");
                prod.Show();

                MySet<int> intExample = new MySet<int>(3);
                intExample.Add(6);
                MySet<double> FlExample = new MySet<double>(6);
                FlExample.Add(15.3006);
            }
            catch
            {
                Console.WriteLine("Error:(");
            }
            finally
            {
                Console.WriteLine("Все хорошо))");
            }
        }
    }
}