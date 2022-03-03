using System;
using System.Linq;
using System.Collections.Generic;

namespace Filtering_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));


            var bigCities = russianCities.Where(c => c.Population > 1000000)
                .OrderByDescending(c => c.Population);

            var ShortNameCities = bigCities.Where(city => city.Name.Length <= 10)
                .OrderBy(city => city.Name.Length);

            // Словарь для хранения стран с городами
            var Countries = new Dictionary<string, List<City>>();



            // Добавим Россию с её городами
            Countries.Add("Россия", russianCities);

            // Добавим Беларусь
            var belarusCities = new List<City>();
            belarusCities.Add(new City("Минск", 1200000));
            belarusCities.Add(new City("Витебск", 362466));
            belarusCities.Add(new City("Гродно", 368710));
            Countries.Add("Беларусь", belarusCities);

            // Добавим США
            var americanCities = new List<City>();
            americanCities.Add(new City("Нью-Йорк", 8399000));
            americanCities.Add(new City("Вашингтон", 705749));
            americanCities.Add(new City("Альбукерке", 560218));
            Countries.Add("США", americanCities);

            // Задача: сделать выборку городов-миллионников по всем странам.
            var cities = from country in Countries
                         from city in country.Value
                         where city.Population > 1000000
                         orderby city.Population descending
                         select city;



            string[] text = { "Раз два три",
                "четыре пять шесть",
                "семь восемь девять" };

            //Соедините все слова в одну последовательность (каждое слово — отдельный элемент последовательности).

            var words = from str in text // пробегаемся по элементам массива
                        from word in str.Split(' ') // дробим каждый элемент по пробелам, сохраняя в новую последовательность
                        select word; // собираем все куски в результирующую выборку

            // выводим результат
            foreach (var word in words)
                Console.WriteLine(word);

            // Подготовим данные
            List<Student> students = new List<Student>
            {
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            // Составим запрос ()
            var selectedStudents = students.SelectMany(
                // коллекция, которую нужно преобразовать
                s => s.Languages,
                // функция преобразования, применяющаяся к каждому элементу коллекции
                (s, l) => new { Student = s, Lang = l })
                // дополнительные условия                          
               .Where(s => s.Lang == "английский" && s.Student.Age < 28)
               // указатель на объект выборки
               .Select(s => s.Student);

            // Выведем результат
            foreach (Student student in selectedStudents)
                Console.WriteLine($"{student.Name} - {student.Age}");

            Console.WriteLine();


            //Задание 14.1.5 
            var companies = new Dictionary<string, string[]>();

            companies.Add("Apple", new[] { "Mobile", "Desktop" });
            companies.Add("Samsung", new[] { "Mobile" });
            companies.Add("IBM", new[] { "Desktop" });

            //Сделайте выборку тех, которые производят мобильную технику:
            var selectedCompanies = companies.Where(c => c.Value.Contains("Mobile"));


            var numsList = new List<int[]>()
            {
               new[] {2, 3, 7, 1},
               new[] {45, 17, 88, 0},
               new[] {23, 32, 44, -6},
            };
            var orderedNums = numsList
                .SelectMany(s => s) // выбираем элементы
                .OrderBy(s => s); // сортируем

            // выводим
            foreach (var ord in orderedNums)
                Console.WriteLine(ord);

           

            // Список курсов
            var coarses = new List<Coarse>
            {
               new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
               new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };


            /* 
                Задание 14.2.4
                Теперь добавьте всех студентов младше 29 лет, владеющих английским языком, в курс «Язык программирования C#». 

                Новая анонимная сущность для выборки должна иметь следующие поля:
                имя (строка);
                год рождения студента (целое число);
                имя курса (строка).
            */

            var studentsWithCoarses = from stud in students
                                      where stud.Age < 29
                                      where stud.Languages.Contains("английский")
                                      from coarse in coarses
                                      where coarse.Name.Contains("C#")
                                      let birthYear = DateTime.Now.Year - stud.Age
                                      select new
                                      {
                                          Name = stud.Name,
                                          BirthYear = birthYear,
                                          CoarseName = coarse.Name
                                      };
            foreach (var stud in studentsWithCoarses)
            {
                Console.WriteLine($"Студент {stud.Name} ({stud.BirthYear}) записан на курс: {stud.CoarseName}");
            }


            // Подготовка данных
            var cars = new List<Car>()
            {
               new Car("Suzuki", "JP"),
               new Car("Toyota", "JP"),
               new Car("Opel", "DE"),
               new Car("Kamaz", "RUS"),
               new Car("Lada", "RUS"),
               new Car("Lada", "RUS"),
               new Car("Honda", "JP"),
            };


            Console.WriteLine();
           
            cars.RemoveAll(cars => cars.CountryCode == "JP");

            Console.WriteLine(cars);
            

        }
    }


    public class Car
    {
        public string Manufacturer { get; set; }
        public string CountryCode { get; set; }

        public Car(string manufacturer, string countryCode)
        {
            Manufacturer = manufacturer;
            CountryCode = countryCode;
        }
    }

    // Создадим модель класс для города
    public class City
    {
        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

        public string Name { get; set; }
        public long Population { get; set; }
    }

    public class Student
    {
    
        public string Name { get; set; }
        public int Age { get; set; }

        public List<string> Languages;
    }

    public class Coarse
    {

        public string Name { get; set; }
        public DateTime StartDate { get; set; }

    }
}
