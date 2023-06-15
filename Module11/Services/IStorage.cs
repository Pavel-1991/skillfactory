using Module11.Models;



namespace Module11.Services
{
    public interface IStorage
    {
        /// <summary>
        /// Получение сессии пользователя по идентификатору
        /// </summary>
        public Session GetSession(long chatId);
    }
}
