namespace Excellence.PasswordGenerators.Core
{
    /// <summary>
    /// The password generator factory.
    /// </summary>
    public interface IPasswordGeneratorFactory
    {
        /// <summary>
        /// Creates the password generator.
        /// </summary>
        /// <returns>The password generator.</returns>
        public IPasswordGenerator CreatePasswordGenerator();
    }
}
