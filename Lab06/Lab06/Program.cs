using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            try
            {
                Rose ros = new Rose("purple", 10);
                Rose ros1 = new Rose("white", 15);
                Rose ros2 = new Rose("pink", 9);
                if (ros is Bouquet)
                {
                    Console.WriteLine("YES!");
                }

                Gladiolus glad1 = new Gladiolus(5, 6);
                Gladiolus glad2 = new Gladiolus(6, 9);
                Gladiolus glad3 = new Gladiolus(9, 5);

                Paper pap1 = new Paper("cellophane", 3);
                Paper pap2 = new Paper("Netting", 2);
                Paper pap3 = new Paper("Felt", 4);
                Paper pap4 = new Paper("Paper", 4);

                Container bouq1 = new Container();
                bouq1.Add(pap1);
                bouq1.Add(ros1);
                bouq1.Add(ros2);
                bouq1.Add(glad1);
            }
            catch(MyException ex)
            {
                fileLogger.WriteLog(ex);
            }
            finally
            {
                Console.WriteLine("Программа завершена успешно!!");
            }

            try
            {
                int x = 5, y = 0;
                int c = x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }

            try
            {
                int[] arr = new int[8];
                arr[10] = 10;
            }
            catch (Exception e) when (e.Source != "Lab06")
            {
                Console.WriteLine("ок\n");
            }
            catch
            {
                Console.WriteLine("Ошиииибка:(" + "\n");
            }

        }
    }
}