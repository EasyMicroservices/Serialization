using System;
using EasyMicroservices.Serialization.Interfaces;

namespace EasyMicroservices.Serialization.Providers
{
    /// <summary>
    /// base binary implimentaion
    /// </summary>
    public abstract class BaseBinarySerializationProvider : BaseProvider, IBinarySerialization
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
        public abstract ReadOnlySpan<byte> Serialize(object value);
    }
}
