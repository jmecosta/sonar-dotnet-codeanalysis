using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class BreakOutsideSwitchTest
    {
        [TestMethod]
        public void BreakOutsideSwitch()
        {
            Verifier.Verify(@"TestCases\BreakOutsideSwitch.cs", new BreakOutsideSwitch());
        }
    }
}
