using System;

namespace EasyMicroservices.Serialization.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBaseSerialization
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        bool CanConvert(Type objectType);

    }

}
