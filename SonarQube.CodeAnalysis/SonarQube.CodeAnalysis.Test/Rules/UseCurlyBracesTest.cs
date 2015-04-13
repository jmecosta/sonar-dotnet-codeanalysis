using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class UseCurlyBracesTest
    {
        [TestMethod]
        public void UseCurlyBraces()
        {
            Verifier.Verify(@"TestCases\UseCurlyBraces.cs", new UseCurlyBraces());
        }
    }
}
