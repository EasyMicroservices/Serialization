using EasyMicroservices.Serialization.Interfaces;
using System;

namespace EasyMicroservices.Serialization.Providers
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseProvider : IBaseSerialization
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public virtual bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
