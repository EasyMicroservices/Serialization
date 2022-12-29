using System;
using BinaryGo.Binary;
using BinaryGo.Binary.Deserialize;
using EasyMicroservices.Serialization.Providers;

namespace EasyMicroservices.Serialization.BinaryGo.Providers
{
    /// <summary>
    /// use binary go package as binary serialization provider 
    /// </summary>
    public class BinaryGoProvider : BaseBinarySerializationProvider
    {
        /// <summary>
        /// Deserialize from byte
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        public override T Deserialize<T>(ReadOnlySpan<byte> reader)
        {
            var goSerializer = new BinaryDeserializer();
            goSerializer.Options = new global::BinaryGo.Helpers.BaseOptionInfo();
            return goSerializer.Deserialize<T>(reader);
        }

        /// <summary>
        /// Serialize to byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ReadOnlySpan<byte> Serialize<T>(T value)
        {
            var goSerializer = new BinarySerializer();
            goSerializer.Options = new global::BinaryGo.Helpers.BaseOptionInfo();
            return goSerializer.Serialize<T>(value);
        }
    }
}
