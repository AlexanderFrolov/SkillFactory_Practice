

namespace FactoryMethod
{
    /// <summary>
    /// класс для рассылки смс
    /// </summary>
    class SmsMessageSender : MessageSender
    {
        public SmsMessageSender(string @from) : base(@from)
        {
        }

        public override Message Send(string text)
        {
            return new SmsMessage();
        }
    }
}
