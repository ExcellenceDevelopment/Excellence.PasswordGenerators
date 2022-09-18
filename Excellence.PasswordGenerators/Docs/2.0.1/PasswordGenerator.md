#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators 'Excellence.PasswordGenerators')

## PasswordGenerator Class

The password generator.

```csharp
public class PasswordGenerator :
Excellence.PasswordGenerators.Core.IPasswordGenerator,
Excellence.Randomizers.Core.IRandomizerCore<char, Excellence.PasswordGenerators.Core.IPasswordConfiguration, Excellence.PasswordGenerators.Core.IPasswordGenerator>
```

Inheritance [Excellence.Randomizers.Core.RandomizerCore](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.RandomizerCore 'Excellence.Randomizers.Core.RandomizerCore') &#129106; PasswordGenerator

Implements [IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator'), [Excellence.Randomizers.Core.IRandomizerCore&lt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')
### Constructors

<a name='Excellence.PasswordGenerators.PasswordGenerator.PasswordGenerator(IRandomGenerator,IShuffler)'></a>

## PasswordGenerator(IRandomGenerator, IShuffler) Constructor

Creates a new instance of [PasswordGenerator](PasswordGenerator.md 'Excellence.PasswordGenerators.PasswordGenerator').

```csharp
public PasswordGenerator(IRandomGenerator randomGenerator, IShuffler shuffler);
```
#### Parameters

<a name='Excellence.PasswordGenerators.PasswordGenerator.PasswordGenerator(IRandomGenerator,IShuffler).randomGenerator'></a>

`randomGenerator` [Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator 'Excellence.Randomizers.Core.RandomGenerators.IRandomGenerator')

The random generator.

<a name='Excellence.PasswordGenerators.PasswordGenerator.PasswordGenerator(IRandomGenerator,IShuffler).shuffler'></a>

`shuffler` [Excellence.Randomizers.Core.Shufflers.IShuffler](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.Shufflers.IShuffler 'Excellence.Randomizers.Core.Shufflers.IShuffler')

The shuffler.