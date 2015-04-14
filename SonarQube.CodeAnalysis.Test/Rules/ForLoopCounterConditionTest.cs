using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class ForLoopCounterConditionTest
    {
        [TestMethod]
        public void ForLoopCounterCondition()
        {
            Verifier.Verify(@"TestCases\ForLoopCounterCondition.cs", new ForLoopCounterCondition());
        }
    }
}
