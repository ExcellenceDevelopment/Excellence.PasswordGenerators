using Excellence.Randomizers.Core.Configurations.Core;

namespace Excellence.PasswordGenerators.Core
{
    /// <summary>
    /// The password configuration.
    /// </summary>
    public interface IPasswordConfiguration :
        IConfigurationCore<char, IPasswordConfiguration>,
        IConfigurationCoreJsonUtils<char, IPasswordConfiguration>
    {
        /// <summary>
        /// Adds upper case letters.
        /// </summary>
        /// <returns>The current instance.</returns>
        public IPasswordConfiguration UseUpperCaseLetters();

        /// <summary>
        /// Adds lower case letters.
        /// </summary>
        /// <returns>The current instance.</returns>
        public IPasswordConfiguration UseLowerCaseLetters();

        /// <summary>
        /// Adds digits.
        /// </summary>
        /// <returns>The current instance.</returns>
        public IPasswordConfiguration UseDigits();

        /// <summary>
        /// Adds default special characters.
        /// </summary>
        /// <returns>The current instance.</returns>
        public IPasswordConfiguration UseDefaultSpecialCharacters();
    }
}
