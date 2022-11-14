using Lab09;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace lab09
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Hashtable hashtable = new Hashtable();
            hashtable.Add(12, "aaa");
            Console.WriteLine(hashtable[12]);
            hashtable.Add(6, 'k');
            Console.WriteLine(hashtable[6]);
            hashtable.Add(12.6, true);
            Console.WriteLine(hashtable[12.6]);
            hashtable.Add("rr", false);
            Console.WriteLine(hashtable["rr"]);

            Console.WriteLine("-------------------");

            ArrayList arr = new ArrayList();
            arr.Add(hashtable[12]);
            arr.Add(hashtable[6]);
            arr.Add(hashtable[12.6]);
            arr.Add(hashtable["rr"]);
            foreach(var temp in arr)
            {
                Console.WriteLine(temp);
            }

            string str = "aaa";
            Console.WriteLine("Содержит ли ArrayList заданное значение " + arr.Contains(str));

            Console.ForegroundColor = ConsoleColor.Yellow;
            var myCollection = new ObservableCollection<Worker>();
            myCollection.CollectionChanged += SayChange;


            myCollection.Add(new Worker("600$", "1 year"));
            myCollection.Add(new Worker("1000$", "2 year"));
            myCollection.Add(new Worker("100000000$", "15 year"));

            myCollection.RemoveAt(2);

        }
        private static void SayChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine("|Add complete|");
            else if (e.Action == NotifyCollectionChangedAction.Remove) Console.WriteLine("|Remove complete|");
        }
    }
}