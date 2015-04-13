using System.Collections.Immutable;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class CommentRegularExpressionTest
    {
        [TestMethod]
        public void CommentRegularExpression()
        {
            var rules = ImmutableArray.Create(
                new CommentRegularExpressionRule
                {
                    Descriptor = CSharp.Rules.CommentRegularExpression.CreateDiagnosticDescriptor("id1", ""),
                    RegularExpression = "(?i)TODO"
                });

            var diagnostic = new CommentRegularExpression {Rules = rules};
            Verifier.Verify(@"TestCases\CommentRegularExpression.cs", diagnostic);
        }
    }
}
