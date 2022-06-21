using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using Excellence.PasswordGenerators.Core;
using Excellence.Randomizers.RandomGenerators;
using Excellence.Randomizers.Shufflers;

using Xunit;

namespace Excellence.PasswordGenerators.Tests
{
    public class PasswordGeneratorTests
    {
        #region Shared

        protected IPasswordGenerator CreateSut()
        {
            var randomGenerator = new DefaultRandomGenerator();
            var shuffler = new KnuthShuffler(randomGenerator);

            return new PasswordGenerator(randomGenerator, shuffler);
        }

        #endregion Shared

        #region Next

        public static TheoryData<IEnumerable<IPasswordConfiguration>, Func<string, bool>> NextTestData =>
            new TheoryData<IEnumerable<IPasswordConfiguration>, Func<string, bool>>()
            {
                {
                    new[] { new PasswordConfiguration().UseUpperCaseLetters().UseMinCount(8).UseMaxCount(16) },
                    param => Regex.IsMatch(param, $@"^[{Regex.Escape(Defaults.LettersUpperCase)}]{{8,16}}$")
                },
                {
                    new[] { new PasswordConfiguration().UseLowerCaseLetters().UseMinCount(8).UseMaxCount(16) },
                    param => Regex.IsMatch(param, $@"^[{Regex.Escape(Defaults.LettersLowerCase)}]{{8,16}}$")
                },
                {
                    new[] { new PasswordConfiguration().UseDigits().UseMinCount(8).UseMaxCount(16) },
                    param => Regex.IsMatch(param, $@"^[{Regex.Escape(Defaults.Digits)}]{{8,16}}$")
                },
                {
                    new[] { new PasswordConfiguration().UseDefaultSpecialCharacters().UseMinCount(8).UseMaxCount(16) },
                    param => Regex.IsMatch(param, @"^[\(\)\[\]\{\}<>\+\-\*/\=\&\|\^\!~`@\#\$%_\\\|;\:'""\\?,\.]{8,16}$")
                },
                {
                    new[] { new PasswordConfiguration().UseItems("ABCDefg852+#$^#@$^@#").UseMinCount(8).UseMaxCount(16) },
                    param => Regex.IsMatch(param, @"^[ABCDefg852\+\#\$\^\#@\$\^@\#]{8,16}$")
                },
                {
                    new[]
                    {
                        new PasswordConfiguration().UseUpperCaseLetters().UseMinCount(2).UseMaxCount(8),
                        new PasswordConfiguration().UseLowerCaseLetters().UseMinCount(4).UseMaxCount(16),
                        new PasswordConfiguration().UseDigits().UseMinCount(1).UseMaxCount(4),
                        new PasswordConfiguration().UseDefaultSpecialCharacters().UseMinCount(2).UseMaxCount(4)
                    },
                    param =>
                    {
                        var upperCaseLettersCount = param.Count(item => Defaults.LettersUpperCase.Contains(item));
                        var lowerCaseLettersCount = param.Count(item => Defaults.LettersLowerCase.Contains(item));
                        var digitsCount = param.Count(item => Defaults.Digits.Contains(item));
                        var specialCharactersCount = param.Count(item => Defaults.SpecialCharacters.Contains(item));

                        return IsInRange(upperCaseLettersCount, 2, 8)
                               && IsInRange(lowerCaseLettersCount, 4, 16)
                               && IsInRange(digitsCount, 1, 4)
                               && IsInRange(specialCharactersCount, 2, 4);
                    }
                },
                {
                    new[]
                    {
                        new PasswordConfiguration().UseUpperCaseLetters().UseMinCount(2).UseMaxCount(8).UseUnique(true),
                        new PasswordConfiguration().UseLowerCaseLetters().UseMinCount(4).UseMaxCount(16).UseUnique(true),
                        new PasswordConfiguration().UseDigits().UseMinCount(1).UseMaxCount(4).UseUnique(true),
                        new PasswordConfiguration().UseDefaultSpecialCharacters().UseMinCount(2).UseMaxCount(4).UseUnique(true)
                    },
                    param =>
                    {
                        var upperCaseLettersCount = param.Count(item => Defaults.LettersUpperCase.Contains(item));
                        var lowerCaseLettersCount = param.Count(item => Defaults.LettersLowerCase.Contains(item));
                        var digitsCount = param.Count(item => Defaults.Digits.Contains(item));
                        var specialCharactersCount = param.Count(item => Defaults.SpecialCharacters.Contains(item));

                        return IsInRange(upperCaseLettersCount, 2, 8)
                               && IsInRange(lowerCaseLettersCount, 4, 16)
                               && IsInRange(digitsCount, 1, 4)
                               && IsInRange(specialCharactersCount, 2, 4)
                               && param.Length == param.Distinct().Count();
                    }
                }
            };

        [Theory]
        [MemberData(nameof(NextTestData))]
        public void Next_GeneratesCorrectPasswords(IEnumerable<IPasswordConfiguration> configurations, Func<string, bool> predicate)
        {
            var itemsCount = 1000;

            var sut = this.CreateSut();

            foreach (var configuration in configurations)
            {
                sut.Use(configuration);
            }

            var results = sut.Next(itemsCount);
            var resultStrings = results.Select(item => new string(item.ToArray()));

            foreach (var result in resultStrings)
            {
                Assert.True(predicate.Invoke(result));
            }
        }

        protected static bool IsInRange(int value, int min, int max) =>
            value >= min && value <= max;

        #endregion Next

        #region Usage

        [Fact]
        public void Usage()
        {
            var configuration = new PasswordConfiguration();
            configuration.UseItems("ABC");
            configuration.UseItems('D', 'E', 'F');
            configuration.UseDigits();
            configuration.UseMinCount(4);
            configuration.UseMaxCount(8);
            configuration.UseUnique(false);

            // or

            var configuration2 = new PasswordConfiguration()
                .UseItems("GHIJ")
                .UseItems('K', 'L')
                .UseDigits()
                .UseMinCount(4)
                .UseMaxCount(8)
                .UseUnique(true);

            // or

            var configuration3 = new PasswordConfiguration()
                .UseFromJson
                (
                    "{ "
                    + "\"Items\": \"@#$%\", "
                    + "\"MinCount\": 4, "
                    + "\"MaxCount\": 8, "
                    + "\"UniqueOnly\": false"
                    + " }"
                );


            // ABCDEFGHIJKLMNOPQRSTUVWXYZ
            configuration.UseUpperCaseLetters();

            // abcdefghijklmnopqrstuvwxyz
            configuration.UseLowerCaseLetters();

            // 0123456789
            configuration.UseDigits();

            // ()[]{}<>+-*/=&|^!~`@#$%_\\|;:'\"?,.
            configuration.UseDefaultSpecialCharacters();

            var randomGenerator = new DefaultRandomGenerator();
            var shuffler = new KnuthShuffler(randomGenerator);

            var passwordGeneratorFactory = new PasswordGeneratorFactory(randomGenerator, shuffler);

            var passwordGenerator = passwordGeneratorFactory.CreatePasswordGenerator();

            passwordGenerator.Use(configuration);

            // or

            passwordGenerator.Use(new List<IPasswordConfiguration>() { configuration2, configuration3 });

            // one password
            var password = new string(passwordGenerator.Next().ToArray());

            // 5 passwords
            var passwords = passwordGenerator.Next(5).Select(item => new string(item.ToArray())).ToList();

            Assert.Equal(configuration.MinCount + configuration2.MinCount + configuration3.MinCount, passwordGenerator.MinCount);
            Assert.Equal(configuration.MaxCount + configuration2.MaxCount + configuration3.MaxCount, passwordGenerator.MaxCount);

            foreach (var pass in passwords.Concat(new[] { password }))
            {
                Assert.True(pass.Length >= passwordGenerator.MinCount && pass.Length <= passwordGenerator.MaxCount);
            }

            var passwordGeneratorCopy = passwordGenerator.Copy()
                .Use(configuration3.Copy());

            var anotherPassword = new string(passwordGeneratorCopy.Next().ToArray());
            var anotherPasswords = passwordGeneratorCopy.Next(5).Select(item => new string(item.ToArray())).ToList();

            Assert.Equal(configuration.MinCount + configuration2.MinCount + configuration3.MinCount + configuration3.MinCount, passwordGeneratorCopy.MinCount);
            Assert.Equal(configuration.MaxCount + configuration2.MaxCount + configuration3.MaxCount + configuration3.MaxCount, passwordGeneratorCopy.MaxCount);

            foreach (var pass in anotherPasswords.Concat(new[] { anotherPassword }))
            {
                Assert.True(pass.Length >= passwordGeneratorCopy.MinCount && pass.Length <= passwordGeneratorCopy.MaxCount);
            }
        }

        #endregion Usage
    }
}
