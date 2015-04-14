using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class AssignmentInsideSubExpressionTest
    {
        [TestMethod]
        public void AssignmentInsideSubExpression()
        {
            Verifier.Verify(@"TestCases\AssignmentInsideSubExpression.cs", new AssignmentInsideSubExpression());
        }
    }
}
