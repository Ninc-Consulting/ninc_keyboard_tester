FROM mcr.microsoft.com/dotnet/sdk:6.0-windowsservercore-ltsc2019

WORKDIR /app

RUN REG ADD "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock" /t REG_DWORD /f /v "AllowDevelopmentWithoutDevLicense" /d "1"

COPY ./WindowsApplicationDriver_1.2.1.msi .

RUN WindowsApplicationDriver_1.2.1.msi
SHELL ["powershell", "-command", "C:/Program Files(x86)/Windows Application Driver/WinAppDriver.exe"]
