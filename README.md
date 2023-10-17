# NINC Keyboard Tester

Tests the functionality of your keyboard.
NINC Keboard Tester is a winforms application that listens for key strokes and displays which key was detected.

## Build a standalone exe file

You can build an exe file with either Docker or the .NET CLI.

### Install .NET Command-Line Interface (CLI)

The .NET CLI is required to run dotnet commands and is included in the .NET SDK. The .NET SDK can be downloaded and installed from the [download page](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) for .NET 6, which provides Windows Installer executables.

#### Build with .NET CLI

Use the following command to build the application as a standalone exe file with the .NET CLI.
```
dotnet publish <RelativePath>/KeyboardTester.csproj --self-contained --runtime win-x64 --output <RelativePath>
```
The KeyboardTester.exe file that was created in the output folder specified in the _--ouput_ option can then be copied/moved and used in isolation.

### Install Docker

Download and install Docker from their [website](https://www.docker.com/get-started/).

#### Build with Docker

Execute the following commands to build the application as a standalone exe file with Docker.
```
docker build -t my-image -f <RelativePath>/KeyboardTester/Dockerfile <RelativePath>/ninc_keyboad_tester/KeyboardTester
docker run --rm --name my-container --mount type=mount,source=<AbsolutPath>/ninc_keyboard_tester/KeyboardTester,target=C:/app my-image
```
The KeyboardTester.exe file is created in the ninc_keyboard_tester/KeyboardTester/artifacts folder.

## Running tests

### Unit Tests

Unit tests can be run by using either the .NET CLI or Docker.

#### Using the .NET CLI

Use the following command to run the unit tests and create an html file of the results in the UnitTests/TestResults folder.
```
dotnet test <RelativePath>/UnitTests.csproj --logger "html"
```

#### Using Docker

Execute the following commands to run the unit tests and create an html file of the results in the folder specified by the _\<RelativePath\>_ in the docker cp command. Note that all folders in the _\<RelativePath\>_ in the docker cp command must already exist when running the command.
```
docker build -t my-image -f <RelativePath>/UnitTests/Dockerfile <RelativePath>/ninc_keyboad_tester/KeyboardTester
docker run --rm --name my-container --mount type=mount,source=<AbsolutPath>/ninc_keyboard_tester/KeyboardTester,target=C:/app my-image
```

### UI Tests

The UI tests can only be run with the .NET CLI because they can not run in a container since they require an active desktop session. To run the UI tests:
1. Download and install [Microsoft Application Driver](https://github.com/Microsoft/WinAppDriver/releases)
2. Turn on developer mode
    1. Search for "developer settings" in the task bar search box
    2. Turn on Developer Mode
3. Start WinAppDriver.exe loacated in C:\Program Files (x86)\Windows Application Driver
4. Run the following command:
```
dotnet test <RelativePath>/UITests.csproj --logger "html"
```
After the tests have finished running, an html file of the results is created in the UITests/TestResults folder.