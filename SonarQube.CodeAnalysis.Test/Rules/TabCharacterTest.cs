using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class TabCharacterTest
    {
        [TestMethod]
        public void TabCharacter()
        {
            Verifier.Verify(@"TestCases\TabCharacter.cs", new TabCharacter());
        }
    }
}
