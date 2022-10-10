using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Lab03
{
    public class MySet
    {
//        private readonly Owner owner;
        public HashSet<String> collection;
        public int Size;


        public MySet(int size)
        {
            collection = new HashSet<string>();
            Size = size;
        }
        public HashSet<string> GetHash()
        {
            return collection;
        }

        public static MySet operator -(MySet first, string second)
        {
            first.collection.Remove(second);
            return first;
        }
        public static dynamic operator *(MySet first, MySet third)
        {
            var set4 = first.collection.Intersect(third.collection);
            return set4;
        }
        public static bool operator <(MySet first, MySet third)
        {
            return first.Size < third.Size;
        }
        public static bool operator >(MySet first, MySet third)
        {
            return third.collection.IsSubsetOf(first.collection);
        }
        public static MySet operator &(MySet first, MySet third)
        {
           foreach(string set5 in first.collection)
            {
                third.collection.Add(set5);
            }
            return third;
        }

    }
}
