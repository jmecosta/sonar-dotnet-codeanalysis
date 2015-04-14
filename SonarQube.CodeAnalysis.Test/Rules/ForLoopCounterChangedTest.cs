using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class ForLoopCounterChangedTest
    {
        [TestMethod]
        public void ForLoopCounterChanged()
        {
            Verifier.Verify(@"TestCases\ForLoopCounterChanged.cs", new ForLoopCounterChanged());
        }
    }
}
