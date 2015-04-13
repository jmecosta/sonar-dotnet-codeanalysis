using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class SwitchWithoutDefaultTest
    {
        [TestMethod]
        public void SwitchWithoutDefault()
        {
            Verifier.Verify(@"TestCases\SwitchWithoutDefault.cs", new SwitchWithoutDefault());
        }
    }
}
