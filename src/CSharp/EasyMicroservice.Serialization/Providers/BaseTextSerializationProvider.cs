using EasyMicroservice.Serialization.Interfaces;
using System;

namespace EasyMicroservice.Serialization.Providers.SerializationProvider
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseTextSerializationProvider :BaseProvider,  ITextSerialization
    {    

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract T Deserialize<T>(string value);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract string Serialize(object value);
    }
}
