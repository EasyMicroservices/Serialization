using System;

namespace EasyMicroservices.Serialization.Interfaces
{
    /// <summary>
    /// general serialization method defines here
    /// </summary>
    public interface IBaseSerializationProvider
    {
        /// <summary>
        /// can convert check which type is supported for serialization
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        bool CanConvert(Type objectType);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ReadOnlySpan<byte> SerializeToBytes<T>(T value);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bytes"></param>
        /// <returns></returns>
        T DeserializeFromBytes<T>(ReadOnlySpan<byte> bytes);
    }
}
