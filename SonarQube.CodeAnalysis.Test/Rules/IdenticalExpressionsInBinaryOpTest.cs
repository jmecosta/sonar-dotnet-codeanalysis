using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class IdenticalExpressionsInBinaryOpTest
    {
        [TestMethod]
        public void IdenticalExpressionsInBinaryOp()
        {
            Verifier.Verify(@"TestCases\IdenticalExpressionsInBinaryOp.cs", new IdenticalExpressionsInBinaryOp());
        }
    }
}
