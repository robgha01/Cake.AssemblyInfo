using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.AssemblyInfo
{
    [CakeAliasCategory("Assembly Info Addins")]
    public static class AssemblyInfoAddins
    {
        [CakeMethodAlias]
        public static void EditAssemblyInfo(this ICakeContext context, Cake.Core.IO.FilePath assemblyInfoPath)
        {
            var assemblyInfoManager = new AssemblyInfoManager(context.FileSystem, context.Environment);
            assemblyInfoManager.EditAssemblyInfo(assemblyInfoPath);
        }
    }
}
