using Module11FinishTask.Models;

namespace Module11FinishTask.Services
{
    public interface IStorage
    {
        /// <summary>
        /// Получение сессии пользователя по идентификатору
        /// </summary>
        public Session GetSession(long chatId);
    }
}