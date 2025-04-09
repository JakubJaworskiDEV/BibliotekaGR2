using System;
using System.Text.RegularExpressions;
using Xunit;

namespace TestBiblioteka
{
    public class TestEmailValidation
    {
        private const string EmailRegexPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        [Fact]
        public void ValidEmail_ShouldPassValidation() //Sprawdza podstawowy poprawny format emaila
        {
            // Arrange
            var email = "test@example.com";
            var regex = new Regex(EmailRegexPattern);

            // Act
            var isValid = regex.IsMatch(email);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void EmailWithDotInName_ShouldPassValidation() //Weryfikuje, że email zawierający kropkę w nazwie użytkownika jest uznawany za poprawny.
        {
            // Arrange
            var email = "user.name@domain.com";
            var regex = new Regex(EmailRegexPattern);

            // Act
            var isValid = regex.IsMatch(email);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void EmailWithSubdomain_ShouldPassValidation() //Testuje akceptację emaili z subdomenami 
        {
            // Arrange
            var email = "user@sub.domain.com";
            var regex = new Regex(EmailRegexPattern);

            // Act
            var isValid = regex.IsMatch(email);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void EmailWithoutTld_ShouldFailValidation() //Sprawdza odrzucenie emaila bez domeny najwyższego poziomu 
        {
            // Arrange
            var email = "user@localhost";
            var regex = new Regex(EmailRegexPattern);

            // Act
            var isValid = regex.IsMatch(email);

            // Assert
            Assert.False(isValid);
        }

        [Fact]
        public void EmailWithSpace_ShouldFailValidation() //Weryfikuje, że email zawierający spację jest odrzucany
        {
            // Arrange
            var email = "user name@domain.com";
            var regex = new Regex(EmailRegexPattern);

            // Act
            var isValid = regex.IsMatch(email);

            // Assert
            Assert.False(isValid);
        }

        [Fact]
        public void EmptyEmail_ShouldFailValidation() //Testuje obsługę pustego stringa jako niepoprawnego emaila ("")
        {
            // Arrange
            var email = "";
            var regex = new Regex(EmailRegexPattern);

            // Act
            var isValid = regex.IsMatch(email);

            // Assert
            Assert.False(isValid);
        }

        [Fact]
        public void NullEmail_ShouldFailValidation() //Sprawdza obsługę wartości null jako niepoprawnego emaila
        {
            // Arrange
            string email = null;
            var regex = new Regex(EmailRegexPattern);

            // Act
            var isValid = regex.IsMatch(email ?? string.Empty);

            // Assert
            Assert.False(isValid);
            string email2 = null;
        }
    }
}