using EasyMicroservices.Serialization.BinaryGo.Providers;
using EasyMicroservices.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyMicroservices.Serialization.Tests.Providers.BinarySerialization
{
    public class BinaryGoSerializationTest : BaseBinarySerializationTest
    {
        public BinaryGoSerializationTest() : base(new BinaryGoProvider())
        {
        }
    }
}
