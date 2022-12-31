#if (!NET452)
using System;
using System.Diagnostics.Contracts;
using EasyMicroservices.Serialization.MessagePack.Providers;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using MessagePack;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.BinarySerialization
{
    public class MessagePackSerializationTests : BaseBinarySerializationTest
    {
        public MessagePackSerializationTests() : base(new MessagePackProvider())
        {
        }

        [Theory]
        [InlineData("Mahdi", 30, Gender.Male)]
        [InlineData("Maryam", 15, Gender.Female)]
        [InlineData("ali", 15, Gender.None)]
        public void Serialize_RightClass_ShouldBeSuccess(string name, int age, Gender gender)
        {
            base.Serialize(name, age, gender);
        }

        [Theory]
        [InlineData(10)] // fixstr
        [InlineData(1000)] // str 16
        [InlineData(100000)] // str 32
        public void Deserialize_SimpleByteArray_ShoulBeSuccess(int arrayLength)
        {
            base.DeserializeSimpleByteArray(arrayLength);
        }

        [Theory]
        [InlineData(typeof(BadClassWithoutObjectAttribute))]
        [InlineData(typeof(BadClassWithoutAnyPropertyAttribute))]
        public void Serilize_ClassWithoutAttributeObject_ShouldThrowException(Type badClassType)
        {
            //Arrange
            var obj = Activator.CreateInstance(badClassType);

            //Act
            //Assert

            Assert.Throws<MessagePackSerializationException>(() => _provider.Serialize(obj));
        }

        public class BadClassWithoutObjectAttribute
        {

        }

        [MessagePackObject]
        public class BadClassWithoutAnyPropertyAttribute
        {
            public int MyProperty { get; set; }
        }

    }
}
#endif
