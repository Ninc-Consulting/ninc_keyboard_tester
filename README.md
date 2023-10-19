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
docker build -t my-image -f <RelativePath>/KeyboardTester/Dockerfile_publish <RelativePath>/ninc_keyboad_tester/KeyboardTester
docker run --rm --name my-container --mount type=mount,source=<AbsolutPath>/ninc_keyboard_tester/KeyboardTester,target=C:/app my-image
```
The KeyboardTester.exe file is created in the ninc_keyboard_tester/KeyboardTester/artifacts folder.

## Checking style and linting

You can use either the .NET CLI or Docker to do a static code analysis as shown below.
#### .NET CLI
```
dotnet format <RelativePath>/KeyboardTester.sln --verbosity minimal --verify-no-changes
```

#### Docker
```
docker build -t my-image -f <RelativePath>/Dockerfile_lint <RelativePath>/ninc_keyboad_tester/KeyboardTester
docker run --rm --name my-container --mount type=mount,source=<AbsolutPath>/ninc_keyboard_tester/KeyboardTester,target=C:/app my-image
```

## Running tests

### Unit Tests

Unit tests can be run by using either the .NET CLI or Docker. When the tests are finished, an html file of the results are created in the UnitTests/TestResults folder.

#### Using the .NET CLI
```
dotnet test <RelativePath>/UnitTests.csproj --logger "html"
```

#### Using Docker
```
docker build -t my-image -f <RelativePath>/UnitTests/Dockerfile_test <RelativePath>/ninc_keyboad_tester/KeyboardTester
docker run --rm --name my-container --mount type=mount,source=<AbsolutPath>/ninc_keyboard_tester/KeyboardTester,target=C:/app my-image
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