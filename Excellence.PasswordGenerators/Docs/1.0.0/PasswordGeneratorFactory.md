#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators 'Excellence.PasswordGenerators')

## PasswordGeneratorFactory Class

The password generator factory.

```csharp
public class PasswordGeneratorFactory :
Excellence.PasswordGenerators.Core.IPasswordGeneratorFactory
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PasswordGeneratorFactory

Implements [IPasswordGeneratorFactory](IPasswordGeneratorFactory.md 'Excellence.PasswordGenerators.Core.IPasswordGeneratorFactory')
### Constructors

<a name='Excellence.PasswordGenerators.PasswordGeneratorFactory.PasswordGeneratorFactory(Excellence.Randomizers.Core.IRandomGenerator,Excellence.Randomizers.Core.IShuffler)'></a>

## PasswordGeneratorFactory(IRandomGenerator, IShuffler) Constructor

Creates a new instance of [PasswordGeneratorFactory](PasswordGeneratorFactory.md 'Excellence.PasswordGenerators.PasswordGeneratorFactory').

```csharp
public PasswordGeneratorFactory(Excellence.Randomizers.Core.IRandomGenerator randomGenerator, Excellence.Randomizers.Core.IShuffler shuffler);
```
#### Parameters

<a name='Excellence.PasswordGenerators.PasswordGeneratorFactory.PasswordGeneratorFactory(Excellence.Randomizers.Core.IRandomGenerator,Excellence.Randomizers.Core.IShuffler).randomGenerator'></a>

`randomGenerator` [Excellence.Randomizers.Core.IRandomGenerator](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomGenerator 'Excellence.Randomizers.Core.IRandomGenerator')

The random generator.

<a name='Excellence.PasswordGenerators.PasswordGeneratorFactory.PasswordGeneratorFactory(Excellence.Randomizers.Core.IRandomGenerator,Excellence.Randomizers.Core.IShuffler).shuffler'></a>

`shuffler` [Excellence.Randomizers.Core.IShuffler](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IShuffler 'Excellence.Randomizers.Core.IShuffler')

The shuffler.
### Methods

<a name='Excellence.PasswordGenerators.PasswordGeneratorFactory.CreatePasswordGenerator()'></a>

## PasswordGeneratorFactory.CreatePasswordGenerator() Method

Creates the password generator.

```csharp
public virtual Excellence.PasswordGenerators.Core.IPasswordGenerator CreatePasswordGenerator();
```

Implements [CreatePasswordGenerator()](IPasswordGeneratorFactory.md#Excellence.PasswordGenerators.Core.IPasswordGeneratorFactory.CreatePasswordGenerator() 'Excellence.PasswordGenerators.Core.IPasswordGeneratorFactory.CreatePasswordGenerator()')

#### Returns
[IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator')  
The password generator.