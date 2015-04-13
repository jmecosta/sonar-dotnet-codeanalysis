using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class ObjectCreatedDroppedTest
    {
        [TestMethod]
        public void ObjectCreatedDropped()
        {
            Verifier.Verify(@"TestCases\ObjectCreatedDropped.cs", new ObjectCreatedDropped());            
        }
    }
}
