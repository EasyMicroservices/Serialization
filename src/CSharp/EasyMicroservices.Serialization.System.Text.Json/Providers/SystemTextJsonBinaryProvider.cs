using System;
using System.Text.Json;
using EasyMicroservices.Serialization.Providers;

namespace EasyMicroservices.Serialization.System.Text.Json.Providers
{
    /// <summary>
    ///  use mocrosoft SystemTextJson package as binary serialization provider 
    /// </summary>

    public class SystemTextJsonBinaryProvider : BinarySerializationBaseProvider
    {
        private readonly JsonSerializerOptions _options;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public SystemTextJsonBinaryProvider(JsonSerializerOptions options)
        {
            _options = options;
        }
        /// <summary>
        /// 
        /// </summary>
        public SystemTextJsonBinaryProvider()
        {
        }

        /// <summary>
        ///  Deserialize from byte
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override T Deserialize<T>(ReadOnlySpan<byte> reader)
        {
            return JsonSerializer.Deserialize<T>(reader, _options);
        }
        /// <summary>
        /// Serialize to byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override ReadOnlySpan<byte> Serialize<T>(T value)
        {
            return JsonSerializer.SerializeToUtf8Bytes(value, _options);
        }
    }
}
