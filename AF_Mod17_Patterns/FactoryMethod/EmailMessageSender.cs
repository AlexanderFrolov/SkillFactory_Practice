

namespace FactoryMethod
{
    /// <summary>
    /// класс для рассылки email
    /// </summary>
    class EmailMessageSender : MessageSender
    {
        public EmailMessageSender(string @from) : base(@from)
        {
        }

        public override Message Send(string text)
        {
            return new EmailMessage();
        }
    }
}
