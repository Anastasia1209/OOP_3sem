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

        public void Show()
        {
            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }
        }
        public void AddItem(string item)
        {
            collection.Add(item);
        }

        public static MySet operator -(MySet set1, string second)
        {
            set1.collection.Remove(second);
            return set1;
        }
        public static dynamic operator *(MySet set1, MySet set3)
        {
            var set4 = set1.collection.Intersect(set3.collection);
            return set4;
        }
        public static bool operator <(MySet set1, MySet set3)
        {
            return set1.Size < set3.Size;
        }
        public static bool operator >(MySet set1, MySet set3)
        {
            return set3.collection.IsSubsetOf(set1.collection);
        }
        public static MySet operator &(MySet set1, MySet set3)
        {
           foreach(string set5 in set1.collection)
            {
                set3.collection.Add(set5);
            }
            return set3;
        }
        public class Production
        {
            public int id;
            public string nameOrganization;
            public Production(int id, string nameOrganization)
            {
                this.id = id;
                this.nameOrganization = nameOrganization;
            }
            public void Show()
            {
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Organization: " + nameOrganization);
            }
        }
        
        public class Developer
        {
            public int id;
            public string name;
            public string department;
            public Developer(int id, string name, string dep)
            {
                this.id = id;
                this.name = name;
                this.department = dep;
            }
            public void Show()
            {
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Department: " + department);
            }
        }
    }
}
