using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public static class GAYLog
    {
        public static void WriteInLog()
        {
            string path = @"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\log.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(" ");
                writer.WriteLine($"Имя файла лога:            ");
                writer.WriteLine($"Путь лога:           {path}");
                writer.WriteLine($"Время записи лога:   {DateTime.Now}");
            }
        }

       public static void WriteInTxt(string path,string message)
        {
            
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now.ToString()}\n{message}\n------------------------------");
            }
        }
    }
}
