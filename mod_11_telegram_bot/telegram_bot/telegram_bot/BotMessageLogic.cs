using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace telegram_bot
{
    public class BotMessageLogic
    {
        private Messenger messanger;

        private Dictionary<long, Conversation> chatList;

        private ITelegramBotClient botClient;

        public BotMessageLogic(ITelegramBotClient botClient)
        {
            chatList = new Dictionary<long, Conversation>();
            messanger = new Messenger(botClient);
            this.botClient = botClient;
        }

        public async Task Response(MessageEventArgs e)
        {
            var Id = e.Message.Chat.Id;

            if (!chatList.ContainsKey(Id))
            {
                var newchat = new Conversation(e.Message.Chat);

                chatList.Add(Id, newchat);
            }

            var chat = chatList[Id];

            chat.AddMessage(e.Message);

            var text = messanger.CreateTextMessage(chat);
            if(chat.GetLastMessage() != "/poembuttons")
            {
                await SendTextMessage(chat, text);
            }
            else
            {
                await SendTextWithKeyBoard(chat, text, messanger.ReturnKeyBoard());

            }
        }

        private async Task SendTextMessage(Conversation chat, string text)
        {
            await botClient.SendTextMessageAsync(
            chatId: chat.GetId(), text: text);
        }

        private async Task SendTextWithKeyBoard(Conversation chat, string text, InlineKeyboardMarkup keyboard)
        {

            await botClient.SendTextMessageAsync(
            chatId: chat.GetId(), text: text, replyMarkup: keyboard);
        }



    }
}
