using System.Reflection;

namespace Light.Core.Helpers
{
    public static class AssemblyHelper
    {
        public static Assembly[] GetAllExecutingAssemblies()
        {
            var entry = Assembly.GetEntryAssembly();
            var assemblies = new List<Assembly>
        {
            Assembly.GetExecutingAssembly()
        };

            if (entry != null)
            {
                assemblies.Add(entry);

                var referencedAssemblyNames =
                    entry.GetReferencedAssemblies()
                        .Where(asmName =>
                            asmName.Name?.StartsWith("Light") ?? false);

                foreach (var referencedAssemblyName in referencedAssemblyNames)
                {
                    if (assemblies.All(asm =>
                            asm.FullName != referencedAssemblyName.FullName))
                    {
                        assemblies.Add(
                            Assembly.Load(referencedAssemblyName));
                    }
                }
            }

            return assemblies.ToArray();
        }
    }
}
