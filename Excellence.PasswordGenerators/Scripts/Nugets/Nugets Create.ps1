$currentDirectory = $PSCommandPath | Split-Path;
$configuration = "Release";

& (Join-Path $currentDirectory "Nuget Create PasswordGenerators.ps1") -configuration $configuration;
