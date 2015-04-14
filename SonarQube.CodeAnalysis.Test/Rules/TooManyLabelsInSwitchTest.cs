using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class TooManyLabelsInSwitchTest
    {
        [TestMethod]
        public void TooManyLabelsInSwitch()
        {
            var diagnostic = new TooManyLabelsInSwitch {Maximum = 2};
            Verifier.Verify(@"TestCases\TooManyLabelsInSwitch.cs", diagnostic);
        }
    }
}
