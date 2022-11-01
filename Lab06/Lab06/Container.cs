using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Container
    {
        public List<Bouquet> mainList = new List<Bouquet>();
        public List<Bouquet> List
        {
            get
            {
                return mainList;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    mainList = value;
                }
            }
        }
        public void Add(Bouquet element)
        {
            List.Add(element);
        }
        public void Remove(Bouquet element)
        {
            List.Remove(element);
        }
        public void PrintElements(Bouquet element)
        {
            foreach (Bouquet elem in List)
            {
                Console.WriteLine(elem.ToString());
            }
        }

    }
}