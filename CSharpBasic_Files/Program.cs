using System;
using System.IO;

namespace CSharpBasic_Files
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //File
            var filePath = @"/Users/kevinvong/Desktop/Visual Studio/CSharpBasic/CSharpBasic_Files/myTextFile.txt";

            //File.Create(filePath);//Can't use this code and Append/ other reader at same time
            //File.Copy(path, path);//can't copy to itself
            var text = File.ReadAllText(filePath);
            File.Delete(filePath);//delete path
            Console.WriteLine(File.Exists(filePath));
            File.AppendAllText(filePath,text + " right");
            Console.WriteLine(File.Exists(filePath));

            //FileInfo
            var fileInfo = new FileInfo(filePath);
            //fileInfo.CopyTo(path,true);//can't copy to itself
            if (fileInfo.Exists)
            {
                //fileInfo.Delete();//delete self
            }else
            {
				fileInfo.Create();
            }
            Console.WriteLine();

            //Directory
            var directoryPath = @"/Users/kevinvong/Desktop/Visual Studio/CSharpBasic/CSharpBasic_Files/folder1";
            var directoryPath2 = @"/Users/kevinvong/Desktop/Visual Studio/CSharpBasic/CSharpBasic_Files";
            Directory.CreateDirectory(directoryPath);
            var files = Directory.GetFiles(directoryPath2,"*.*",SearchOption.TopDirectoryOnly);
            foreach (var path in files)
            {
                Console.WriteLine("path : " + path);
            }
            Directory.Delete(directoryPath);
            var directories = Directory.GetDirectories(directoryPath2, "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine("directory : " + directory);
            }

            //DirectoryInfo
            var directoryInfo = new DirectoryInfo(directoryPath2);
            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine("file : " + file);
            }
            foreach (var directory in directoryInfo.GetDirectories())
            {
                Console.WriteLine("directory : " + directory);
            }

            //Path
            var path2 = @"/Users/kevinvong/Desktop/Visual Studio/CSharpBasic/CSharpBasic_Files/myTextFile2.txt";
            Console.WriteLine("Path.GetExtension(): " + Path.GetExtension(path2));
            Console.WriteLine("Path.GetFileName(): " + Path.GetFileName(path2));
            Console.WriteLine("Path.GetDirectory(): " + Path.GetDirectoryName(path2));
        }
    }
}
