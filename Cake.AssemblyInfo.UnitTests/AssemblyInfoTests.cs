using Cake.AssemblyInfo.UnitTests.Fixtures;
using Xunit;

namespace Cake.AssemblyInfo.UnitTests
{

    public class AssemblyInfoTests
    {
        public const string AssemblyInfoContent = @"
using System.Reflection;
using System.Runtime.InteropServices;
using System;
using Cake.AssemblyInfo.UnitTests.Models;

[assembly: AssemblyTitle(""FooProject"")]
[assembly: AssemblyDescription(""FooProject is a Foo-First solution to Bar"")]
[assembly: AssemblyCompany(""Fooder"")]
[assembly: AssemblyProduct(""FooProject"")]
[assembly: AssemblyVersion(""0.9.8.0"")]
[assembly: AssemblyFileVersion(""0.9.8.0"")]
[assembly: AssemblyInformationalVersion(""0.9.8+Branch.dev-8.1.Sha.91baf2bfd78c9da9cfd935bbe7a6c10272b5ea54"")]
[assembly: AssemblyCopyright(""Copyright (c) FooInc 1990 - 2222"")]
[assembly: AssemblyTrademark("""")]
[assembly: AssemblyConfiguration("""")]
[assembly: Guid(""2ACBE7CB-7DC7-4E27-94A0-B537B1F0296B"")]
[assembly: ComVisible(true)]
[assembly: CLSCompliant(false)]
[assembly: FooModule]
";

        [Fact]
        public void Can_Modify_Assembly_Info_File()
        {
            var fixture = new AssemblyInfoManagerFixture();
            fixture.WithAssemblyInfoContents(AssemblyInfoContent);

            fixture.EditAssemblyInfo("./output.cs");
        }
    }
}
