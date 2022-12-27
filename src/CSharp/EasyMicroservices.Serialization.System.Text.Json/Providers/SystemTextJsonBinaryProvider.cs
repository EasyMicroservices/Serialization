#if (!NET45)
using EasyMicroservices.Serialization.Providers;
using System;
using System.Text.Json;

namespace EasyMicroservice.Serialization.System.Text.Json.Providers
{
    /// <summary>
    ///  use mocrosoft SystemTextJson package as binary serialization provider 
    /// </summary>

    public class SystemTextJsonBinaryProvider : BaseBinarySerializationProvider
    {
        /// <summary>
        ///  Deserialize from byte
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
        /// Serialize to byte
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