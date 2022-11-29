using System;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            GAYDiskInfo.GetDiskInfo();
            GAYFileInfo.GetFileInfo();
            GAYDirInfo.GetDirInfo();
            GAYLog.WriteInLog();



        }
    }
}