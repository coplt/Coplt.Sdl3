# Coplt.Sdl3

[![Nuget](https://img.shields.io/nuget/v/Coplt.Sdl3)](https://www.nuget.org/packages/Coplt.Sdl3/)
[![Generate Bindings](https://github.com/coplt/Coplt.Sdl3/actions/workflows/generate-bindings.yml/badge.svg)](https://github.com/coplt/Coplt.Sdl3/actions/workflows/generate-bindings.yml)
[![Build Native](https://github.com/coplt/Coplt.Sdl3/actions/workflows/build-native.yml/badge.svg)](https://github.com/coplt/Coplt.Sdl3/actions/workflows/build-native.yml)

Unsafe C# bindings for SDL3

### Packages
- [![Nuget](https://img.shields.io/nuget/v/Coplt.Sdl3)](https://www.nuget.org/packages/Coplt.Sdl3/)  
  [Coplt.Sdl3](https://www.nuget.org/packages/Coplt.Sdl3/)
  
  Managed bindings only, no automatic dependency on sdl3 native library

---

- [![Nuget](https://img.shields.io/nuget/v/Coplt.Sdl3.Native.Win.x64)](https://www.nuget.org/packages/Coplt.Sdl3.Native.Win.x64/)  
  [Coplt.Sdl3.Native.Win.x64](https://www.nuget.org/packages/Coplt.Sdl3.Native.Win.x64/)  

  `Windows` `x64` `clang`

- [![Nuget](https://img.shields.io/nuget/v/Coplt.Sdl3.Native.Win.Arm64)](https://www.nuget.org/packages/Coplt.Sdl3.Native.Win.Arm64/)  
  [Coplt.Sdl3.Native.Win.Arm64](https://www.nuget.org/packages/Coplt.Sdl3.Native.Win.Arm64/)  

  `Windows` `arm64`  `msvc`

- [![Nuget](https://img.shields.io/nuget/v/Coplt.Sdl3.Native.Linux.x64)](https://www.nuget.org/packages/Coplt.Sdl3.Native.Linux.x64/)  
  [Coplt.Sdl3.Native.Linux.x64](https://www.nuget.org/packages/Coplt.Sdl3.Native.Linux.x64/)  

  `Linux` `x64` `clang`

- [![Nuget](https://img.shields.io/nuget/v/Coplt.Sdl3.Native.Linux.Arm64)](https://www.nuget.org/packages/Coplt.Sdl3.Native.Linux.Arm64/)  
  [Coplt.Sdl3.Native.Linux.Arm64](https://www.nuget.org/packages/Coplt.Sdl3.Native.Linux.Arm64/)  

  `Linux` `arm64` `clang`

- [![Nuget](https://img.shields.io/nuget/v/Coplt.Sdl3.Native.Macos)](https://www.nuget.org/packages/Coplt.Sdl3.Native.Macos/)  
  [Coplt.Sdl3.Native.Macos](https://www.nuget.org/packages/Coplt.Sdl3.Native.Macos/)  

  `Macos` `x64 & arm64` `clang`

## Generate Bindings

```powershell
dotnet fsi ./Scripts/ExtractSdlVersion.fsx
dotnet fsi ./Scripts/ExtractSdlProps.fsx
dotnet fsi ./Scripts/PreGen.fsx
dotnet fsi ./Scripts/GenBinding.fsx
dotnet fsi ./Scripts/FixBinding.fsx
```
