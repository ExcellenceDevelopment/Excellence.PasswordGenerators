using Excellence.PasswordGenerators.Core;

using Xunit;

namespace Excellence.PasswordGenerators.Tests
{
    public class PasswordConfigurationTests
    {
        #region Shared

        protected IPasswordConfiguration CreateSut() => new PasswordConfiguration();

        #endregion Shared

        #region UseUpperCaseLetters

        [Fact]
        public void UseUpperCaseLetters_AddsUpperCaseLetters()
        {
            var expectedSubstring = Defaults.LettersUpperCase;

            var sut = this.CreateSut();

            sut.UseUpperCaseLetters();

            Assert.Contains(expectedSubstring, new string(sut.Items.ToArray()));
        }

        #endregion UseUpperCaseLetters

        #region UseLowerCaseLetters

        [Fact]
        public void UseLowerCaseLetters_AddsLowerCaseLetters()
        {
            var expectedSubstring = Defaults.LettersLowerCase;

            var sut = this.CreateSut();

            sut.UseLowerCaseLetters();

            Assert.Contains(expectedSubstring, new string(sut.Items.ToArray()));
        }

        #endregion UseLowerCaseLetters

        #region UseDigits

        [Fact]
        public void UseDigits_AddsDigits()
        {
            var expectedSubstring = Defaults.Digits;

            var sut = this.CreateSut();

            sut.UseDigits();

            Assert.Contains(expectedSubstring, new string(sut.Items.ToArray()));
        }

        #endregion UseDigits

        #region UseDefaultSpecialCharacters

        [Fact]
        public void UseDefaultSpecialCharacters_AddsDefaultSpecialCharacters()
        {
            var expectedSubstring = Defaults.SpecialCharacters;

            var sut = this.CreateSut();

            sut.UseDefaultSpecialCharacters();

            Assert.Contains(expectedSubstring, new string(sut.Items.ToArray()));
        }

        #endregion UseDefaultSpecialCharacters
    }
}
