using System;

using Excellence.PasswordGenerators.Core;
using Excellence.Randomizers.Extensions;

using Microsoft.Extensions.DependencyInjection;

namespace Excellence.PasswordGenerators.Extensions
{
    /// <summary>
    /// The service collection extensions.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the dependencies needed for the the password generators.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        /// <returns>The passed <see cref="IServiceCollection"/> instance with the added dependencies.</returns>
        /// <exception cref="ArgumentNullException">The exception when the argument is <see langword="null"/>.</exception>
        public static IServiceCollection AddPasswordGenerators(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddRandomizers();
            serviceCollection.AddSingleton<IPasswordGeneratorFactory, PasswordGeneratorFactory>();

            return serviceCollection;
        }
    }
}
