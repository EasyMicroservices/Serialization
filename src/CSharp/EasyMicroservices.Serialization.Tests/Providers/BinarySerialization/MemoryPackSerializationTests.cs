// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if (NET7_0)
using System;
using EasyMicroservices.Serialization.MemoryPack.Providers;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using MemoryPack;
using MemoryPack.Formatters;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.BinarySerialization
{
    public class MemoryPackSerializationTests : BaseBinarySerializationTest
    {
        public MemoryPackSerializationTests() : base(new MemoryPackProvider())
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
        public void Serilize_ClassWithoutAttributeObject_ShouldThrowException(Type badClassType)
        {
            //Arrange
            var obj = Activator.CreateInstance(badClassType);

            //Act
            //Assert

            Assert.Throws<MemoryPackSerializationException>(() => _provider.Serialize(obj));
        }

        public class BadClassWithoutObjectAttribute
        {

        }

    }
}
#endif
