using Excellence.PasswordGenerators.Core;
using Excellence.Randomizers.Extensions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

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
        /// <param name="services">The services.</param>
        /// <returns>The passed <see cref="IServiceCollection"/> instance with the added dependencies.</returns>
        /// <exception cref="ArgumentNullException">The exception when the argument is <see langword="null"/>.</exception>
        public static IServiceCollection AddPasswordGenerators(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            services.AddRandomizers();
            services.TryAddSingleton<IPasswordGeneratorFactory, PasswordGeneratorFactory>();

            return services;
        }
    }
}
