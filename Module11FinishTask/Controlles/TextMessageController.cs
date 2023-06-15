using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using Module11FinishTask.Services;

namespace Module11FinishTask.Controllers
{
    public class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly IStorage _memoryStorage;

        public TextMessageController(ITelegramBotClient telegramBotClient, IStorage memoryStorage)
        {
            _telegramClient = telegramBotClient;
            _memoryStorage = memoryStorage;
        }
        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение: {message.Text}");
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Получено текстовое сообщение: {message.Text}", cancellationToken: ct);
            string UseFunctionCode = _memoryStorage.GetSession(message.Chat.Id).FunctionCode; // Здесь получим выбранный функционал
            switch (message.Text)
            {
                case "/start":

                    // Объект, представляющий кноки
                    var buttons = new List<InlineKeyboardButton[]>();
                    buttons.Add(new[]
                    {
                        InlineKeyboardButton.WithCallbackData($"Кол-во символов" , $"count"),
                        InlineKeyboardButton.WithCallbackData($"Сумма 2х чисел" , $"summ")
                    });

                    // передаем кнопки вместе с сообщением (параметр ReplyMarkup)
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"<b>  Наш бот считает либо кол-во символов в строке, либо сумму двух чисел(через пробел введённых)</b> {Environment.NewLine}" +
                        $"{Environment.NewLine}", cancellationToken: ct, parseMode: ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttons));
                    break;
                default:
                    switch (UseFunctionCode)
                    {
                        case "count":
                            await _telegramClient.SendTextMessageAsync(message.From.Id, $"Длина сообщения: {message.Text.Length} знаков", cancellationToken: ct);
                            break;
                        case "summ":
                            try
                            {
                                double sumnumbers = 0;
                                string[] numbers = message.Text.Split(' ');
                                foreach (string number in numbers)
                                {
                                    sumnumbers += Convert.ToDouble(number);
                                }
                                await _telegramClient.SendTextMessageAsync(message.From.Id, $"Сумма чисел: {sumnumbers}", cancellationToken: ct);
                            }                               
                            catch (Exception e)
                            {
                                await _telegramClient.SendTextMessageAsync(message.From.Id, $"Ошибка: {e.Message}", cancellationToken: ct); 
                            }
                            break;
                        default:
                            await _telegramClient.SendTextMessageAsync(message.Chat.Id, "Присылайте ещё, не бойтесь)", cancellationToken: ct);
                            break;
                    }
                    break;   
            }
        }
    }
}
