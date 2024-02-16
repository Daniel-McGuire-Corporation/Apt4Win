@echo off
REM This script has no error handling
:: Created By Andrew M
:: Script to execute WinGet with Alias "Apt"
setlocal enabledelayedexpansion
:: Args Passthrough
set "args="
for %%A in (%*) do (
    set "args=!args! %%A"
)

:: Start Pac-Man (WinGet "APT")
winget.exe %args%
:: Cleanup
endlocal
