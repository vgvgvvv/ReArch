namespace ReArch.Core.Job;

public interface IArchetypeJob
{
    public void Execute(ref Archetype archetype);
}