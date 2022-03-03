using System;
using System.Collections.Generic;
using System.Linq;

namespace AF_Task_14_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AF_Task_14_3_3");
            Console.WriteLine("Доработайте вашу телефонную книгу из задания 14.2.10 предыдущего юнита так," +
                " чтобы контакты телефонной книги были отсортированы сперва по имени, а затем по фамилии.");
            Console.WriteLine();

            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            // сортируем сначала по имени а затем по фамилии
            var sortedPhoneBook = phoneBook.OrderBy(contact => contact.Name)
                                           .ThenBy(contact => contact.LastName);
            
            // выводим в консоль сортированную телефонную книгу
            foreach (var contact in sortedPhoneBook)
            {
                Console.WriteLine($"{contact.Name} {contact.LastName} телефон: {contact.PhoneNumber} , email: {contact.Email}");
            }
          
        }
    }
}
