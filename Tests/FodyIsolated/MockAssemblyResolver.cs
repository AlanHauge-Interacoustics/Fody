using System;
using Mono.Cecil;

public class MockAssemblyResolver : AssemblyResolver
{
    public override void Dispose()
    {
    }

    public override AssemblyDefinition Resolve(string name)
    {
        throw new NotImplementedException();
    }

    public override AssemblyDefinition Resolve(AssemblyNameReference name)
    {
        throw new NotImplementedException();
    }

    public override AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters)
    {
        throw new NotImplementedException();
    }
}