using System;

namespace Module17Patterns.SetAccountType
{
    public class AccountTypeSalary : ITypeAccount
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
