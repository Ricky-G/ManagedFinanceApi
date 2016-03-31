using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace UniversalWindows.Extensions.JsonHelpers
{
    public class CustomJsonReader : JsonTextReader
    {
        private readonly Dictionary<string, string> _forwardMappings;

        public CustomJsonReader(TextReader reader, Dictionary<string, string> forwardMappings) : base(reader)
        {
            _forwardMappings = forwardMappings;
        }

        public override object Value => TokenType != JsonToken.PropertyName ? base.Value : _forwardMappings[base.Value.ToString()];
    }
}