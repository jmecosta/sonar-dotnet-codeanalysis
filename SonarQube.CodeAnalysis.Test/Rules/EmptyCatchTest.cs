using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class EmptyCatchTest
    {
        [TestMethod]
        public void EmptyCatch()
        {
            Verifier.Verify(@"TestCases\EmptyCatch.cs", new EmptyCatch());
        }
    }
}
