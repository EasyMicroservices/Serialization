using System;
using System.Collections.Generic;
using System.Text;
using EasyMicroservices.Serialization.BinaryGo.Providers;
using EasyMicroservices.Serialization.Interfaces;

namespace EasyMicroservices.Serialization.Tests.Providers.BinarySerialization
{
    public class BinaryGoSerializationTest : BaseBinarySerializationTest
    {
        public BinaryGoSerializationTest() : base(new BinaryGoProvider())
        {
        }
    }
}
