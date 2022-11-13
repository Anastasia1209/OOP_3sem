using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Director
    {
        public int category;
        public int salary;
        public Director(int category, int salary)
        {
            this.category = category;
            this.salary = salary;
        }

        public void RaiseCategory(int salar)
        {
            category++;
            salary += salar;
            if (increase != null)
            {
                increase?.Invoke($"Зарплата повысилась на {salar}");
            }
        }

        public void Decrease(int salar)
        {
            salary -= salar;
            if (fine != null)
            {
                fine?.Invoke($"Зарплата уменьшилась на {salar}"); 
            }
        }

        public delegate void Increase(string sal);

        public event Increase increase;
       

        public delegate void Fine(string sal);

        public event Fine fine;

       

    }
}
