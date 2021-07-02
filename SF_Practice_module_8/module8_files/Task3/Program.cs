using System;
using System.IO;

namespace Task3
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

        static void Delete_TimeSpan30(string dirName)
        {
            var dirInfo = new DirectoryInfo(dirName);
          
                TimeSpan diff;
                try
                {
                    // пройдем по файлам. если больше 30 то удаляем.
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        diff = DateTime.Now - file.LastAccessTime;
                        if (diff.Minutes > 30)
                        {
                            Console.WriteLine($"Файл {file.Name} удален");
                            file.Delete();
                        }
                    }

                    // пройдем по папкам. если папка не спользовалась больше 30 мин то удаляем ее и все ее содержимое
                    foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                    {
                        diff = DateTime.Now - dir.LastAccessTime;
                        if (diff.Minutes > 30)
                        {
                            Console.WriteLine($"Директория {dir.Name} удалена");
                            dir.Delete(true);
                        }
                    }
                    Console.WriteLine("процесс завершен");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
        }

        static void Main(string[] args)
        {
            //"C:/Users/Alexander Frolov/Desktop/temp";
            Console.WriteLine("Удалим все что не использовалось больше 30 минут");
            Console.WriteLine("Укажите путь к папке в которой будут удалены файлы и папки не используемые более 30 минут:");
            string dirName = Console.ReadLine();
            if (Directory.Exists(dirName))
            {
                long result = GetDirectorySize(dirName);
                Console.WriteLine($"Размер директории ДО удаления составляет: {result} байт");
                Console.WriteLine("Выполняется очистка...");
                Delete_TimeSpan30(dirName);
                result = GetDirectorySize(dirName);
                Console.WriteLine($"Размер директории ПОСЛЕ удаления составляет: {result} байт");
            }
            else
            {
                Console.WriteLine("По указанному пути папки с таким именем не существует!");
            }

        }
    }
}
