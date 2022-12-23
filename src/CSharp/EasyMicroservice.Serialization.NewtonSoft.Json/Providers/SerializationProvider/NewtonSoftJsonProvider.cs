using EasyMicroservice.Serialization.Providers.SerializationProvider;
using Newtonsoft.Json;
using System;

namespace EasyMicroservice.Serialization.NewtonSoft.Json.Providers.SerializationProvider
{
    /// <summary>
    /// 
    /// </summary>
    public class NewtonSoftJsonProvider : BaseTextSerializationProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public override T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
