﻿using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Module11FinishTask.Controllers;
using Module11FinishTask.Services;
using Telegram.Bot;

namespace Module11FinishTask
{
    internal class Program
    {
        public static async Task Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            // Объект, отвечающий за постоянный жизненный цикл приложения
            var host = new HostBuilder()
                .ConfigureServices((hostContext, services) => ConfigureServices(services)) // Задаем конфигурацию
                .UseConsoleLifetime() // Позволяет поддерживать приложение активным в консоли
                .Build(); // Собираем

            Console.WriteLine("Сервис запущен");
            // Запускаем сервис
            await host.RunAsync();
            Console.WriteLine("Сервис остановлен");
        }

        static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IStorage, MemoryStorage>();
            // Подключаем контроллеры сообщений и кнопок
            services.AddTransient<DefaultMessageController>();
            services.AddTransient<TextMessageController>();
            services.AddTransient<InlineKeyboardController>();
            // Регистрируем объект TelegramBotClient c токеном подключения
            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient("5673024543:AAEhfeZum73PdCrP-wqxVQcowsOu-w598co"));
            // Регистрируем постоянно активный сервис бота
            services.AddHostedService<Bot>();
        }
    }
}