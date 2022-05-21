#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators 'Excellence.PasswordGenerators')

## PasswordConfiguration Class

The password configuration.

```csharp
public class PasswordConfiguration : Excellence.Randomizers.ConfigurationCore<char, Excellence.PasswordGenerators.Core.IPasswordConfiguration>,
Excellence.PasswordGenerators.Core.IPasswordConfiguration,
Excellence.Randomizers.Core.IConfigurationCore<char, Excellence.PasswordGenerators.Core.IPasswordConfiguration>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Excellence.Randomizers.ConfigurationCore&lt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.ConfigurationCore-2 'Excellence.Randomizers.ConfigurationCore`2')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.ConfigurationCore-2 'Excellence.Randomizers.ConfigurationCore`2')[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.ConfigurationCore-2 'Excellence.Randomizers.ConfigurationCore`2') &#129106; PasswordConfiguration

Implements [IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration'), [Excellence.Randomizers.Core.IConfigurationCore&lt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IConfigurationCore-2 'Excellence.Randomizers.Core.IConfigurationCore`2')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IConfigurationCore-2 'Excellence.Randomizers.Core.IConfigurationCore`2')[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IConfigurationCore-2 'Excellence.Randomizers.Core.IConfigurationCore`2')
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