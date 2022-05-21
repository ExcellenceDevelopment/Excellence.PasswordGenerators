using Excellence.Randomizers.Core;

namespace Excellence.PasswordGenerators.Core
{
    /// <summary>
    /// The password generator.
    /// </summary>
    public interface IPasswordGenerator : IRandomizerCore<char, IPasswordConfiguration, IPasswordGenerator> { }
}
