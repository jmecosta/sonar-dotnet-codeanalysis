﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Rules;

namespace SonarQube.CodeAnalysis.Test.Rules
{
    [TestClass]
    public class IfConditionalAlwaysTrueOrFalseTest
    {
        [TestMethod]
        public void IfConditionalAlwaysTrueOrFalse()
        {
            Verifier.Verify(@"TestCases\IfConditionalAlwaysTrueOrFalse.cs", new IfConditionalAlwaysTrueOrFalse());
        }
    }
}
