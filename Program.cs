using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            kek("I:/c#/4", "I:/c#/do_4");

            void kek(string path, string dir)
            {
                string[] folders = Directory.GetDirectories(path);
                foreach (string folder in folders)
                {
                    string[] files = Directory.GetFiles(folder, "*.jpg");
                    string newFileName = "";
                    foreach (string img in files)
                    {
                        FileInfo oFileInfo = new FileInfo(img);
                        DateTime crtime = oFileInfo.CreationTime;
                        string FolderName = new DirectoryInfo(Path.GetDirectoryName(img)).Name;
                        newFileName += crtime.Year + "_" + crtime.Month + "_" + crtime.Hour + "_" + crtime.Minute + "_" + crtime.Second + "_" + FolderName + ".jpg";
                        File.Copy(img, dir + "/" + newFileName);
                    }

                }
            }
        }
    }
}
