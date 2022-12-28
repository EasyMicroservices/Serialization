#if(!NET45)
using EasyMicroservices.Serialization.Providers;
using System;
using System.Text.Json;

namespace EasyMicroservices.Serialization.System.Text.Json.Providers
{
    /// <summary>
    ///  use mocrosoft SystemTextJson package as text serialization provider 
    /// </summary>
    public class SystemTextJsonProvider : BaseTextSerializationProvider
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
        public override string Serialize(object value)
        {
            return JsonSerializer.Serialize(value);
        }
    }
}
#endif