using System;
using System.Text;


namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            GAYDiskInfo.GetDiskInfo();
           
            GAYFileInfo.GetFileInfo();
            
            GAYDirInfo.GetDirInfo();
            

            GAYFileManager.InspectDrive(@"D:\");
            GAYFileManager.CopyFiles(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\", ".txt");
            GAYFileManager.Archive(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\Archivetest",
                    @"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\Unarchivetest");
            FindInfo();
        }

        public static void FindInfo()
        {
           
            var output = new StringBuilder();

            using (var stream = new StreamReader(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\log.txt"))
            {
                var textline = "";
                var isActual = false;
                while (stream.EndOfStream == false)
                {
                    isActual = false;
                    textline = stream.ReadLine();
                    if (textline != "" && DateTime.Parse(textline).Day == DateTime.Now.Day)
                    {
                        isActual = true;
                        textline += "\n";
                        output.AppendFormat(textline);
                    }

                    textline = stream.ReadLine();
                    while (textline != "------------------------------")
                    {
                        if (isActual)
                        {
                            textline += "\n";
                            output.AppendFormat(textline);
                        }

                        textline = stream.ReadLine();
                    }

                    if (isActual) output.AppendFormat("------------------------------\n");
                }
            }

            using (var stream = new StreamWriter(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\log.txt"))
            {
                stream.WriteLine(output.ToString());
            }
        }
    } 
}