using System;

namespace Module17Patterns.SetAccountType
{
    public class AccountTypeBase : ITypeAccount
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.4;
            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
