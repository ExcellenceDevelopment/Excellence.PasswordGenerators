using Excellence.PasswordGenerators.Core;
using Excellence.Randomizers;

namespace Excellence.PasswordGenerators
{
    /// <inheritdoc cref="IPasswordConfiguration" />
    public class PasswordConfiguration : ConfigurationCore<char, IPasswordConfiguration>, IPasswordConfiguration
    {
        /// <inheritdoc />
        public IPasswordConfiguration UseUpperCaseLetters() => this.UseItems(Defaults.LettersUpperCase);

        /// <inheritdoc />
        public IPasswordConfiguration UseLowerCaseLetters() => this.UseItems(Defaults.LettersLowerCase);

        /// <inheritdoc />
        public IPasswordConfiguration UseDigits() => this.UseItems(Defaults.Digits);

        /// <inheritdoc />
        public IPasswordConfiguration UseDefaultSpecialCharacters() => this.UseItems(Defaults.SpecialCharacters);
    }
}
