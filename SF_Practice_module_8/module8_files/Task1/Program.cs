using System;
using System.IO;

namespace Task1
{
    class Program
    {

        static void Delete_TimeSpan30()
        {
            //"C:/Users/Alexander Frolov/Desktop/temp"
            Console.WriteLine("Укажите путь к папке в которой будут удалены файлы и папки не используемые более 30 минут:");
            string dirName = Console.ReadLine();
            var dirInfo = new DirectoryInfo(dirName);
            if (dirInfo.Exists) // Проверим, что директория существует
            {
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
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            else
            {
                Console.WriteLine("По указанному пути папки с таким именем не существует!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Удалим все что не использовалось больше 30 минут");
            Delete_TimeSpan30();
        }

    }
}
