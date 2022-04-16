using System;

namespace LegacyApp
{
    public class UserCreditService : IDisposable
    {
        public void Dispose()
        {
            //...
        }
       
        public static void ReturnInstanceWithCredit(User user)
        {
            Client client = user.Client;
            if (client.Name == "VeryImportantClient") {
                user.HasCreditLimit = false;
                return;
            }
            if(client.Name == "ImportantClient")
            {
                user.CreditLimit = UserCreditService.GetCreditLimit() * 2;
                return;
            }
            user.HasCreditLimit = true;
            int creditLimit = GetCreditLimit();
            user.CreditLimit = creditLimit;
            return;
        }

        public static int GetCreditLimit()
        {
            return 10000;
        }
    }
}