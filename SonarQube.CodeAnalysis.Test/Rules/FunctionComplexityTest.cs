using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class FunctionComplexityTest
    {
        [TestMethod]
        public void FunctionComplexity()
        {
            var diagnostic = new FunctionComplexity {Maximum = 3};
            Verifier.Verify(@"TestCases\FunctionComplexity.cs", diagnostic);
        }
    }
}
