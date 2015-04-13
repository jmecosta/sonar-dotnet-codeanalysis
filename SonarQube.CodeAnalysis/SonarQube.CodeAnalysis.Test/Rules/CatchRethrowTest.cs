using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class CatchRethrowTest
    {
        [TestMethod]
        public void CatchRethrow()
        {
            Verifier.Verify(@"TestCases\CatchRethrow.cs", new CatchRethrow());
        }
    }
}
