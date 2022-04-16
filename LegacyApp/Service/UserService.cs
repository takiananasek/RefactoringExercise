using LegacyApp.Validation;
using System;

namespace LegacyApp
{
    public class UserService
    {    
        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            //user data validation
            if(!(UserDataValidator.UserAgeIsValid(dateOfBirth) && UserDataValidator.UserDataIsValid(firstName, lastName)))
            {
                return false;
            }
            //email validation
            if (!EmailValidator.EmailIsValid(email))
            {
                return false;
            }
              
            var client = ClientRepository.GetById(clientId);

            var user = new User
            {
                Client = client,
                DateOfBirth = dateOfBirth,
                EmailAddress = email,
                FirstName = firstName,
                LastName = lastName
            };

            UserCreditService.ReturnInstanceWithCredit(user);


            if (!UserDataValidator.IsHavingEnoughCreditLimit(user))
            {
                return false;
            }

            UserDataAccess.AddUser(user);
            return true;
        }
    }
}
