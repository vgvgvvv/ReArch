#!/bin/bash

cd $(dirname $0)

CurrentDir=$(cd $(dirname $0); pwd)
BuildTool=rbt
PluginRoot="$CurrentDir/../../UnityDemo/ReArchDemo/Assets/ReArch/ReArchNative"
NativeProjectRoot="$CurrentDir/../../ReArchNative"

chmod +x $BuildTool
$BuildTool --ProjectRoot $NativeProjectRoot @Common.rsp @iOS.rsp @Debug.rsp --UnityPluginRoot $PluginRoot --TargetArch arm64

# $BuildTool --ProjectRoot $NativeProjectRoot @Common.rsp @iOS.rsp @Release.rsp --UnityPluginRoot $PluginRoot --TargetArch arm64