namespace OSGi.NET.Utils
{
    internal class CustomAssemblyResolver : BaseAssemblyResolver
    {
        public delegate AssemblyDefinition ResolveAssemblyDefinitionDelegate(string assemblyName);

        private readonly ResolveAssemblyDefinitionDelegate resolveAssemblyDefinition;

        public CustomAssemblyResolver(ResolveAssemblyDefinitionDelegate resolveAssemblyDefinition)
        {
            this.resolveAssemblyDefinition = resolveAssemblyDefinition;
        }

        public override AssemblyDefinition Resolve(AssemblyNameReference assemblyNameReference)
        {
            AssemblyDefinition assemblyDefinition = null;
            if (resolveAssemblyDefinition != null)
                assemblyDefinition = resolveAssemblyDefinition(assemblyNameReference.FullName);
            if (assemblyDefinition == null)
                assemblyDefinition = base.Resolve(assemblyNameReference);
            return assemblyDefinition;
        }
    }
}
