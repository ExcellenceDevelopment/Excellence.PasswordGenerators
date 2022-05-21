param ($configuration = "Release");

$solutionDirectoryPath = $PSCommandPath | Split-Path | Split-Path | Split-Path;
$solutionFileName = "Excellence.PasswordGenerators.sln";
$solutionFilePath = Join-Path $solutionDirectoryPath $solutionFileName;

dotnet build $solutionFilePath --configuration $configuration;