using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace module8_serializable
{

    [Serializable] 
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // создание объекта класса
            var contact = new Contact("Евгений", 79991234567, "example@example.com");

            // сериализация
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("Contact.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
            }
        }
    }
}
