#if (!NET45)
using EasyMicroservice.Serialization.Providers.SerializationProvider;
using System;
using System.Text.Json;

namespace EasyMicroservice.Serialization.System.Text.Json.Providers
{
    /// <summary>
    /// /
    /// </summary>

    public class SystemTextJsonBinaryProvider : BaseBinarySerializationProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override T Deserialize<T>(ReadOnlySpan<byte> reader)
        {
            return JsonSerializer.Deserialize<T>(reader);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override ReadOnlySpan<byte> Serialize(object value)
        {
            return JsonSerializer.SerializeToUtf8Bytes(value);
        }
    }
}
#endif