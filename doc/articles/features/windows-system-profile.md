﻿---
uid: Uno.Features.WSProfile
---

# Windows.System.Profile APIs

> [!TIP]
> This article covers Uno-specific information for `Windows.System.Profile` namespace. For a full description of the feature and instructions on using it, consult the UWP documentation: https://learn.microsoft.com/en-us/uwp/api/windows.system.profile

* The `Windows.System.Profile` namespace provides classes for accessing and managing information about the device.

## `AnalyticsInfo`

### `DeviceForm` property

The `DeviceForm` property now returns string from the following set:

- Mobile
- Tablet
- Television
- Car
- Watch
- VirtualReality
- Desktop
- Unknown

In case of `WebAssembly` this property currently always returns `Unknown` as there is no reliable way to check for device form factor via JavaScript.

## `VersionInfo.DeviceFamily`

This string is in the form of `OSType.DeviceForm` where `OSType` is:

- **Android** - `Android`
- **iOS/iPadOS** - `iOS`
- **WASM** - `Browser`

## `VersionInfo.DeviceFamilyVersion`

This returns the "OS version" the app is running on. Values are the following:

- **Android** - `Build.VERSION.Release`
- **iOS** - `UIDevice.CurrentDevice.SystemVersion`
- **WASM** - returns the full user agent string (`navigator.userAgent`)

Again note, that on WASM the `userAgent` can easily be spoofed by malicious users.
