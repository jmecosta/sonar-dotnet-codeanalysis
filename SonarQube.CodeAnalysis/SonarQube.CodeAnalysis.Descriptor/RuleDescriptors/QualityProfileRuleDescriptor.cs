using System.Xml.Serialization;

namespace SonarQube.CodeAnalysis.Descriptor.RuleDescriptors
{
    [XmlType("rule")]
    public class QualityProfileRuleDescriptor
    {
        public QualityProfileRuleDescriptor()
        {
            RepositoryKey = "csharpsquid";
        }
        [XmlElement("repositoryKey")]
        public string RepositoryKey { get; set; }
        [XmlElement("key")]
        public string Key { get; set; }
    }
}