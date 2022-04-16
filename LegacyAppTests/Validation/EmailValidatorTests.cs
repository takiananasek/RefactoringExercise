using LegacyApp.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace LegacyAppTests.Validation
{
    public class EmailValidatorTests
    {

        [Theory]
        [InlineData("nina@mail.com")]
        [InlineData("ab@.pl")]
        [InlineData(".@")]

        public void EmailIsValid_ReturnsTrue_WhenEmailContainsDotAndAt(string email)
        {
            var res = EmailValidator.EmailIsValid(email);
            Assert.True(res);
        }
    }
}
