using Excellence.PasswordGenerators.Core;
using Excellence.Randomizers.Core;
using Excellence.Randomizers.Core.RandomGenerators;
using Excellence.Randomizers.Core.Shufflers;

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
