#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators 'Excellence.PasswordGenerators')

## PasswordGenerator Class

The password generator.

```csharp
public class PasswordGenerator : Excellence.Randomizers.RandomizerCore<char, Excellence.PasswordGenerators.Core.IPasswordConfiguration, Excellence.PasswordGenerators.Core.IPasswordGenerator>,
Excellence.PasswordGenerators.Core.IPasswordGenerator,
Excellence.Randomizers.Core.IRandomizerCore<char, Excellence.PasswordGenerators.Core.IPasswordConfiguration, Excellence.PasswordGenerators.Core.IPasswordGenerator>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Excellence.Randomizers.RandomizerCore&lt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.RandomizerCore-3 'Excellence.Randomizers.RandomizerCore`3')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.RandomizerCore-3 'Excellence.Randomizers.RandomizerCore`3')[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.RandomizerCore-3 'Excellence.Randomizers.RandomizerCore`3')[IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.RandomizerCore-3 'Excellence.Randomizers.RandomizerCore`3') &#129106; PasswordGenerator

Implements [IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator'), [Excellence.Randomizers.Core.IRandomizerCore&lt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')
### Constructors

<a name='Excellence.PasswordGenerators.PasswordGenerator.PasswordGenerator(Excellence.Randomizers.Core.IRandomGenerator,Excellence.Randomizers.Core.IShuffler)'></a>

## PasswordGenerator(IRandomGenerator, IShuffler) Constructor

Creates a new instance of [PasswordGenerator](PasswordGenerator.md 'Excellence.PasswordGenerators.PasswordGenerator').

```csharp
public PasswordGenerator(Excellence.Randomizers.Core.IRandomGenerator randomGenerator, Excellence.Randomizers.Core.IShuffler shuffler);
```
#### Parameters

<a name='Excellence.PasswordGenerators.PasswordGenerator.PasswordGenerator(Excellence.Randomizers.Core.IRandomGenerator,Excellence.Randomizers.Core.IShuffler).randomGenerator'></a>

`randomGenerator` [Excellence.Randomizers.Core.IRandomGenerator](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomGenerator 'Excellence.Randomizers.Core.IRandomGenerator')

The random generator.

<a name='Excellence.PasswordGenerators.PasswordGenerator.PasswordGenerator(Excellence.Randomizers.Core.IRandomGenerator,Excellence.Randomizers.Core.IShuffler).shuffler'></a>

`shuffler` [Excellence.Randomizers.Core.IShuffler](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IShuffler 'Excellence.Randomizers.Core.IShuffler')

The shuffler.