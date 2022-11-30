using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public static class GAYFileManager
    {
        public static void InspectDrive(string driveName)
        {
            Directory.CreateDirectory(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYInspect");

            var currentDrive = DriveInfo.GetDrives().Single(x => x.Name == driveName);


            File.Create(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYInspect\GAYdirinfo.txt").Close();

            using (var streamWriter = new StreamWriter(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYInspect\GAYdirinfo.txt"))
            {
                streamWriter.WriteLine("|Directories| [");
                foreach (var directoryInfo in currentDrive.RootDirectory.GetDirectories()) streamWriter.WriteLine(directoryInfo.Name);
                streamWriter.WriteLine("]");

                streamWriter.WriteLine("|Files| [");
                foreach (var fileInfo in currentDrive.RootDirectory.GetFiles()) streamWriter.WriteLine(fileInfo.Name);
                streamWriter.WriteLine("]");
            }

            File.Copy(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYInspect\GAYdirinfo.txt",
                @"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYInspect\GAYdirinfoCopy.txt", true);
            File.Delete(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYInspect\GAYdirinfo.txt");
        }

        public static void CopyFiles(string path, string extension)
        {

            var directory = new DirectoryInfo(path);
            Directory.CreateDirectory(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYFiles");

            foreach (var file in directory.GetFiles())
                if (file.Extension == extension)
                    file.CopyTo($@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYFiles\{file.Name}", true);
            Directory.Delete(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYInspect\GAYFiles\", true);
            Directory.Move(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYFiles\",
                @"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\GAYInspect\GAYFiles\");
        }

        public static void Archive(string pathFrom, string pathTo)
        {

           /* Directory.Delete(@"D:\Универ\2курс\OOP_3sem\Lab12\Lab12\Unarchivetest\", true);*/

            if (!File.Exists($@"{pathFrom}.zip"))
                ZipFile.CreateFromDirectory(pathFrom, $@"{pathFrom}.zip");

            ZipFile.ExtractToDirectory($@"{pathFrom}.zip", pathTo);
        }
    }
}
