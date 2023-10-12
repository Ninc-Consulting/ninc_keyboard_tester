# ninc_keyboard_tester
Test the functionality of your keyboard.
NINC Keboard Tester is a winforms application that listens for registered key strokes and displays which key was detected.

## Install dotnet SDK
The .NET CLI is required to run dotnet commands and is included in the .NET SDK. The .NET SDK can be installed either with the Windows Package Manager or with an installation file.
#### With Windows Package Manager
Windows Package Manager winget command-line tool is available on Windows 11 and modern versions of Windows 10 as a part of the App Installer.
Get App Installer from the [Microsoft Store](https://apps.microsoft.com/detail/9NBLGGH4NNS1?hl=en-us&gl=US). After App Installer is installed, run the following command to install .NET SDK 6.
```
winget install Microsoft.DotNet.SDK.6
```
#### With an installation file
Download the installation file from https://dotnet.microsoft.com/en-us/download/dotnet/6.0

## Build
Use the following command to build the application as a standalone .exe file.
```
dotnet publish <RelativePath>/KeyboardTester.csproj --self-contained --runtime win-x64 --output <RelativePath>
```
The KeyboardTester.exe file that was created in the output folder can then be copied/moved and used in isolation.

## Running tests

