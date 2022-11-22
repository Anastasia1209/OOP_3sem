using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.ComponentModel;

namespace Lab07
{
    public interface ICollection<T>
    {
        List<T> Add(T item);
        List<T> Delete(T item);
        void Check();
    }
    public class MySet<T> :ICollection<T>
    {
        public List<T> list = new List<T>();
        public List<T> Add(T item)
        {
            list.Add(item);
            return list;
        }
        public List<T> Delete(T item)
        {
            list.Remove(item);
            return list;
        }
        public void Check()
        {
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
        }


        public HashSet<T> collection;
        public int Size;

        public MySet(int size)
        {
            collection = new HashSet<T>();
            Size = size;
        }
        public HashSet<T> GetHash()
        {
            return collection;
        }

        public void Show()
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
        public void AddItem(T item)
        {
            collection.Add(item);
        }

        // Получение элемента множества по индексу
        public string GetItemByIndex(int index)                     
        {
            int count = 0;
            foreach (T temp in collection)
            {
                if (count == index) return Convert.ToString(temp);
                count++;
            }

            return "Index out of range";
        }

        //перегрузки
        public static MySet<T> operator -(MySet<T> set1, T second)
        {
            set1.collection.Remove(second);
            return set1;
        }
        public static dynamic operator *(MySet<T> set1, MySet<T> set3)
        {
            var set4 = set1.collection.Intersect(set3.collection);
            return set4;
        }
        public static bool operator <(MySet<T> set1, MySet<T> set3)
        {
            return set1.Size < set3.Size;
        }
        public static bool operator >(MySet<T> set1, MySet<T> set3)
        {
            return set3.collection.IsSubsetOf(set1.collection);
        }
        public static MySet<T> operator &(MySet<T> set1, MySet<T> set3)
        {
           foreach(T set5 in set1.collection)
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
        public void InFile()
        {
            string path = @"D:\Универ\2курс\OOP_3sem\Lab07\Lab07\lab7.txt";
            using StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(Size);
            foreach(T item in collection)
            {
                writer.Write(item + " ");
            }
            writer.WriteLine();
            foreach (T temp in list)
            {
                writer.Write(temp + " ");
            }
        }
        public MySet<T> GetFile()
        {
            string path = @"D:\Универ\2курс\OOP_3sem\Lab07\Lab07\lab7.txt";
            using StreamReader reader = new StreamReader(path);
            string? line;
            line = reader.ReadLine();
            string[] arr = line.Split(' ');
            MySet<T> set = new MySet<T>(Convert.ToInt32(Size));
            line = reader.ReadLine();
            string[] arr1 = line.Split(' ');
            for (int i = 0; i < arr1.Length; i++)
            {
                T tmp = (T)Convert.ChangeType(arr1[i].GetType(), list.GetType());
                set.Add(tmp);
            }
            line = reader.ReadLine();
            string[] arr2 = line.Split(' ');
            for (int i = 0; i < arr2.Length; i++)
            {
                T tmp = (T)Convert.ChangeType(arr2[i].GetType(), list.GetType());
                set.Add(tmp);
            }
            return set;
        }
    }
}
