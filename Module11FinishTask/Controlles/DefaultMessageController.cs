using Telegram.Bot;
using Telegram.Bot.Types;

namespace Module11FinishTask.Controllers
{
    public class DefaultMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public DefaultMessageController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }
        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Необходимо вводить либо текст либо два числа через пробел", cancellationToken: ct);
        }
    }
}
