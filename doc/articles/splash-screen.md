---
uid: Uno.Development.Splashscreen
---

# How to add a Splash Screen

This article covers how to add a splash screen to your application.

> [!TIP]
> The complete source code that goes along with this guide is available in the [unoplatform/Uno.Samples](https://github.com/unoplatform/Uno.Samples) GitHub repository - [SplashScreenSample](https://github.com/unoplatform/Uno.Samples/tree/master/UI/SplashScreenSample)

## Prerequisites

# [Visual Studio for Windows](#tab/tabid-vswin)

* [Visual Studio 2019 16.3 or later](http://www.visualstudio.com/downloads/)
  * **Universal Windows Platform** workload installed
  * **Mobile Development with .NET (Xamarin)** workload installed
  * **ASP**.**NET and web** workload installed
  * [Uno Platform Extension](https://marketplace.visualstudio.com/items?itemName=unoplatform.uno-platform-addin-2022) installed

# [VS Code](#tab/tabid-vscode)

* [**Visual Studio Code**](https://code.visualstudio.com/)

* [**Mono**](https://www.mono-project.com/download/stable/)

* **.NET Core SDK**
    * [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1) (**version 3.1.8 (SDK 3.1.402)** or later)
    * [.NET Core 5.0 SDK](https://dotnet.microsoft.com/download/dotnet-core/5.0) (**version 5.0 (SDK 5.0.100)** or later)

    > Use `dotnet --version` from the terminal to get the version installed.

# [JetBrains Rider](#tab/tabid-rider)

* [**Rider Version 2020.2+**](https://www.jetbrains.com/rider/download/)
* [**Rider Xamarin Android Support Plugin**](https://plugins.jetbrains.com/plugin/12056-rider-xamarin-android-support/) (you may install it directly from Rider)

***

<br>

> [!Tip]
> For a step-by-step guide to installing the prerequisites for your preferred IDE and environment, consult the [Get Started guide](./get-started.md).

## Step 1 - Shared splash Screen image resources

1. Prepare the images of your splash screen in different resolution, eg:

    Name|Width|Height
    -|-|-
    SplashScreen.scale-100.png|216|148
    SplashScreen.scale-125.png|270|185
    SplashScreen.scale-150.png|324|222
    SplashScreen.scale-200.png|432|296
    SplashScreen.scale-300.png|648|444
    SplashScreen.scale-400.png|864|592

    Refer to [this table](#table-of-scales) for the different scales required.

    You can also just provide a single image named as `SplashScreen.png` without the `scale-000` qualifier.

    > [!NOTE]
    > Regardless if you provide a single image or multiple images, you would always refer to this image as `SplashScreen.png`.

1. Add these images under the `Assets\` folder of the `MyApp` Class Library project, right-click on each image, go to `Properties` and set their build action as `Content`.


## Step 2 - UWP

1. In the `.UWP` project, delete the old splash screen file `SplashScreen.scale-200.png` under the `Asset\` folder.

    > [!NOTE]
    > Do not confuse this with the one from `.Shared` project.

1. Open the `Package.appxmanifest` and navigate to `Visual Assets > SplashScreen`.

1. Make sure the value for `Preview Images > Splash Screen` is set to:
    ```
    Assets\SplashScreen.png
    ```
    ![uwp-splash-screen](Assets/uwp-splash-screen.JPG)

## Step 3 - Android

1. In the `.Droid` project, open `Resources/values/Styles.xml`, and add an `<item>` under the `AppTheme` style.
    ```xml
    <item name="android:windowBackground">@drawable/splash</item>
    ```

1. Navigate to `Resources/drawable`, and create a XML file named `splash.xml`:
    ```xml
    <?xml version="1.0" encoding="utf-8"?>
        <layer-list xmlns:android="http://schemas.android.com/apk/res/android">
        <item>
            <!-- background color -->
            <color android:color="#101010"/>
        </item>
        <item>
        <!-- splash image -->
            <bitmap android:src="@drawable/assets_splashscreen"
                    android:tileMode="disabled"
                    android:gravity="center" />
        </item>
    </layer-list>
    ```

    > [!IMPORTANT]
    > Before Uno.UI 4.5, the `@drawable/assets_splashscreen` source should be `@drawable/splashscreen`. See the [breaking changes section](https://github.com/unoplatform/uno/releases/tag/4.5.9) of that release.

 1. Make sure `splash.xml` is added as an `AndroidResource` in the Droid project file : `[Project-name].Droid.csproj`.
    This is not always done automatically, especially if `splash.xml` is created and added outside the IDE.
    ```xml
    <ItemGroup>
      <AndroidResource Include="Resources\drawable\splash.xml" />
    </ItemGroup>
    ```

    > [!TIP]
    > After modifying `splash.xml`, you may run into errors like these while trying to debug:
    > ```
    > Resources\drawable-mdpi\SplashScreen.png : error APT2126: file not found.
    > Resources\drawable-hdpi\SplashScreen.png : error APT2126: file not found.
    > ```
    > Simply rebuild the `.Droid` project to get rid of these error.

## Step 4 - iOS

1. In the `.iOS` project, delete the old splash screen files:
    - `Resources\SplashScreen@2x.png`
    - `Resources\SplashScreen@3x.png`
    - `LaunchScreen.storyboard`

1. Create a new `StoryBoard` named `LaunchScreen.storyboard`:
    - Right-click the `.iOS` project > Add > New Item ...
    - Visual C# > Apple > Empty Storyboard

1. In the `Toolbox` window, drag and drop a `View Controller` and then an `ImageView` inside the `View Controller`. Enable the `Is initial View Controller`-flag on the `View Controller`.

    ![`viewcontroller-imageview`](Assets/viewcontroller-imageview.png)

1. To have an image fill the screen, set your constraints as below

    ![ios-constraints](Assets/ios-constraints.png)

1. Set the `Content Mode` to `Aspect Fit`

    ![ios-content-fit](Assets/ios-content-fit.png)

1. In the `Properties > Storyboard Document` window, select the `Can be Launch Screen` checkbox.

    ![can-be-launch](Assets/can-be-launch.png)

1. Close the designer and open the `.storyboard` file.

1. Add your image path to the `Image View`

    ``` xml
    <imageView ... image="Assets/SplashScreen">
    ```

1. Open to `info.plist` and update the `UILaunchStoryboardName` value to `LaunchScreen`.

    > [!TIP]
    > iOS caches the splash screen to improve the launch time, even across re-installs. In order to see the actual changes made, you need to restart the iPhone or simulator. Alternatively, you can rename the `CFBundleIdentifier` in `info.plist` incrementally (eg: MyApp1 -> MyApp2) before each build.

## Step 5 - WebAssembly

1. In the `.WASM` project, navigate to `WasmScripts/AppManifest.js`

2. Add your splash screen image

    ```js
    var UnoAppManifest = {
        splashScreenImage: "Assets/SplashScreen.scale-200.png",
        splashScreenColor: "#0078D7",
        displayName: "SplashScreenSample"
    }
    ```

    > [!NOTE]
    > Currently, you need to set an explicit scale for the splash screen image.

The `splashScreenColor` property allows you to set the background color for the splash screen. If you want to make the splash screen theme-aware, you can omit this property or set it to `"transparent"`.

If you use the theme-aware splash screen background, you can also set the `darkThemeBackgroundColor` and `lightThemeBackgroundColor` properties to adjust the background color for each theme. Default values are `"#202020"` for dark theme and `"#F3F3F3"` for light theme.

## Table of scales

| Scale | UWP         | iOS      | Android |
|-------|:-----------:|:--------:|:-------:|
| `100` | scale-100   | @1x      | `mdpi`    |
| `125` | scale-125   | N/A      | N/A     |
| `150` | scale-150   | N/A      | `hdpi`    |
| `200` | scale-200   | @2x      | `xhdpi`   |
| `300` | scale-300   | @3x      | `xxhdpi`  |
| `400` | scale-400   | N/A      | `xxxhdpi` |

## Get the complete code

See the completed sample on GitHub: [SplashScreenSample](https://github.com/unoplatform/Uno.Samples/tree/master/UI/SplashScreenSample)

<br>

***

## Help! I'm having trouble

> [!TIP]
> If you ran into difficulties with any part of this guide, you can:
>
> * Ask for help on our [Discord channel](https://www.platform.uno/discord) - #uno-platform
> * Ask a question on [Stack Overflow](https://stackoverflow.com/questions/tagged/uno-platform) with the 'uno-platform' tag
