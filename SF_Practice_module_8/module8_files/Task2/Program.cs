using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static long GetDirectorySize(string startDirectory, long size = 0)
        {
            try
            {
                string[] searchDirectory = Directory.GetDirectories(startDirectory);
                if (searchDirectory.Length > 0)
                {
                    foreach (var dir in searchDirectory)
                    {
                        Console.WriteLine($"Папка: {dir}");
                        size += GetDirectorySize(dir + @"\", size);
                    }
                }
                string[] filesss = Directory.GetFiles(startDirectory);
                foreach (var file in filesss)
                {
                    Console.WriteLine($"  Файл: {file}");
                    FileInfo info = new FileInfo(file);
                    size += info.Length;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return size;
        }

        static void Main(string[] args)
        {
            //"C:/Users/Alexander Frolov/Desktop/temp";
            Console.WriteLine("Введите путь к папке размер которой нужно узнать:");
            string dirName = Console.ReadLine();
            if (Directory.Exists(dirName))
            {
                long result = GetDirectorySize(dirName);
                Console.WriteLine($"Размер директории составляет: {result} байт");
            }
            else
            {
                Console.WriteLine("По указанному пути папки с таким именем не существует!");
            }             
        }
    }
}
