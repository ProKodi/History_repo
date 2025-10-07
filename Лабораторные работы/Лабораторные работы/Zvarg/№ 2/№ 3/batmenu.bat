@echo off
:menu
cls
echo.
echo 1. Exit
echo 2. Start new cmd
echo 3. Start notepad
echo 4. Start explorer
set /p choice= Select item(1-4):

if "%choice%"=="1" (
    exit
) else if "%choice%"=="2" (
    start cmd
    goto :menu
) else if "%choice%"=="3" (
    start notepad
    goto :menu
)  else if "%choice%"=="4" (
    start explorer
    goto :menu
) else (
    echo Wrong input. 
    pause
    goto :menu
)