# Ninc Keyboard Tester

Tests the functionality of your keyboard.
Ninc Keyboard Tester is a winforms application that listens for key strokes and displays which key was detected. This can be used to ensure that each key on a keyboard is functioning properly.

### Download Ninc Keyboard Tester

Download the latest version from https://github.com/Ninc-Consulting/ninc_keyboard_tester/releases.

### Usage

When the application is running, pressing any key on the keyboard will make the background of the detected key turn purple. When the key then is released the border of the key is turned red.
The layout of the keyboard can be changed with a drop-down menu in the application. Currently, only two keyboard layouts are supported, _Toughbook_ and _ISO 105 - SE_. _Toughbook_ is the specific keyboard layout for the Panasonic Toughbook CF-31 while _ISO 105 - SE_ is the layout of a standard ISO 105 Swedish keyboard. However, there is a third option in the drop-down menu, _All Keys_, which can be used if the keyboard is not one of the supported layouts.

### Special logic for the Fn key

The Fn key that is present on some keyboards does not trigger a key event on its own but only alters the key code of the key that is pressed together with it. Therefore, the logic for determining if the Fn key is used is specific for each keyboard layout. Which means that, while it is possible to check all other keys with the _All Keys_ layout, it is not possible to check the Fn key unless the keyboard layout is supported by the application.

## Build a standalone exe file from the source code

If you have the source code locally, you can build a standalone exe file with either Docker or the .NET CLI. If you're using Visual Studio you already have the .NET CLI installed.

### Install .NET Command-Line Interface (CLI)

The .NET CLI is required to run dotnet commands and is included in the .NET SDK. You can check if you have any sdks installed by using the command. Ninc Keyboard Tester is build on sdk 6.0.x.
```
dotnet --list-sdks
```
If you don't have sdk 6.0.x installed, it can be downloaded and installed from the [download page](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) for .NET 6, which provides Windows Installer executables.

#### Build with .NET CLI

Use the following command to build the application as a standalone exe file with the .NET CLI.
```
dotnet publish <RelativePath>/KeyboardTesterApp.csproj --self-contained --runtime win-x64 --output <RelativePath>
```
The KeyboardTesterApp.exe file that was created in the output folder specified in the _--ouput_ option can then be copied/moved and used in isolation.

### Install Docker

If you don't have Docker installed, download and install it from their [website](https://www.docker.com/get-started/).

#### Build with Docker

Executing the following commands will run a static code analysis, run all untit tests and build a standalone exe file.
```
docker build -t my-image -f <RelativePath>/KeyboardTester/Dockerfile <RelativePath>/KeyboardTester
docker run --rm --name my-container --mount type=bind,source=<AbsolutPath>/KeyboardTester,target=C:/app my-image
```
The KeyboardTesterApp.exe file is created in the KeyboardTester/artifacts folder and the result from the tests is saved as an html file in the UnitTests/TestResults folder.

## More dotnet commands

### Static code analysis

Make a static code analysis to search for code smells and style inconsistencies.

```
dotnet format <RelativePath>/KeyboardTester.sln --verbosity minimal --verify-no-changes
```

### Unit Tests

Run all unit tests and save the results as an html file in the UnitTests/TestResults folder.
```
dotnet test <RelativePath>/UnitTests.csproj --logger "html"
```

### UI Tests

The UI tests can only be run with the .NET CLI because they can not run in a container since they require an active desktop session. To run the UI tests:
1. Download and install [Microsoft Application Driver](https://github.com/Microsoft/WinAppDriver/releases)
2. Turn on developer mode
    1. Search for "developer settings" in the task bar's search box
    2. Turn on Developer Mode
3. Start WinAppDriver.exe loacated in C:\Program Files (x86)\Windows Application Driver
4. Run the following command:
```
dotnet test <RelativePath>/UITests.csproj --logger "html"
```
After the tests have finished running, an html file of the results is created in the UITests/TestResults folder.

### Check licenses of all NuGet packages

Do check all licenses used by NuGet packages in the solution, dotnet-project-licenses tool must be installed. It can be installed with the following command.
```
dotnet tool install --global dotnet-project-licenses
```
The dotnet-project-licenses tool can then be used to list all licenses in the solution as shown below. See the [documentation](https://github.com/tomchavakis/nuget-license) for more options.
```
dotnet-project-licenses -i <RelativePath>/KeyboardTester
```