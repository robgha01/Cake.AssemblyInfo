using System;
using System.Collections.Generic;
using System.Text;
using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Testing;
using NSubstitute;

namespace Cake.AssemblyInfo.UnitTests.Fixtures
{
    public class AssemblyInfoManagerFixture
    {
        public FakeFileSystem FileSystem { get; set; }
        public ICakeEnvironment Environment { get; set; } 
        public FilePath Path { get; set; }
        public bool CreateAssemblyInfo { get; set; }

        public AssemblyInfoManagerFixture()
        {
            Environment = Substitute.For<ICakeEnvironment>();
            Environment.WorkingDirectory.Returns("/Working");
            FileSystem = new FakeFileSystem(Environment);
            FileSystem.CreateDirectory(Environment.WorkingDirectory);

            // Set fixture values.
            Path = new FilePath("./output.cs");
            CreateAssemblyInfo = true;
        }

        public void WithAssemblyInfoContents(string assemblyInfoContents)
        {
            FileSystem.CreateFile("/Working/output.cs").SetContent(assemblyInfoContents);
        }

        public void EditAssemblyInfo(FilePath assemblyInfoPath)
        {
            var assemblyInfoManager = new AssemblyInfoManager(FileSystem, Environment);
            assemblyInfoManager.EditAssemblyInfo(assemblyInfoPath);
        }
    }
}
