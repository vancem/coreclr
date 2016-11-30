# Official Releases and Daily Builds of CoreCLR and CoreFX components

If you are not planning on actually making bug fixes or experimenting with new features, then you probably
don't need to don't need build CoreCLR yourself, as the .NET Runtime team routinely does this for you.   

Roughly every three months, the .NET Runtime team publishes a new version of .NET Core to Nuget.   .NET Core's
official home on NuGet is 
 
 * <https://www.nuget.org/packages/Microsoft.NETCore.Runtime.CoreCLR/> 
 
and you can expect to see new versions roughly three months.   However it is also the case that the .NET 
Team publishes **daily builds** of all sorts of packages including those built by the CoreCLR and CoreFX 
repositories.  You can see what is available from

 * <https://dotnet.myget.org/gallery/dotnet-core>, and in particular you can see the builds of CoreCLR at 
 * <https://dotnet.myget.org/feed/dotnet-core/package/nuget/Microsoft.NETCore.Runtime.CoreCLR>.   
 
Thus if your goal is just to get the latest bug fixes and features, you don't need to build CoreCLR yourself you 
can simply add <https://dotnet.myget.org/F/dotnet-core/api/v3/index.json> to your Nuget Feed list. 

The version numbers for the releases following the pattern 
```
    <major>.<minor>.<buildNumberMajor>-<buildNumberMinor>
```
See [Version Numbers](VersionNumbers.md) for more on the meaning of version numbers.  

# Using the Official or Daily Builds.   

Using offiical or Daily builds works very much like using the Nuget package that you build locally.  
See [Using your .NET Core Build](UsingYourBuild.md) for those instructions.   The only differences are 

 1. You use the version of the official or Daily build you are interested in in your project.json for 
 Microsoft.NETCore.Runtime.CoreCLR.  
 2. For official builds, the appropriate Nuget feed is <https://api.nuget.org/v3/index.json> and should
 be in your Nuget.Config file already.   However for daily Build the appropriate Nuget Feed is from myget
 and so you need to add https://dotnet.myget.org/F/dotnet-core/api/v3/index.json as one of the Nuget

 ## Symbols for Official and Daily Builds

In order to debug builds, you need to have access to the symbol files (PEBs on Windows, Dwarf files on Unix)
that the debuggers and profilers need.   The Official and Daily builds folllow Nuget Standards for publishing 
symbol files by creating *.symbols.nupkg files.   When these are uploaded to the Nuget Feeds, the Nuget 
feed on Windows the Nuget servers will also act as a symbol server for any PDBs in these *.symbols.nupkg files
Thus on Windows OS you should add the following paths to your _NT_SYMBOL_PATH variable for your debuggers to
find the necessary files

  * `SRV*C:\Users\vancem\AppData\Local\Temp\symbols*https://nuget.smbsrc.net` for official releases of .NET Core.
  * `SRV*C:\Users\vancem\AppData\Local\Temp\symbols*https://dotnet.myget.org/F/dotnet-core/symbols` for daily releases of .NET Core. 

 search locations.  

# Build/Test Status of the repository

As mentioned we build the CoreCLR repository daily, and as part of that build we also run all 
the tests associted with this repository.  Below is a table of the most recent results for all
the different operating systems and architectures that we routinely build.  

If you click on the images below, you can get more details about the build (including the binaries)
and the exact test results (in case your build is failing tests and you are wondering if it is 
something affecting all builds).    

|   | Debug | Release |
|---|:-----:|:-------:|
|**CentOS 7.1**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_centos7.1.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_centos7.1)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_centos7.1.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_centos7.1)|
|**Debian 8.4**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_debian8.4.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_debian8.4)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_debian8.4.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_debian8.4)|
|**FreeBSD 10.1**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_freebsd.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_freebsd)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_freebsd.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_freebsd)|
|**openSUSE 13.2**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_opensuse13.2.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_opensuse13.2)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_opensuse13.2.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_opensuse13.2)|
|**openSUSE 42.1**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_opensuse42.1.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_opensuse42.1)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_opensuse42.1.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_opensuse42.1)|
|**OS X 10.11**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_osx.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_osx)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_osx.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_osx)|
|**Red Hat 7.2**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_rhel7.2.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_rhel7.2)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_rhel7.2.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_rhel7.2)|
|**Fedora 23**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_fedora23.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_fedora23)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_fedora23.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_fedora23)|
|**Ubuntu 14.04**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_ubuntu.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_ubuntu)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_ubuntu.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_ubuntu)|
|**Ubuntu 16.04**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_ubuntu16.04.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_ubuntu16.04)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_ubuntu16.04.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_ubuntu16.04)|
|**Ubuntu 16.10**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_ubuntu16.10.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_ubuntu16.10)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_ubuntu16.10.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_ubuntu16.10)|
|**Windows 8.1**|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/debug_windows_nt.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/debug_windows_nt)<br/>[![arm64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/arm64_cross_debug_windows_nt.svg?label=arm64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/arm64_cross_debug_windows_nt)|[![x64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/release_windows_nt.svg?label=x64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/release_windows_nt)<br/>[![arm64 status](https://img.shields.io/jenkins/s/http/dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/arm64_cross_release_windows_nt.svg?label=arm64)](http://dotnet-ci.cloudapp.net/job/dotnet_coreclr/job/master/job/arm64_cross_release_windows_nt)|
