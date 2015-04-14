using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class MultilineBlocksWithoutBraceTest
    {
        [TestMethod]
        public void MultilineBlocksWithoutBrace()
        {
            Verifier.Verify(@"TestCases\MultilineBlocksWithoutBrace.cs", new MultilineBlocksWithoutBrace());
        }
    }
}
