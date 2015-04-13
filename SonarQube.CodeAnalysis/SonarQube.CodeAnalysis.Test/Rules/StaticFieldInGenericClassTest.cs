using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class StaticFieldInGenericClassTest
    {
        [TestMethod]
        public void StaticFieldInGenericClass()
        {
            Verifier.Verify(@"TestCases\StaticFieldInGenericClass.cs", new StaticFieldInGenericClass());
        }
    }
}
