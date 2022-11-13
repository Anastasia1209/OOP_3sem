using Lab08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
   class Program
    {
        static void Main(string[] args)
        {

            Director dr1 = new Director(2, 300);
            ClassEvent cl1 = new ClassEvent();
            dr1.increase += RaiseSal => Console.WriteLine(RaiseSal); 
            dr1.RaiseCategory(200);

            Director dr2 = new Director(3, 400);
            dr2.fine += DecreaseSal => Console.WriteLine(DecreaseSal);
            dr2.Decrease(200);

            Director dr3 = new Director(4, 500);
            dr3.increase += RaiseSal => Console.WriteLine(RaiseSal);
            dr3.fine += DecreaseSal => Console.WriteLine(DecreaseSal);
            dr3.RaiseCategory(300);
            dr3.Decrease(100);

        }
    }

}