#### [Excellence.PasswordGenerators](Excellence.PasswordGenerators.md 'Excellence.PasswordGenerators')
### [Excellence.PasswordGenerators.Extensions](Excellence.PasswordGenerators.md#Excellence.PasswordGenerators.Extensions 'Excellence.PasswordGenerators.Extensions')

## ServiceCollectionExtensions Class

The service collection extensions.

```csharp
public static class ServiceCollectionExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ServiceCollectionExtensions
### Methods

<a name='Excellence.PasswordGenerators.Extensions.ServiceCollectionExtensions.AddPasswordGenerators(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection)'></a>

## ServiceCollectionExtensions.AddPasswordGenerators(this IServiceCollection) Method

Adds the dependencies needed for the the password generators.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddPasswordGenerators(this Microsoft.Extensions.DependencyInjection.IServiceCollection serviceCollection);
```
#### Parameters

<a name='Excellence.PasswordGenerators.Extensions.ServiceCollectionExtensions.AddPasswordGenerators(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).serviceCollection'></a>

`serviceCollection` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The passed [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') instance with the added dependencies.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The exception when the argument is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').