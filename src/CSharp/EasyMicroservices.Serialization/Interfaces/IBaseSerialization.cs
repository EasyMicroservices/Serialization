using System;

namespace EasyMicroservices.Serialization.Interfaces
{
    /// <summary>
    /// general serialization method defines here
    /// </summary>
    public interface IBaseSerialization
    {
        /// <summary>
        /// can convert check which type is supported for serialization
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        bool CanConvert(Type objectType);
    }
}
