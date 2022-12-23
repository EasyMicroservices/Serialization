using EasyMicroservice.Serialization.Interfaces;
using System;

namespace EasyMicroservice.Serialization.Providers.SerializationProvider
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseBinarySerializationProvider : BaseProvider, IBinarySerialization
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        public abstract T Deserialize<T>(ReadOnlySpan<byte> reader);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract ReadOnlySpan<byte> Serialize(object value);
    }
}
