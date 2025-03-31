cd  %~dp0

set CurrentDir=%~dp0
set BuildTool=rbt
set PluginRoot="%CurrentDir%../../UnityDemo/ReArchDemo/Assets/ReArch/ReArchNative"
set NativeProjectRoot="%CurrentDir%../../ReArchNative"

call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Android.rsp @Debug.rsp --UnityPluginRoot %PluginRoot% --TargetArch x86 --NDKRoot %ANDROID_NDK_ROOT%
call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Android.rsp @Debug.rsp --UnityPluginRoot %PluginRoot% --TargetArch arm32 --NDKRoot %ANDROID_NDK_ROOT%
call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Android.rsp @Debug.rsp --UnityPluginRoot %PluginRoot% --TargetArch arm64 --NDKRoot %ANDROID_NDK_ROOT%

@REM call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Android.rsp @Release.rsp --UnityPluginRoot %PluginRoot% --TargetArch x86 --NDKRoot %ANDROID_NDK_ROOT%
@REM call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Android.rsp @Release.rsp --UnityPluginRoot %PluginRoot% --TargetArch arm32 --NDKRoot %ANDROID_NDK_ROOT%
@REM call %BuildTool% --ProjectRoot %NativeProjectRoot% @Common.rsp @Android.rsp @Release.rsp --UnityPluginRoot %PluginRoot% --TargetArch arm64 --NDKRoot %ANDROID_NDK_ROOT%