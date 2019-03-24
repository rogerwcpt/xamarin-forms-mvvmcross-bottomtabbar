# Xamarin Forms using MVVMCross framework to render a bottom Tab Bar

Xamarin Forms 3.6 supports the rendering of a TabBar in Android natively at the bottom.

This project takes it one step further to see if MvvmCross's support for the TabbarPage works in this mode.

# Aside: Build Times in AppCenter


|Flags|Build Time|Binary Size|Startup Time|
|-----|----------|-----------|------------|
|Embed Assemblies in native Code|1min 56sec|15.2MB|3.8sec|
|AOT + LLVM|17.6MB|3min 1 sec|26.8MB|2.65sec|
|Embed Assemblies + AOT + LVVM|2min 47sec|18.7MB|2.25sec|
