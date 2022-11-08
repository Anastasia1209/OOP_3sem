using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    interface ICloneable
    {
        bool DoClone();
    }
    abstract class BaseClone
    {
        public abstract bool DoClone();
    }
    class UserClass : BaseClone, ICloneable 
    {
        public override bool DoClone()
        {
            Console.WriteLine("Клон создан успешно");
            return true;
        }
    }

    public class Printer
    {
        public string IAmPrinting(object obj)
        {
            
            if (obj is Bush)
            {
                Bush temp = (Bush)obj;
                return temp.ToString();
            }
            if (obj is Flower)
            {
                Flower temp = (Flower)obj;
                return temp.ToString();
            }
            if (obj is Cactus)
            {
                Cactus temp = (Cactus)obj;
                return temp.ToString();
            }
            if (obj is Rose)
            {
                Rose temp = (Rose)obj;
                return temp.ToString();
            }

            if (obj is Gladiolus)
            {
                Gladiolus temp = (Gladiolus)obj;
                return temp.ToString();
            }
            if (obj is Paper)
            {
                Paper temp = (Paper)obj;
                return temp.ToString();
            }
            return "";
        }
    }
}
