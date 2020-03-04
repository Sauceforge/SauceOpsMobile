<#
.SYNOPSIS

This program is used to install NUnit3 Console

.DESCRIPTION

Install NUnit3 Console

#>
Install-PackageProvider -Name NuGet -Force -Scope CurrentUser
Install-Module -Name NUnit.Console -Force -Verbose -Scope CurrentUser