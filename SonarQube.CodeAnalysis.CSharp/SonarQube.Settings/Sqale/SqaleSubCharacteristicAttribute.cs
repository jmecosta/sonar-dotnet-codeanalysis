using System;

namespace SonarQube.CodeAnalysis.CSharp.SonarQube.Settings.Sqale
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SqaleSubCharacteristicAttribute : Attribute
    {
        public SqaleSubCharacteristic SubCharacteristic { get; set; }

        public SqaleSubCharacteristicAttribute(SqaleSubCharacteristic subCharacteristic)
        {
            SubCharacteristic = subCharacteristic;
        }
    }
}