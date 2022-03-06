using System;


namespace FactoryMethod
{
    class SmsMessage : Message
    {
        public SmsMessage()
        {
            Console.WriteLine("смс отправлено!");
        }
    }
}
