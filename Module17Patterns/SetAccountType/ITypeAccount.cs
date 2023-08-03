using System;

namespace Module17Patterns.SetAccountType
{

    /// Общий интерфейс для типов аккаунтов

    public interface ITypeAccount
    {
        public void CalculateInterest(Account account);
    }
}
