@ECHO OFF

nunit3-console.exe **\$(BuildConfiguration)\SauceOps.dll --result:junit-selenium-testsuite.xml;transform=nunit3-junit.xslt --trace=Verbose