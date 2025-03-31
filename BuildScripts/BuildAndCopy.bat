
@REM @echo off
echo Building ReArch project in Release mode...

cd  %~dp0
set CurrentDir=%~dp0

:: 编译项目
dotnet build "%CurrentDir%../ReArch/ReArch.csproj" -c Release

:: 检查编译是否成功
if %ERRORLEVEL% NEQ 0 (
    echo Build failed!
    pause
    exit /b %ERRORLEVEL%
)

:: 复制DLL文件到Unity项目目录
echo Copying DLL to Unity project...
copy /Y "%CurrentDir%..\ReArch\bin\Release\netstandard2.1\ReArch.dll" "%CurrentDir%..\UnityDemo\ReArchDemo\Assets\ReArch\"
copy /Y "%CurrentDir%..\ReArch\bin\Release\netstandard2.1\ReArch.pdb" "%CurrentDir%..\UnityDemo\ReArchDemo\Assets\ReArch\"

if %ERRORLEVEL% NEQ 0 (
    echo Copy failed!
    pause
    exit /b %ERRORLEVEL%
)

call "%CurrentDir%NativeBuild\BuildWindows.bat"
call "%CurrentDir%NativeBuild\BuildAndroid.bat"

echo Build and copy completed successfully!
pause
