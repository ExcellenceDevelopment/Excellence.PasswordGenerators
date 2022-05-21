#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators.Core](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators.Core 'Excellence.PasswordGenerators.Core')

## IPasswordConfiguration Interface

The password configuration.

```csharp
public interface IPasswordConfiguration :
Excellence.Randomizers.Core.IConfigurationCore<char, Excellence.PasswordGenerators.Core.IPasswordConfiguration>
```

Derived  
&#8627; [PasswordConfiguration](PasswordConfiguration.md 'Excellence.PasswordGenerators.PasswordConfiguration')

Implements [Excellence.Randomizers.Core.IConfigurationCore&lt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IConfigurationCore-2 'Excellence.Randomizers.Core.IConfigurationCore`2')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IConfigurationCore-2 'Excellence.Randomizers.Core.IConfigurationCore`2')[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IConfigurationCore-2 'Excellence.Randomizers.Core.IConfigurationCore`2')
### Methods

<a name='Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseDefaultSpecialCharacters()'></a>

## IPasswordConfiguration.UseDefaultSpecialCharacters() Method

Adds default special characters.

```csharp
Excellence.PasswordGenerators.Core.IPasswordConfiguration UseDefaultSpecialCharacters();
```

#### Returns
[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')  
The current instance.

<a name='Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseDigits()'></a>

## IPasswordConfiguration.UseDigits() Method

Adds digits.

```csharp
Excellence.PasswordGenerators.Core.IPasswordConfiguration UseDigits();
```

#### Returns
[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')  
The current instance.

<a name='Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseLowerCaseLetters()'></a>

## IPasswordConfiguration.UseLowerCaseLetters() Method

Adds lower case letters.

```csharp
Excellence.PasswordGenerators.Core.IPasswordConfiguration UseLowerCaseLetters();
```

#### Returns
[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')  
The current instance.

<a name='Excellence.PasswordGenerators.Core.IPasswordConfiguration.UseUpperCaseLetters()'></a>

## IPasswordConfiguration.UseUpperCaseLetters() Method

Adds upper case letters.

```csharp
Excellence.PasswordGenerators.Core.IPasswordConfiguration UseUpperCaseLetters();
```

#### Returns
[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')  
The current instance.