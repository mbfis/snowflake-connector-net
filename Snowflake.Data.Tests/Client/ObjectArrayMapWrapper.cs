using System.Collections.Generic;

namespace Snowflake.Data.Tests.Client
{
    public class ObjectArrayMapWrapper
    {
        public Identity ObjectValue { get; set; }
        public List<string> ListValue { get; set; }
        public string[] ArrayValue { get; set; }
        public Dictionary<int, int> MapValue { get; set; }
    }
}
