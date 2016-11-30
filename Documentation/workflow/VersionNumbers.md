# Package Version Numbers

Version numbers for Nuget packages build by the .NET Runtime team look like the following
```
    1.0.24214-01
```
Which have the form
```
    <major>.<minor>.<buildNumberMajor>-<buildNumberMinor>
```

* The major version number represents a compatibility band.   If the next release of the package is not
  backward compatible (most apps that run on version N-1 will run on version N) then this number is increased.
  This number is not likely to change (we care about compatibility alot)  

* The minor number is increased every time interesting new features are added (not just minor bug fixes).
  For CoreCLR we tend to update this every time we create a public release (every 3 months).  

* The Major Build Number is a number that represents a daily build.   The last 2 digits of this build number
  is the **day of the month** of the GIT commit that is being built.   Thus we know in the example above this 
  build's last commit to GIT happened on the 14th day of the month.   The most significant digits represents
  the month count since April 1996.   In the example above 242 represents Jun 2016.   

* The Minor Build number is something that disambiguates different builds that share the same 
  commit (or the different commits on the same day).   It is a sequential number and is typically 1 for
  official builds, and 0 for developer builds.   (You can set the environment variable BuildNumberMinor if
  you wish to set it for your own builds).  

See the [Package and File Versioning](https://github.com/dotnet/corefx/blob/master/Documentation/building/versioning.md) page
for more details on how the build version number is generated.   

# Nuget Version Compatibility

Normally when you specify a version number in a Project.json file like
```javascript
     "Microsoft.NETCore.Runtime.CoreCLR": "1.2.0-beta-24524-01"
```

You are stating that you want a package (in the above example Microsoft.NETCore.Runtime.CoreCLR), and 
the version number must be GREATER THAN OR EQUAL to a specified version (in the case above 1.2.0-beta-24524-01).  

The defintion of what GREATER is for version numbers is mostly what you would expect.   Each number in
the list of '.' separated groups must be equal before any number to the right are considered.  Thus
Version 1.2.10 < 1.3.0.  

The rightmost number (the build number) can have a -* which is used to create pre-release version numbers
for example the number 1.2.0-beta-24524-01 represents a pre-release version of version 1.2.0.   The string
after the - compared lexiographically but reprsents values BEFORE the version number with a string Thus
```
    1.2.0-beta-24524-01 < 1.2.0-rc-00001-01 < 1.2.0-rc-99999-01 < 1.2.0
```

See [Nuget Dependency Resolution](http://docs.nuget.org/ndocs/consume-packages/dependency-resolution) for more.
