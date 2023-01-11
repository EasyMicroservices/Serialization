using System;
using System.Text.Json;
using EasyMicroservices.Serialization.Providers;

namespace EasyMicroservices.Serialization.System.Text.Json.Providers
{
    /// <summary>
    ///  use mocrosoft SystemTextJson package as text serialization provider 
    /// </summary>
    public class SystemTextJsonProvider : TextSerializationBaseProvider
    {
        /// <summary>
        /// Deserialize from string        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override T Deserialize<T>(string value)
        {
            return JsonSerializer.Deserialize<T>(value);
        }
        /// <summary>
        /// Serialize to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string Serialize<T>(T value)
        {
            return JsonSerializer.Serialize(value);
        }
    }
}
