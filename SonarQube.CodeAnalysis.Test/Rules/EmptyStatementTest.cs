using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class EmptyStatementTest
    {
        [TestMethod]
        public void EmptyStatement()
        {
            Verifier.Verify(@"TestCases\EmptyStatement.cs", new EmptyStatement());
        }
    }
}
