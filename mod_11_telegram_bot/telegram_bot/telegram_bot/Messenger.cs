using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace telegram_bot
{
    public class Messenger
    {

        private ITelegramBotClient botClient;
        //private CommandParser parser;


        public Messenger(ITelegramBotClient botClient)
        {
            this.botClient = botClient;
        }

        public string CreateTextMessage(Conversation chat)
        {
            var text = "";

            switch (chat.GetLastMessage())
            {
                case "/saymehi":
                    text = "привет";
                    break;
                case "/askme":
                    text = "как дела";
                    break;
                case "/poembuttons":
                    text = "Выберите поэта:";
                    break;
                default:
                    var delimiter = " , ";
                    text = "История ваших сообщений: " + string.Join(delimiter, chat.GetTextMessages().ToArray());
                    break;
            }

            return text;
        }

        public InlineKeyboardMarkup ReturnKeyBoard()
        {
            var buttonList = new List<InlineKeyboardButton>
            {
                new InlineKeyboardButton
                {
                    Text = "Пушкин",
                    CallbackData = "pushkin"
                },

                new InlineKeyboardButton
                {
                    Text = "Есенин",
                    CallbackData = "esenin"
                }
            };

            var keyboard = new InlineKeyboardMarkup(buttonList);

            return keyboard;
        }

     

    }
}
