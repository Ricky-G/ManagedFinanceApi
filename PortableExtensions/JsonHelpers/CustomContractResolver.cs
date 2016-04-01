using System.Collections.Generic;
using Newtonsoft.Json.Serialization;

namespace PortableExtensions.JsonHelpers
{
    public class CustomContractResolver : DefaultContractResolver
    {
        private Dictionary<string, string> PropertyMappings { get; set; }

        public CustomContractResolver(Dictionary<string, string> propertyMapping)
        {
            PropertyMappings = propertyMapping;
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            string resolvedName = null;
            var resolved = PropertyMappings.TryGetValue(propertyName, out resolvedName);
            return (resolved) ? resolvedName : base.ResolvePropertyName(propertyName);
        }
    }
}