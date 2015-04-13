using System;

namespace SonarQube.CodeAnalysis.CSharp.SonarQube.Settings.Sqale
{
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class SqaleRemediationAttribute : Attribute
    {
    }
}