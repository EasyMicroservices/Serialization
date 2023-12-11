using System;
using EasyMicroservices.Serialization.Interfaces;

namespace EasyMicroservices.Serialization.Providers
{
    /// <summary>
    /// base binary implimentaion
    /// </summary>
    public abstract class BinarySerializationBaseProvider : BaseProvider, IBinarySerializationProvider
    {
        /// <summary>
        /// Deserialize from byte
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        public abstract T Deserialize<T>(ReadOnlySpan<byte> reader);
        /// <summary>
        /// Serialize to byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract ReadOnlySpan<byte> Serialize<T>(T value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ReadOnlySpan<byte> SerializeToBytes<T>(T value)
        {
            return Serialize(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override T DeserializeFromBytes<T>(ReadOnlySpan<byte> bytes)
        {
            return Deserialize<T>(bytes);
        }
    }
}
