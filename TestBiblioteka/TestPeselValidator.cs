using System;
using System.Data;
using Xunit;

namespace TestBiblioteka
{
    public class TestPeselValidator
    {
        private DataTable CreateTestUsersTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PESEL", typeof(string));
            table.Rows.Add("12345678901"); // Istniejący PESEL
            return table;
        }

        [Fact]
        public void ValidatePesel_InvalidLength_ShouldReturnFalse() 
        {
            // Arrange
            var validator = new PeselValidator(null);
            string invalidPesel = "1234567890"; // 10 znaków zamiast 11

            // Act
            bool result = validator.ValidatePesel(invalidPesel);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidatePesel_DuplicatePesel_ShouldReturnFalse()
        {
            // Arrange
            var usersTable = CreateTestUsersTable();
            var validator = new PeselValidator(usersTable);
            string duplicatePesel = "12345678901"; // PESEL istniejący w tabeli

            // Act
            bool result = validator.ValidatePesel(duplicatePesel);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidatePesel_InvalidBirthDate_ShouldReturnFalse()
        {
            // Arrange
            var validator = new PeselValidator(null);
            string invalidDatePesel = "00223012345"; // 30 luty (nieistniejąca data)

            // Act
            bool result = validator.ValidatePesel(invalidDatePesel);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidatePesel_InvalidControlDigit_ShouldReturnFalse()
        {
            // Arrange
            var validator = new PeselValidator(null);
            string invalidControlPesel = "44051401358"; // Ostatnia cyfra powinna być 6

            // Act
            bool result = validator.ValidatePesel(invalidControlPesel);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidatePesel_ValidPesel_ShouldReturnTrue()
        {
            // Arrange
            var validator = new PeselValidator(null);
            string validPesel = "03250702324"; // Poprawny PESEL

            // Act
            bool result = validator.ValidatePesel(validPesel);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidatePesel_BirthDate_ShouldHandleCorrectly()
        {
            // Arrange
            var validator = new PeselValidator(null);
            string pesel = "02301025751"; // 2002-10-10 

            // Act
            bool result = validator.ValidatePesel(pesel);

            // Assert
            Assert.True(result);
        }
    }
}