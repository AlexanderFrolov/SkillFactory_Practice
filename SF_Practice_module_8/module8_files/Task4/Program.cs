using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{

    [Serializable] //   Атрибут сериализации
    class Student
    {
        //     Простая модель класса 
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime DateofBirth { get; set; }

        // Метод - конструктор
        public Student(string name, string group,  DateTime date)
        {
            Name = name;
            Group = group;
            DateofBirth = date;
        }
    }

    class Program
    {
  
        static void Main(string[] args)
        {
            string fileName = "../../../Students.dat";
            // берем путь к рабочему столу из массива аргументов приложения args и создаем папку Students 
            string mainPath = args[0] + "/Students";
            Directory.CreateDirectory(mainPath);
            BinaryFormatter formatter = new BinaryFormatter();

            // десериализация
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                Student[] Students = (Student[])formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
               
                foreach (var student in Students)
                {
                    Console.WriteLine($"Имя: {student.Name} --- Группа: {student.Group} --- Дата рождения: {student.DateofBirth}");
                    
                    // распределяем студентов по группам студентов по файлам группы
                    using (StreamWriter sw = File.AppendText(mainPath + "/" + student.Group + ".txt"))  
                    {
                        sw.WriteLine($"Имя: {student.Name}, Дата Рождения: {student.DateofBirth} ");
                    }
                   
                }
            }
        }
    }
    
}
