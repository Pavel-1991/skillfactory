using System;
using Module17Patterns.SetAccountType;

namespace Module17Patterns
{
    public class Calculator
    {
        public void CalculateInterestAll(ITypeAccount TypeAccount, Account account)
        {
            TypeAccount.CalculateInterest(account);
        }
    }
}
