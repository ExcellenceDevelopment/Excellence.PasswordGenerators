#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators.Core](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators.Core 'Excellence.PasswordGenerators.Core')

## IPasswordGeneratorFactory Interface

The password generator factory.

```csharp
public interface IPasswordGeneratorFactory
```

Derived  
&#8627; [PasswordGeneratorFactory](PasswordGeneratorFactory.md 'Excellence.PasswordGenerators.PasswordGeneratorFactory')
### Methods

<a name='Excellence.PasswordGenerators.Core.IPasswordGeneratorFactory.CreatePasswordGenerator()'></a>

## IPasswordGeneratorFactory.CreatePasswordGenerator() Method

Creates the password generator.

```csharp
Excellence.PasswordGenerators.Core.IPasswordGenerator CreatePasswordGenerator();
```

#### Returns
[IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator')  
The password generator.