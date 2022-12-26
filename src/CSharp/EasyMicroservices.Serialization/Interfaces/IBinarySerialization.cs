using System;
namespace EasyMicroservices.Serialization.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBinarySerialization : IBaseSerialization
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ReadOnlySpan<byte> Serialize(object value);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        T Deserialize<T>(ReadOnlySpan<byte> reader);

    }

}
