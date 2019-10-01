using System.Linq;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.AssemblyInfo
{
    [CakeAliasCategory("Assembly Info Addins")]
    public static class AssemblyInfoAddins
    {
        [CakeMethodAlias]
        public static void EditAssemblyInfo(this ICakeContext context, Cake.Core.IO.FilePath projectFile)
        {
            
        }
    }
}
