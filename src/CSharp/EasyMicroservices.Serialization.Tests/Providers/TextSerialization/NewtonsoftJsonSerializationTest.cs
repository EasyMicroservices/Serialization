using EasyMicroservices.Serialization.Newtonsoft.Json.Providers;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerialization
{
    public class NewtonsoftJsonSerializationTest : BaseTextSerilizationTest
    {
        public NewtonsoftJsonSerializationTest() : base(new NewtonsoftJsonProvider())
        {
        }
    }
}
