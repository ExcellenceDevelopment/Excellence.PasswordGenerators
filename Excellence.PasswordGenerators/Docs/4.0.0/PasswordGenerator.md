#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators 'Excellence.PasswordGenerators')

## PasswordGenerator Class

The password generator.

```csharp
public class PasswordGenerator : Excellence.Randomizers.Core.RandomizerCore<char, Excellence.PasswordGenerators.Core.IPasswordConfiguration, Excellence.PasswordGenerators.Core.IPasswordGenerator>,
Excellence.PasswordGenerators.Core.IPasswordGenerator,
Excellence.Randomizers.Core.IRandomizerCore<char, Excellence.PasswordGenerators.Core.IPasswordConfiguration, Excellence.PasswordGenerators.Core.IPasswordGenerator>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Excellence.Randomizers.Core.RandomizerCore&lt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.RandomizerCore-3 'Excellence.Randomizers.Core.RandomizerCore`3')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.RandomizerCore-3 'Excellence.Randomizers.Core.RandomizerCore`3')[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.RandomizerCore-3 'Excellence.Randomizers.Core.RandomizerCore`3')[IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.RandomizerCore-3 'Excellence.Randomizers.Core.RandomizerCore`3') &#129106; PasswordGenerator

Implements [IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator'), [Excellence.Randomizers.Core.IRandomizerCore&lt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')
### Constructors

<a name='Excellence.PasswordGenerators.PasswordGenerator.PasswordGenerator(Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator,Excellence.Randomizers.Core.Shufflers.IShuffler)'></a>

## PasswordGenerator(IRandomGenerator, IShuffler) Constructor

Creates a new instance of [PasswordGenerator](PasswordGenerator.md 'Excellence.PasswordGenerators.PasswordGenerator').

```csharp
public PasswordGenerator(Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator randomGenerator, Excellence.Randomizers.Core.Shufflers.IShuffler shuffler);
```
#### Parameters

<a name='Excellence.PasswordGenerators.PasswordGenerator.PasswordGenerator(Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator,Excellence.Randomizers.Core.Shufflers.IShuffler).randomGenerator'></a>

`randomGenerator` [Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator 'Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator')

The random generator.

<a name='Excellence.PasswordGenerators.PasswordGenerator.PasswordGenerator(Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator,Excellence.Randomizers.Core.Shufflers.IShuffler).shuffler'></a>

`shuffler` [Excellence.Randomizers.Core.Shufflers.IShuffler](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.Shufflers.IShuffler 'Excellence.Randomizers.Core.Shufflers.IShuffler')

The shuffler.