using System;
using System.Text;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string messageText = "Ваш номер заказа - 346424";

            // отправляем заказ по смс
            MessageSender sender = new SmsMessageSender("+79854561232");
            Message smsMessage =  sender.Send(messageText);

            // отправляем заказ по email
            sender = new EmailMessageSender("orders@myshop.com");
            Message emailMessage = sender.Send(messageText);

        }
    }
}
