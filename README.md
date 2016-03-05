# Working with Sitecore and AngularJS

This repo follows along with the blog post series on using AngularJS with Sitecore - [http://ehrendames.com/sitecore-with-angular-js-part-1](http://ehrendames.com/sitecore-with-angular-js-part-1)

This repo removes its dependency from Sitecore and Glass Mapper assemblies.  See section on Sitecore and Glass Mapper Dependency.

## Prerequistes:

###Build Tools
**Install Visual Studio 2015 Community or higher edition**

or 

If you do not want to install Visual Studio and use a preferred IDE like Visual Studio Code or Atom, you just need to install:

1. [Microsoft Build Tools 2015](https://www.microsoft.com/en-us/download/details.aspx?id=48159)
2. [NuGet - Windows x86 Commandline](https://dist.nuget.org/index.html)
3. [Microsoft .NET Framework 4.6.1](https://www.microsoft.com/en-us/download/details.aspx?id=49982)*
4. [Microsoft .NET Framework 4.6 Targeting Pack](https://www.microsoft.com/en-us/download/details.aspx?id=48136)

**May already be installed* 

The downside is that you need to maintain `csproj` files manually for classes and content to manage with MSBuild.

###NuGet

**Copy NuGet.exe and Add to Environment Path**
1. Right click on the NuGet.exe file and goto Properties
2. Unblock the executable and close the Properties window
3. Copy the `NuGet.exe` to a location you like to keep utility or tools.  I usually create a folder under `C:\Program Files (x86)` after the tool, `NuGet`, and copy the executable there.
4. Add executable to environment path:

```
$env:Path += ";C:\Program Files (x86)\NuGet"
```
If you have Command Prompt or PowerShell window open, close it and relaunch it to pick up the new environment path.

You should be able to run:
```
nuget
```

**Restore NuGet Packages for MSBuild**
MSBuild will need the following packages as they are referenced in the `csproj` file:
* MSBuild.Microsoft.VisualStudio.Web.targets
* Microsoft.CodeDom.Providers.DotNetCompilerPlatform
* Microsoft.Net.Compilers

Open Command Prompt and change directory to the root of the Git repository (not MusicStore.Web directory) and run:
```
nuget restore
```

###MSBuild

**Add MSBuild to Environment Path**

If you want to utilize Gulp for building the project or manually build the project from Command Prompt, you will need to add MSBuild to the enviroment path.

To add MSBuild to environment path:

```
$env:Path += ";C:\Program Files (x86)\MSBuild\14.0\Bin"
```

To validate the project will build:
1. Open Command Prompt
2. Change directory to the MusicStore.Web
3. Run the following MSBuild command:
```
msbuild .\MusicStore.Web.csproj /p:Configuration=Debug
```

###NPM and Gulp

1. Install [NodeJS](https://nodejs.org)
2. Install Node Packages:

```
npm install gulp-cli -g
npm install
```

##Sitecore and Glass Mapper Dependency

Since we are mocking some calls with Glass.Mapper, it is not necessary to setup any dependencies to Sitecore or Glass Mapper.  If you wanted to introduce these dependencies, you can follow the instructions below.

Typically, you can get started with:
* Sitecore.Kernel.dll
* Sitecore.ContentSearch
* Sitecore.Mvc

from your Sitecore installation and add them as references to the `csproj` file.  I usually create a lib folder at the root of the Git repository and use those locations as the reference in the project.

Additionally, you will need to install the following NuGet packages:

* Glass.Mapper.Sc

If using Visual Studio:
1. Open `Package Manager Console`
2. Validate the correct `Default project` is selected in drop down. `MusicStore.Web`.
3. Run the following commands:
```
Install-Package Glass.Mapper.Sc
```
Alternatively, you can right click on the `MusicStore.Web` project and select `Manage NuGet Packages` and find the package to install.

For more information on `Package Manager Console`, see [https://docs.nuget.org/consume/package-manager-console](https://docs.nuget.org/consume/package-manager-console)

To manually do this:
1. Update `packages.config` under `MusicStore.Web` folder by adding:
```
<package id="Glass.Mapper.Sc" version="4.0.9.60" />
```
2. Open Command Prompt or PowerShell and change directory to `MusicStore.Web` and run:
```
msbuild .\MusicStore.Web.csproj /p:Configuration=Debug
```