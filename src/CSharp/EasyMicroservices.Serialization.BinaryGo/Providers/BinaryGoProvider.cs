using BinaryGo.Binary;
using BinaryGo.Binary.Deserialize;
using EasyMicroservices.Serialization.Providers;
using System;

namespace EasyMicroservices.Serialization.BinaryGo.Providers
{
    /// <summary>
    /// 
    /// </summary>
    public class BinaryGoProvider : BaseBinarySerializationProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        public override T Deserialize<T>(ReadOnlySpan<byte> reader)
        {
            return BinaryDeserializer.NormalInstance.Deserialize<T>(reader);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ReadOnlySpan<byte> Serialize(object value)
        {
            return BinarySerializer.NormalInstance.Serialize(value);
        }
    }
}
