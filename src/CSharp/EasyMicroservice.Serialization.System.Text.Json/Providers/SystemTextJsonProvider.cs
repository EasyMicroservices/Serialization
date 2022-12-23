#if(!NET45)
using EasyMicroservice.Serialization.Providers.SerializationProvider;
using System;
using System.Text.Json;

namespace EasyMicroservice.Serialization.System.Text.Json.Providers
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemTextJsonProvider : BaseTextSerializationProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override T Deserialize<T>(string value)
        {
            return JsonSerializer.Deserialize<T>(value);
        }
        /// <summary>
        /// 
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