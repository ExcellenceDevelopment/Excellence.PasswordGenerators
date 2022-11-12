using Excellence.PasswordGenerators.Core;
using Excellence.Randomizers.Core.RandomGenerators;
using Excellence.Randomizers.Core.Shufflers;

namespace Excellence.PasswordGenerators
{
    /// <inheritdoc />
    public class PasswordGeneratorFactory : IPasswordGeneratorFactory
    {
        /// <summary>
        /// The random generator.
        /// </summary>
        protected IRandomGenerator RandomGenerator { get; }

        /// <summary>
        /// The shuffler.
        /// </summary>
        protected IShuffler Shuffler { get; }

        /// <summary>
        /// Creates a new instance of <see cref="PasswordGeneratorFactory"/>.
        /// </summary>
        /// <param name="randomGenerator">The random generator.</param>
        /// <param name="shuffler">The shuffler.</param>
        public PasswordGeneratorFactory(IRandomGenerator randomGenerator, IShuffler shuffler)
        {
            ArgumentNullException.ThrowIfNull(randomGenerator);
            ArgumentNullException.ThrowIfNull(shuffler);

            this.RandomGenerator = randomGenerator;
            this.Shuffler = shuffler;
        }

        /// <inheritdoc />
        public virtual IPasswordGenerator CreatePasswordGenerator() => new PasswordGenerator(this.RandomGenerator, this.Shuffler);
    }
}
