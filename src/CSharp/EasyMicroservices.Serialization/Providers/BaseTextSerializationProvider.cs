using EasyMicroservices.Serialization.Interfaces;
using System;

namespace EasyMicroservices.Serialization.Providers
{
    /// <summary>
    ///  base string implimentaion
    /// </summary>
    public abstract class BaseTextSerializationProvider : BaseProvider, ITextSerialization
    {

        /// <summary>
        /// Deserialize from string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract T Deserialize<T>(string value);
        /// <summary>
        /// Serialize to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract string Serialize(object value);
    }
}
