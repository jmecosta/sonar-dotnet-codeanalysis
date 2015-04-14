using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class TooManyParametersTest
    {
        [TestMethod]
        public void TooManyParameters()
        {
            var diagnostic = new TooManyParameters {Maximum = 3};
            Verifier.Verify(@"TestCases\TooManyParameters.cs", diagnostic);
        }
    }
}
