using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class MyException : System.Exception
    {
        public string ErrorClass { get; set; }
        public MyException(string message, string errorClass)
            : base(message)  // наследуем message от System.Exception
        {
            this.ErrorClass = errorClass;
        }
    }

    public class CostException : MyException
    {

        public int Cost { get; set; }
        public CostException(string message, int errorCost)
            : base(message, "Error code 1: Uncorrect cost.\n")  // наследуем message и errorClass от MyException
        {

            this.Cost = errorCost;
        }
    }
    public class ColorException : MyException
    {

        public string Color { get; set; }
        public ColorException(string message, string errorColor)
            : base(message, "Error code 1: Uncorrect color.\n")  // наследуем message и errorClass от MyException
        {

            this.Color = errorColor;
        }
    }
    public class NumException : MyException
    {

        public int Num { get; set; }
        public NumException(string message, int errorNum)
            : base(message, "Error code 1: Uncorrect number.\n")  // наследуем message и errorClass от MyException
        {

            this.Num = errorNum;
        }
    }
    public class TypeException : MyException
    {

        public int Type { get; set; }
        public TypeException(string message, int errorType)
            : base(message, "Error code 1: Uncorrect type.\n")  // наследуем message и errorClass от MyException
        {

            this.Type = errorType;
        }
    }
    public class ConsoleLogger
    {
        public ConsoleLogger() { }
        public void WriteLog(MyException exception)
        {
            CostException CostEx = exception as CostException;
            ColorException ColorEx = exception as ColorException;
            NumException NumEx = exception as NumException;
            TypeException TypeEx = exception as TypeException;

            Console.WriteLine("\n" + DateTime.Now);
            if (CostEx != null)
            {
                Console.WriteLine("{0}{1} {2}", CostEx.ErrorClass, CostEx.Message, CostEx.Cost);
            }
            if (ColorEx != null)
            {
                Console.WriteLine("{0}{1} {2}", ColorEx.ErrorClass, ColorEx.Message, ColorEx.Color);
            }
            if (NumEx != null)
            {
                Console.WriteLine("{0}{1} {2}", NumEx.ErrorClass, NumEx.Message, NumEx.Num);
            }
            if (TypeEx != null)
            {
                Console.WriteLine("{0}{1} {2}", TypeEx.ErrorClass, TypeEx.Message, TypeEx.Type);
            }
        }
    }

    public class FileLogger
    {
        public FileLogger() { }
        public void WriteLog(MyException exception)
        {
            CostException CostEx = exception as CostException;
            ColorException ColorEx = exception as ColorException;
            NumException NumEx = exception as NumException;
            TypeException TypeEx = exception as TypeException;

            string filePath = @"D:\Универ\2курс\OOP_3sem\Lab06\Lab06\log.txt";
            using StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default);
            streamWriter.WriteLine(DateTime.Now);
            if (CostEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", CostEx.ErrorClass, CostEx.Message, CostEx.Cost); ;
            }
            if (ColorEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", ColorEx.ErrorClass, ColorEx.Message, ColorEx.Color);
            }
            if (NumEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", NumEx.ErrorClass, NumEx.Message, NumEx.Num);
            }
            if (TypeEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", TypeEx.ErrorClass, TypeEx.Message, TypeEx.Type);
            }
        }
    }
    public class Num
    {
        public int num { get; set; }
        public Num(int num)
        {
            this.num = num;
        }
        public Num Namnamnam()
        {
            try
            {
                if (!(this.num is int))
                {
                    throw new MyException("Incorrect type", "Error code 5: Uncorrect type.\n");
                }

                return this;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Omnomnom()
        {
            try
            {
                if (Convert.ToInt32(this.Namnamnam()) is int)
                {
                    return Convert.ToInt32(this.Namnamnam());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "impossible convert to int\n");
                return 0;
            }
        }
    }
}