using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class RightCurlyBraceStartsLineTest
    {
        [TestMethod]
        public void RightCurlyBraceStartsLine()
        {
            Verifier.Verify(@"TestCases\RightCurlyBraceStartsLine.cs", new RightCurlyBraceStartsLine());
        }
    }
}
