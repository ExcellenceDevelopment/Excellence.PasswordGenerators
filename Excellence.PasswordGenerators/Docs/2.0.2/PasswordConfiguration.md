#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators 'Excellence.PasswordGenerators')

## PasswordConfiguration Class

The password configuration.

```csharp
public class PasswordConfiguration :
Excellence.PasswordGenerators.Core.IPasswordConfiguration
```

Inheritance [Excellence.Randomizers.Configurations.Core.ConfigurationCoreComplete](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Configurations.Core.ConfigurationCoreComplete 'Excellence.Randomizers.Configurations.Core.ConfigurationCoreComplete') &#129106; [Excellence.Randomizers.Core.Configurations.Core.IConfigurationCore](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.Configurations.Core.IConfigurationCore 'Excellence.Randomizers.Core.Configurations.Core.IConfigurationCore') &#129106; [Excellence.Randomizers.Core.Configurations.Core.IConfigurationCoreJsonUtils](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.Configurations.Core.IConfigurationCoreJsonUtils 'Excellence.Randomizers.Core.Configurations.Core.IConfigurationCoreJsonUtils') &#129106; PasswordConfiguration

Implements [IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')
### Methods

<a name='Excellence.PasswordGenerators.PasswordConfiguration.UseDefaultSpecialCharacters()'></a>

## PasswordConfiguration.UseDefaultSpecialCharacters() Method

Adds default special characters.

```csharp
public Excellence.PasswordGenerators.Core.IPasswordConfiguration UseDefaultSpecialCharacters();
```

Implements [UseDefaultSpecialCharacters()](IPasswordConfiguration.md#Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseDefaultSpecialCharacters() 'Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseDefaultSpecialCharacters()')

#### Returns
[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')  
The current instance.

<a name='Excellence.PasswordGenerators.PasswordConfiguration.UseDigits()'></a>

## PasswordConfiguration.UseDigits() Method

Adds digits.

```csharp
public Excellence.PasswordGenerators.Core.IPasswordConfiguration UseDigits();
```

Implements [UseDigits()](IPasswordConfiguration.md#Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseDigits() 'Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseDigits()')

#### Returns
[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')  
The current instance.

<a name='Excellence.PasswordGenerators.PasswordConfiguration.UseLowerCaseLetters()'></a>

## PasswordConfiguration.UseLowerCaseLetters() Method

Adds lower case letters.

```csharp
public Excellence.PasswordGenerators.Core.IPasswordConfiguration UseLowerCaseLetters();
```

Implements [UseLowerCaseLetters()](IPasswordConfiguration.md#Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseLowerCaseLetters() 'Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseLowerCaseLetters()')

#### Returns
[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')  
The current instance.

<a name='Excellence.PasswordGenerators.PasswordConfiguration.UseUpperCaseLetters()'></a>

## PasswordConfiguration.UseUpperCaseLetters() Method

Adds upper case letters.

```csharp
public Excellence.PasswordGenerators.Core.IPasswordConfiguration UseUpperCaseLetters();
```

Implements [UseUpperCaseLetters()](IPasswordConfiguration.md#Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseUpperCaseLetters() 'Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseUpperCaseLetters()')

#### Returns
[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')  
The current instance.