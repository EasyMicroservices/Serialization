using EasyMicroservices.Serialization.Interfaces;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.BinarySerialization
{
    public abstract class BaseBinarySerializationTest
    {
        /// <summary>
        /// binary serilaze provider
        /// </summary>
        public IBinarySerialization _provider { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        public BaseBinarySerializationTest(IBinarySerialization provider)
        {
            _provider = provider;
        }

        [Theory]
        [InlineData("Mahdi", 30, Gender.Male)]
        [InlineData("Maryam", 15, Gender.Female)]
        [InlineData("ali", 15, Gender.None)]
        public void Serilize(string name, int age, Gender gender)
        {
            var request = new ClassToSerialize()
            {
                Name = name,
                Age = age,
                Gender = gender
            };
            var result = _provider.Serialize(request);

          
        }

    }
}
