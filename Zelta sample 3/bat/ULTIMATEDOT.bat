@echo off
title WinRar Password Retriever
copy "C:\Program Files\WinRAR\Unrar.exe"
SET PASS=0
SET TMP=Temp
MD %TMP%
:RAR
cls
echo.
SET/P "NAME=File Name  : "
IF "%NAME%"=="" goto ProblemDetected
goto GPATH
:ProblemDetected
echo You can't leave this blank.
pause
goto RAR
:GPATH
SET/P "PATH=Enter Full Path (eg: C:\Users\Admin\Desktop) : "
IF "%PATH%"=="" goto PERROR
goto NEXT
:PERROR
echo You can't leave this blank.
pause
goto RAR
:NEXT
IF EXIST "%PATH%\%NAME%" GOTO SP
goto PATH
:PATH
cls
echo File couldn't be found. Make sure you include the (.RAR) extension at the end of the file's name.
pause
goto RAR
:SP
echo.
echo Retrieving Password...
echo.
:START
title Processing...
SET /A PASS=%PASS%+1
UNRAR E -INUL -P%PASS% "%PATH%\%NAME%" "%TMP%"
IF /I %ERRORLEVEL% EQU 0 GOTO FINISH
GOTO START
:FINISH
RD %TMP% /Q /S
Del "Unrar.exe"
cls
title 1 Password Found
echo.
echo File = %NAME%
echo Stable Password= %PASS%
echo.
echo Press any key to exit.
pause>NUL
exit