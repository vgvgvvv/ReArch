using ReBuildTool.ToolChain;

public class ReArchNativeTarget : CppTargetRule
{
    public ReArchNativeTarget()
    {
        UsedModules.Add("ReArchNativeModule");
    }
} 
