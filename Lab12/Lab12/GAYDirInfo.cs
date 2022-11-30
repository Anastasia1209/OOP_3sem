using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public static class GAYDirInfo
    {
        public static void GetDirInfo()
        {
            //  string path = Path.GetFullPath(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\log.txt");
            string path = @"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\log.txt";
            string dirName = @"D:\Универ\2курс\OOP_3sem";
            string dirInfoLog = "";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            if (dirInfo.Exists)
                dirInfoLog = 
                             "\nИмя директория:           " + dirInfo.Name +
                             "\nКоличество файлов:        " + dirInfo.GetFiles().Length +
                             "\nВремя создания:           " + dirInfo.LastWriteTime +
                             "\nКол-во поддиректориев:    " + dirInfo.GetDirectories().Length +
                             "\nРодительские директории:  " + dirInfo.Parent.Name;

            GAYLog.WriteInTxt(path, dirInfoLog);
        }
    }
}