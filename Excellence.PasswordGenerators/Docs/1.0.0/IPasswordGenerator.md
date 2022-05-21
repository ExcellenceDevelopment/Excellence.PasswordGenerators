#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators.Core](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators.Core 'Excellence.PasswordGenerators.Core')

## IPasswordGenerator Interface

The password generator.

```csharp
public interface IPasswordGenerator :
Excellence.Randomizers.Core.IRandomizerCore<char, Excellence.PasswordGenerators.Core.IPasswordConfiguration, Excellence.PasswordGenerators.Core.IPasswordGenerator>
```

Derived  
&#8627; [PasswordGenerator](PasswordGenerator.md 'Excellence.PasswordGenerators.PasswordGenerator')

Implements [Excellence.Randomizers.Core.IRandomizerCore&lt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[IPasswordConfiguration](IPasswordConfiguration.md 'Excellence.PasswordGenerators.Core.IPasswordConfiguration')[,](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')[IPasswordGenerator](IPasswordGenerator.md 'Excellence.PasswordGenerators.Core.IPasswordGenerator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Excellence.Randomizers.Core.IRandomizerCore-3 'Excellence.Randomizers.Core.IRandomizerCore`3')