using Excellence.PasswordGenerators.Core;
using Excellence.Randomizers;
using Excellence.Randomizers.Core;

namespace Excellence.PasswordGenerators
{
    /// <inheritdoc cref="IPasswordGenerator" />
    public class PasswordGenerator : RandomizerCore<char, IPasswordConfiguration, IPasswordGenerator>, IPasswordGenerator
    {
        /// <summary>
        /// Creates a new instance of <see cref="PasswordGenerator"/>.
        /// </summary>
        /// <param name="randomGenerator">The random generator.</param>
        /// <param name="shuffler">The shuffler.</param>
        public PasswordGenerator(IRandomGenerator randomGenerator, IShuffler shuffler) : base(randomGenerator, shuffler) { }
    }
}
