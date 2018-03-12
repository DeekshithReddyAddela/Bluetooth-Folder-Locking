@echo off
rem Used to create btprox release: executables only
rem usage is "createexe.bat <dir>"
rem where "<dir>" is the full path of the target directory where the executable
rem will be placed

rem ensure that parameter specified and target directory exists
if NOT (%1)==() goto paramNotEmpty
echo Directory not specified
echo Usage: %0 "target directory"
goto end
:paramNotEmpty

rem check if destination directory exists
pushd %1 2> nul
if errorlevel 1 goto dirNotExists
goto dirExists

:dirNotExists
echo Directory does not exist
goto end

:dirExists
popd

copy bin\release\btprox.exe %1 /y
copy bin\release\btprox.exe.config %1 /y
copy bin\release\InTheHand.Net.Personal.dll %1 /y
copy bin\release\InTheHand.Net.Personal.rtf %1 /y

mkdir %1\es
copy bin\release\es\*.* %1\es /y

mkdir %1\he
copy bin\release\he\*.* %1\he /y

mkdir %1\ru
copy bin\release\ru\*.* %1\ru /y

:end
pause