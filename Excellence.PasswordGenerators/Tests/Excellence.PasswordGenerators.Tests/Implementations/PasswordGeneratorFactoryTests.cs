using Excellence.PasswordGenerators.Core;
using Excellence.Randomizers.Core.RandomGenerators;
using Excellence.Randomizers.Core.Shufflers;
using Excellence.Randomizers.RandomGenerators;
using Excellence.Randomizers.Shufflers;

using Xunit;

namespace Excellence.PasswordGenerators.Tests
{
    public class PasswordGeneratorFactoryTests
    {
        #region Shared

        protected IPasswordGeneratorFactory CreateSut(IRandomGenerator? randomGenerator = null, IShuffler? shuffler = null)
        {
            randomGenerator ??= new DefaultRandomGenerator();
            shuffler ??= new KnuthShuffler(randomGenerator);

            return new PasswordGeneratorFactory(randomGenerator, shuffler);
        }

        #endregion Shared

        #region Constructors

        public static TheoryData<IRandomGenerator, IShuffler> ConstructorArgumentIsNullTestData => new TheoryData<IRandomGenerator, IShuffler>()
        {
            { null!, null! },
            { new DefaultRandomGenerator(), null! }
        };

        [Theory]
        [MemberData(nameof(ConstructorArgumentIsNullTestData))]
        public void Constructor_Argument_IsNull_ThrowsException(IRandomGenerator randomGenerator, IShuffler shuffler) =>
            Assert.Throws<ArgumentNullException>(() => new PasswordGeneratorFactory(randomGenerator, shuffler));

        [Fact]
        public void Constructor_CreatesInstance()
        {
            var randomGenerator = new DefaultRandomGenerator();
            var shuffler = new KnuthShuffler(randomGenerator);

            var actualResult = this.CreateSut(randomGenerator, shuffler);

            Assert.NotNull(actualResult);
        }

        #endregion Constructors

        #region CreatePasswordGenerator

        [Fact]
        public void CreatePasswordGenerator_CreatesPasswordGenerator()
        {
            var sut = this.CreateSut();

            var passwordGenerator = sut.CreatePasswordGenerator();

            Assert.NotNull(passwordGenerator);
        }

        #endregion CreatePasswordGenerator
    }
}
