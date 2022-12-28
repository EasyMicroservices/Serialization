using EasyMicroservices.Serialization.Newtonsoft.Json.Providers;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerilization
{
    public class NewtonsoftjsonTest : BaseTextSerilizationTest
    {
        public NewtonsoftjsonTest() : base(new NewtonsoftJsonProvider())
        {
        }
    }
}
