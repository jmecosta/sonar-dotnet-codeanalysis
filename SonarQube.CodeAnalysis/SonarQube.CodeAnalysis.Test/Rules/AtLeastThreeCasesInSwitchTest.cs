using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class AtLeastThreeCasesInSwitchTest
    {
        [TestMethod]
        public void AtLeastThreeCasesInSwitch()
        {
            Verifier.Verify(@"TestCases\AtLeastThreeCasesInSwitch.cs", new AtLeastThreeCasesInSwitch());
        }
    }
}
