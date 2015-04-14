using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.CodeAnalysis.CSharp.Helpers;
using SonarQube.CodeAnalysis.CSharp.SonarQube.Settings.Sqale;

namespace SonarQube.CodeAnalysis.Test.Helpers
{
    [TestClass]
    public class EnumHelperTest
    {
        [TestMethod]
        public void ToSonarQubeString()
        {
            SqaleSubCharacteristic.ApiAbuse.ToSonarQubeString().Should().BeEquivalentTo("API_ABUSE");
        }
    }
}
