using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace UniversalWindows.Extensions.JsonExtensions
{
    public class CustomJsonWriter : JsonTextWriter
    {
        private readonly Dictionary<string, string> _backwardMappings;

        public CustomJsonWriter(TextWriter writer, Dictionary<string, string> backwardMappings) : base(writer)
        {
            _backwardMappings = backwardMappings;
        }

        public override void WritePropertyName(string name)
        {
            base.WritePropertyName(_backwardMappings[name]);
        }
    }
}