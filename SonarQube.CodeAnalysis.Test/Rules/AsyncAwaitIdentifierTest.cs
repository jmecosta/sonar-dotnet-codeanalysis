using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class AsyncAwaitIdentifierTest
    {
        [TestMethod]
        public void AsyncAwaitIdentifier()
        {
            Verifier.Verify(@"TestCases\AsyncAwaitIdentifier.cs", new AsyncAwaitIdentifier());
        }
    }
}
