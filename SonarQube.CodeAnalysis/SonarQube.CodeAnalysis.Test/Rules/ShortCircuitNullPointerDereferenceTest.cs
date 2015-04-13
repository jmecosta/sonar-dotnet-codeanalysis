using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class ShortCircuitNullPointerDereferenceTest
    {
        [TestMethod]
        public void ShortCircuitNullPointerDereference()
        {
            Verifier.Verify(@"TestCases\ShortCircuitNullPointerDereference.cs", new ShortCircuitNullPointerDereference());
        }
    }
}
