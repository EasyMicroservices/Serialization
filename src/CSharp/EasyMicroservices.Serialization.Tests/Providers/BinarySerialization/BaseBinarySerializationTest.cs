using System.Buffers;
using System.Linq;
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
        public IBinarySerializationProvider _provider { get; }
        /// <summary>
        ///
        /// </summary>
        /// <param name="provider"></param>
        public BaseBinarySerializationTest(IBinarySerializationProvider provider)
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
        public virtual void Serialize(string name, int age, Gender gender)
        {
            //Arrange
            var request = new ClassToSerialize()
            {
                Name = name,
                Age = age,
                Gender = gender
            };

            //Act
            var result = _provider.Serialize(request);

            //Assert
            Assert.NotEqual(0, result.Length);

            var deserializedBytes = _provider.Deserialize<ClassToSerialize>(result);

            Assert.Equal(request.Age, deserializedBytes.Age);
            Assert.Equal(request.Name, deserializedBytes.Name);
            Assert.Equal(request.Gender, deserializedBytes.Gender);

        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="arrayLength"></param>
        public virtual void DeserializeSimpleByteArray(int arrayLength)
        {
            //Arange
            var sourceBytes = Enumerable.Range(0, arrayLength).Select(i => unchecked((byte)i)).ToArray(); // long byte array
            var request = _provider.Serialize(sourceBytes);

            //Act
            var deserializedBytes = _provider.Deserialize<byte[]>(request);

            //Assert
            Assert.NotNull(deserializedBytes);
            Assert.Equal(sourceBytes.Length, deserializedBytes.Length);
            Assert.Equal(sourceBytes, deserializedBytes);
        }

    }
}
