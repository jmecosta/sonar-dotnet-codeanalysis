using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class SelfAssignedVariablesTest
    {
        [TestMethod]
        public void SelfAssignedVariables()
        {
            Verifier.Verify(@"TestCases\SelfAssignedVariables.cs", new SelfAssignedVariables());
        }
    }
}
