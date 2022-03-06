using System;


namespace FactoryMethod
{
    class EmailMessage : Message
    {
        public EmailMessage()
        {
            Console.WriteLine("email отправлен!");
        }
    }
}
