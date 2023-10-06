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