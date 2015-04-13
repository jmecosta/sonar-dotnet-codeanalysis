using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class UnnecessaryBooleanLiteralTest
    {
        [TestMethod]
        public void UnnecessaryBooleanLiteral()
        {
            Verifier.Verify(@"TestCases\UnnecessaryBooleanLiteral.cs", new UnnecessaryBooleanLiteral());
        }
    }
}
