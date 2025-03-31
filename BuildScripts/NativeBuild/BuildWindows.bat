cd  %~dp0

set CurrentDir=%~dp0
set BuildTool=rbt
set PluginRoot="%CurrentDir%../../UnityDemo/ReArchDemo/Assets/ReArch/ReArchNative"
set NativeProjectRoot="%CurrentDir%../../ReArchNative"

call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Windows.rsp @Debug.rsp --UnityPluginRoot %PluginRoot% --TargetArch x86

if %ERRORLEVEL% NEQ 0 (
    echo Build failed!
    pause
    exit /b %ERRORLEVEL%
)

call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Windows.rsp @Debug.rsp --UnityPluginRoot %PluginRoot% --TargetArch x64

if %ERRORLEVEL% NEQ 0 (
    echo Build failed!
    pause
    exit /b %ERRORLEVEL%
)

@REM call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Windows.rsp @Release.rsp --UnityPluginRoot %PluginRoot% --TargetArch x86
@REM call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Windows.rsp @Release.rsp --UnityPluginRoot %PluginRoot% --TargetArch x64