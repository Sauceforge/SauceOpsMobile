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

Get-ChildItem env:

# Install NUnit Test Runner
$nuget = "$SolutionDir\.nuget\nuget.exe"
& $nuget install NUnit.Runners -ExcludeVersion -o $PackagesDir

# Set nunit path test runner
$nunit = "$PackagesDir\NUnit.ConsoleRunner\tools\nunit3-console.exe"

#Find tests in OutDir
$tests = "$OutDir\SauceOps.dll"

# Run NUnit3 tests
#& $nunit $tests --noheader --framework=net-4.7 --work=$OutDir
& $nunit $tests --result:junit-selenium-testsuite.xml;transform=nunit3-junit.xslt --trace=Verbose