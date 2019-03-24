# Xamarin Forms using MVVMCross framework to render a bottom Tab Bar

Xamarin Forms 3.x supports the rendering of a TabBar in Android natively at the bottom.

This project takes it one step further to see if MvvmCross's support for the TabbarPage works in this bottom rendering mode, espcially when navigation back and forth.

## Screenshot

### Android
<img src="imgs/droid-screenshot.png" height="400">

# Aside: Build Times in AppCenter

|Flags|Build Time|Binary Size|Startup Time|
|-----|----------|-----------|------------|
|Embed Assemblies in native Code|1 min 56 sec|15.2MB|3.8 sec|
|AOT + LLVM|3 min 1 sec|26.8MB|2.65 sec|
|Embed Assemblies + AOT + LVVM|2 min 47 sec|18.7MB|2.25 sec|

## Build Status

[![Build status](https://build.appcenter.ms/v0.1/apps/e951d7f3-b3e1-494c-8032-f866731d3a0a/branches/master/badge)](https://appcenter.ms)



