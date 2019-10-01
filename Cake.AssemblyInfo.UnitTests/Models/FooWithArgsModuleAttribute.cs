using System;

namespace Cake.AssemblyInfo.UnitTests.Models
{
    public class FooWithArgsModuleAttribute : Attribute
    {
        public FooWithArgsModuleAttribute(bool someBool, string someString)
        {
            SomeString = someString;
            SomeBool = someBool;
        }

        public bool SomeBool { get; set; }
        public string SomeString { get; set; }


    }
}
