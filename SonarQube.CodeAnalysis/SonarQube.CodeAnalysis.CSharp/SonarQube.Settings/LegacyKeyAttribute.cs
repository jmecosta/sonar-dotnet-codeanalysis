using System;

namespace SonarQube.CodeAnalysis.CSharp.SonarQube.Settings
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LegacyKeyAttribute : Attribute
    {
        public string[] Keys { get; set; }

        public LegacyKeyAttribute(params string[] keys)
        {
            Keys = keys;
        }
    }
}