using EasyMicroservices.Serialization.BinaryGo.Providers;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.BinarySerialization
{
    public class BinaryGoSerializationTest : BaseBinarySerializationTest
    {
        public BinaryGoSerializationTest() : base(new BinaryGoProvider())
        {
        }
        [Theory]
        [InlineData("Mahdi", 30, Gender.Male)]
        [InlineData("Maryam", 15, Gender.Female)]
        [InlineData("ali", 15, Gender.None)]
        public override void Serialize(string name, int age, Gender gender)
        {
            base.Serialize(name, age, gender);
        }
        [Theory]
        [InlineData(10)] // fixstr
        [InlineData(1000)] // str 16
        [InlineData(100000)] // str 32
        public override void DeserializeSimpleByteArray(int arrayLength)
        {
            base.DeserializeSimpleByteArray(arrayLength);
        }
    }
}
