#if (!NET45)

using EasyMicroservices.Serialization.System.Text.Json.Providers;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerialization
{
    public class SystemTextJsonSerializationTest : BaseTextSerilizationTest
    {
        public SystemTextJsonSerializationTest() : base(new SystemTextJsonProvider())
        {
        }
    }
}
#endif
