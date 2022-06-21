using System;

using Excellence.PasswordGenerators.Core;
using Excellence.PasswordGenerators.Extensions;
using Excellence.Randomizers.Core.RandomGenerators;
using Excellence.Randomizers.Core.Shufflers;
using Excellence.Randomizers.RandomGenerators;
using Excellence.Randomizers.Shufflers;

using Microsoft.Extensions.DependencyInjection;

using Xunit;

namespace Excellence.PasswordGenerators.Tests.Extensions
{
    public class ServiceCollectionExtensionsTests
    {
        #region AddPasswordGenerators

        [Fact]
        public void AddPasswordGenerators_Argument_IsNull_ThrowsException()
        {
            var sut = default(IServiceCollection);

            Assert.Throws<ArgumentNullException>(() => sut!.AddPasswordGenerators());
        }

        [Fact]
        public void AddPasswordGenerators_AddsPasswordGenerators()
        {
            var expectedRandomGeneratorType = typeof(DefaultRandomGenerator);
            var expectedShufflerType = typeof(KnuthShuffler);
            var expectedPasswordGeneratorFactoryType = typeof(PasswordGeneratorFactory);

            var sut = new ServiceCollection();

            var actualResult = sut.AddPasswordGenerators();

            var serviceProvider = actualResult.BuildServiceProvider();

            var randomGenerator = serviceProvider.GetRequiredService<IRandomGenerator>();

            Assert.NotNull(randomGenerator);
            Assert.Equal(expectedRandomGeneratorType, randomGenerator.GetType());

            var shuffler = serviceProvider.GetRequiredService<IShuffler>();

            Assert.NotNull(shuffler);
            Assert.Equal(expectedShufflerType, shuffler.GetType());

            var passwordGeneratorFactory = serviceProvider.GetRequiredService<IPasswordGeneratorFactory>();

            Assert.NotNull(passwordGeneratorFactory);
            Assert.Equal(expectedPasswordGeneratorFactoryType, passwordGeneratorFactory.GetType());
        }

        #endregion AddPasswordGenerators
    }
}
