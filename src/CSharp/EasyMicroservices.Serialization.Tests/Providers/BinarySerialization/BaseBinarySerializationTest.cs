using EasyMicroservices.Serialization.Interfaces;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using Xunit;
using System.Buffers;
using System.Linq;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="expectedLength"></param>
        public virtual void Serilize(string name, int age, Gender gender, int expectedLength)
        {
            var request = new ClassToSerialize()
            {
                Name = name,
                Age = age,
                Gender = gender
            };

            var result = _provider.Serialize(request);

            Assert.NotEqual(0, result.Length);
            Assert.Equal(expectedLength, result.Length);

            var deserializedBytes = _provider.Deserialize<ClassToSerialize>(result);

            Assert.True(request.Age == deserializedBytes.Age && request.Name == deserializedBytes.Name && request.Gender == deserializedBytes.Gender);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayLength"></param>
        public virtual void DeserializeSimpleByteArray(int arrayLength)
        {
            var sourceBytes = Enumerable.Range(0, arrayLength).Select(i => unchecked((byte)i)).ToArray(); // long byte array

            var request = _provider.Serialize(sourceBytes);

            var deserializedBytes = _provider.Deserialize<byte[]>(request);
            Assert.NotNull(deserializedBytes);
            Assert.Equal(sourceBytes.Length, deserializedBytes.Length);
            Assert.Equal(sourceBytes, deserializedBytes);
        }

    }
}
