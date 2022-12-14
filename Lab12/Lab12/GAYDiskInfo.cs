using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab12
{
    public static class GAYDiskInfo
    {
        public static void GetDiskInfo()
        {
           
            string diskInfo = "";
            string path = @"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\log.txt";

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach(DriveInfo drive in drives)
            {
                diskInfo =
                    "\nНазвание: " + drive.Name +
                    "\nОбъем: " + drive.TotalSize +
                    "\nДоступный объем: " + drive.TotalFreeSpace +
                    "\nМетка тома: " + drive.VolumeLabel +
                    "\nФайловая система: " + drive.DriveFormat;

            GAYLog.WriteInTxt(path, diskInfo);
            }
        }
    }
}
