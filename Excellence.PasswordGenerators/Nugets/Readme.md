<!-- omit in toc -->
# Password generators

<!-- omit in toc -->
## Table of contents

- [Overview](#overview)
- [Configurations](#configurations)
    - [Default methods](#default-methods)
- [Password generators](#password-generators)
    - [Create a password generator](#create-a-password-generator)
    - [Add configurations](#add-configurations)
    - [Generate passwords](#generate-passwords)
    - [`Copy`](#copy)

<br/>

## Overview

Password generators are used to create passwords be defined rules.

Every password generator use configurations that define the rules that are used during password generation.

<br />

## Configurations

Configurations are created using default constructor. Then configuration methods define the rules.

**Example**:

```csharp
var configuration = new PasswordConfiguration();
configuration.UseItems("ABC");
configuration.UseItems('D', 'E', 'F');
configuration.UseDigits();
configuration.UseMinCount(4);
configuration.UseMaxCount(8);
configuration.UseUnique(false);

// or

var configuration2 = new PasswordConfiguration()
    .UseItems("GHIJ")
    .UseItems('K', 'L')
    .UseDigits()
    .UseMinCount(4)
    .UseMaxCount(8)
    .UseUnique(true);

// or

var configuration3 = new PasswordConfiguration()
    .UseFromJson
    (
        "{ "
        + "\"Items\": \"@#$%\", "
        + "\"MinCount\": 4, "
        + "\"MaxCount\": 8, "
        + "\"UniqueOnly\": false"
        + " }"
    );
```

<br/>

### Default methods

`PasswordConfiguration` has methods to add predefined characters.

**Example**:

```csharp
 // ABCDEFGHIJKLMNOPQRSTUVWXYZ
configuration.UseUpperCaseLetters();

// abcdefghijklmnopqrstuvwxyz
configuration.UseLowerCaseLetters();

// 0123456789
configuration.UseDigits();

// ()[]{}<>+-*/=&|^!~`@#$%_\\|;:'\"?,.
configuration.UseDefaultSpecialCharacters();
```

<br/>

## Password generators

When configurations are ready a password generator can create passwords.

<br/>

### Create a password generator

Password generators can be created using the `IPasswordGeneratorFactory`.

**Example**:

```csharp
var randomGenerator = new DefaultRandomGenerator();
var shuffler = new KnuthShuffler(randomGenerator);

var passwordGeneratorFactory = new PasswordGeneratorFactory(randomGenerator, shuffler);

var passwordGenerator = passwordGeneratorFactory.CreatePasswordGenerator();
```

<br/>

### Add configurations

Configurations are added using `Use` methods.

Every configuration defines its own rules so the password generator generates the passwords that match the rules of every configuration.

**Example**:

```csharp
passwordGenerator.Use(configuration);

// or

passwordGenerator.Use(new List<IPasswordConfiguration>() { configuration2, configuration3 });
```

<br/>

### Generate passwords

`Next` methods generate the passwords.

**Example**:

```csharp
// one password
var password = passwordGenerator.Next();

// 5 passwords
var passwords = passwordGenerator.Next(5);
```

<br/>

### `Copy`

`Copy` copies the password generator with all configurations and returns a new password generator instance. Instances are independent and adding configuration to one password
generator does not affect another one.

**Example**:

```csharp
var passwordGeneratorCopy = passwordGenerator.Copy()
                .Use(configuration3.Copy());

var anotherPassword = passwordGeneratorCopy.Next();
var anotherPasswords = passwordGeneratorCopy.Next(5);
```

<br/>
