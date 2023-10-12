@echo off
cd 
docker run -itd --rm --name my-container mcr.microsoft.com/dotnet/sdk:6.0 && ^
docker cp --quiet KeyboardTester/ my-container:src && ^
REM docker exec my-container dotnet build --verbosity quiet --property WarningLevel=0 src/ && ^
echo Checking style and code smells... && ^
docker exec my-container dotnet format --verbosity minimal --severity warn --verify-no-changes src/ || ^
echo [31mInconsistent style or code smell found![0m
echo Stopping container...
docker stop my-container && ^
echo Container stopped

RUN REG ADD "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock" /t REG_DWORD /f /v "AllowDevelopmentWithoutDevLicense" /d "1"
RUN DISM /Online /Add-Capability /CapabilityName:Tools.DeveloperMode.Core~~~~0.0.1.0


RUN DISM /Online /Cleanup-image /Scanhealth
RUN DISM /Online /Cleanup-image /Restorehealth
RUN DISM /Online /Add-Capability /CapabilityName:Tools.DeveloperMode.Core~~~~0.0.1.0