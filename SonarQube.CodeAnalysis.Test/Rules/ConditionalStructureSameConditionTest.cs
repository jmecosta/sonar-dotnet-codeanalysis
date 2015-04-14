using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class ConditionalStructureSameConditionTest
    {
        [TestMethod]
        public void ConditionalStructureSameCondition()
        {
            Verifier.Verify(@"TestCases\ConditionalStructureSameCondition.cs", new ConditionalStructureSameCondition());
        }
    }
}
