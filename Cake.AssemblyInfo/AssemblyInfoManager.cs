using System;
using System.Collections.Generic;
using System.Linq;
using Cake.Core;
using Cake.Core.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Cake.AssemblyInfo
{
    public class AssemblyInfoManager : IAssemblyInfoManager
    {
        private readonly IFileSystem _cakeFileSystem;
        private readonly ICakeEnvironment _cakeEnvironment;

        public AssemblyInfoManager(IFileSystem cakeContext, ICakeEnvironment cakeEnvironment)
        {
            _cakeFileSystem = cakeContext;
            _cakeEnvironment = cakeEnvironment;
        }

        public void EditAssemblyInfo(FilePath assemblyInfoPath)
        {
            if (assemblyInfoPath == null)
            {
                throw new ArgumentNullException(nameof(assemblyInfoPath));
            }

            if (assemblyInfoPath.IsRelative)
            {
                assemblyInfoPath = assemblyInfoPath.MakeAbsolute(_cakeEnvironment);
            }

            var assemblyInfoReader = new AssemblyInfoReader(_cakeFileSystem, _cakeEnvironment);
            using (var reader = assemblyInfoReader.Reader(assemblyInfoPath))
            {
                var cs = reader.ReadToEnd();
                SyntaxTree tree = CSharpSyntaxTree.ParseText(cs);

                var root = (CompilationUnitSyntax)tree.GetRoot();
                var compilation = CSharpCompilation.Create("test").AddSyntaxTrees(tree);

                // get references to add
                compilation = compilation.AddReferences(GetGlobalReferences());

                var model = compilation.GetSemanticModel(tree);


                // get the attributes
                var attributes = compilation.Assembly.GetAttributes().Where(x => x.AttributeClass.ToString().Contains("Foo"));
                foreach (var attribute in attributes)
                {
                    var ctorArgs = attribute.ConstructorArguments;
                    var propArgs = attribute.NamedArguments;
                    
                }
            }
        }

        private static IEnumerable<MetadataReference> GetGlobalReferences()
        {
            var assemblies = new[]
            {
                typeof(Object).Assembly, //mscorlib
            };

            var refs = from a in assemblies
                select MetadataReference.CreateFromFile(a.Location);

            return refs.ToList();
        }
    }

    public interface IAssemblyInfoManager
    {
        void EditAssemblyInfo(FilePath assemblyInfoPath);
    }
}
