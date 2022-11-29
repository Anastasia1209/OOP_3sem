using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public static class GAYFileInfo
    {
        public static void GetFileInfo()
        {

            //  string path = Path.GetFullPath(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\log.txt");
            string path = @"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\log.txt";
            string fileInfoLog = "";

            FileInfo fileInf = new FileInfo(path);

            if (fileInf.Exists)
            {
                fileInfoLog = 
                    "\nПолный путь:       " + path +
                    "\nРазмер:            " + fileInf.Length +
                    "\nРасширение:        " + fileInf.Extension +
                    "\nИмя файла:         " + fileInf.Name +
                    "\nВремя изменения:   " + fileInf.CreationTime;
            }
            GAYLog.WriteInTxt(path, fileInfoLog);
        }

    }
}
