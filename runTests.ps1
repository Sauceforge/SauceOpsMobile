<#
.SYNOPSIS

This program is used to install NUnit3 console and run functional tests

.DESCRIPTION

install NUnit3 console and run functional tests

#>
$SolutionDir = "."
$ProjectDir = "$SolutionDir\SauceOps"
$PackagesDir = "$ProjectDir\packages"
$OutDir = "$ProjectDir\bin\Release"

# Install NUnit Test Runner
$nuget = "$SolutionDir\.nuget\nuget.exe"
& $nuget install NUnit.Runners -ExcludeVersion -o $PackagesDir

# Set nunit path test runner
$nunit = "$PackagesDir\NUnit.ConsoleRunner\tools\nunit3-console.exe"

#Find tests in OutDir
$tests = SauceOps.dll

# Run NUnit3 tests
& $nunit $tests --noheader --framework=net-4.7 --work=$OutDir