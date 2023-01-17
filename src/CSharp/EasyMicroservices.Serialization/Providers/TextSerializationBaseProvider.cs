using System;
using EasyMicroservices.Serialization.Interfaces;

namespace EasyMicroservices.Serialization.Providers
{
    /// <summary>
    ///  base string implimentaion
    /// </summary>
    public abstract class TextSerializationBaseProvider : BaseProvider, ITextSerialization
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
        public abstract string Serialize<T>(T value);
    }
}
