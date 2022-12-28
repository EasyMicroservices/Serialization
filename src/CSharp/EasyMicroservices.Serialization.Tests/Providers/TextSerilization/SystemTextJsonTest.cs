#if (!NET45)
using EasyMicroservices.Serialization.System.Text.Json.Providers;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerilization
{
    public class SystemTextJsonTest : BaseTextSerilizationTest
    {
        public SystemTextJsonTest() : base(new SystemTextJsonProvider())
        {
        }
    }
}
#endif
