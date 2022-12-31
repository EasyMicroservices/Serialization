#if (!NET452)

using System.Threading.Tasks;
using EasyMicroservices.Serialization.System.Text.Json.Providers;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerialization
{
    public class SystemTextJsonSerializationTest : BaseTextSerializationTest
    {
        public SystemTextJsonSerializationTest() : base(new SystemTextJsonProvider())
        {
        }
        [Theory]
        [InlineData("Mahdi", 30, Gender.Male, "{\"Name\":\"Mahdi\",\"Age\":30,\"Gender\":1}")]
        [InlineData("Maryam", 15, Gender.Female, "{\"Name\":\"Maryam\",\"Age\":15,\"Gender\":2}")]
        [InlineData("ali", 15, Gender.None, "{\"Name\":\"ali\",\"Age\":15,\"Gender\":0}")]
        public override async Task Serialize(string name, int age, Gender gender, string expected)
        {
            await base.Serialize(name, age, gender, expected);
        }
        [InlineData("{\"Name\":\"Mahdi\",\"Age\":30,\"Gender\":1}", "Mahdi", 30, Gender.Male)]
        [InlineData("{\"Name\":\"Maryam\",\"Age\":15,\"Gender\":2}", "Maryam", 15, Gender.Female)]
        [InlineData("{\"Name\":\"ali\",\"Age\":15,\"Gender\":0}", "ali", 15, Gender.None)]
        [Theory]
        public override async Task Deserialize(string json, string name, int age, Gender gender)
        {
            await base.Deserialize(json, name, age, gender);
        }
    }
}
#endif
