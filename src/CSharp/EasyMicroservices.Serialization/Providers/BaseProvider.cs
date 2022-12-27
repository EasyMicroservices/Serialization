using EasyMicroservices.Serialization.Interfaces;
using System;

namespace EasyMicroservices.Serialization.Providers
{
    /// <summary>
    /// general serialization method defines here
    /// </summary>
    public abstract class BaseProvider : IBaseSerialization
    {
        /// <summary>
        /// can convert check which type is supported for serialization
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public virtual bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
