using System;
namespace EasyMicroservices.Serialization.Interfaces
{
    /// <summary>
    /// serializa to byte and visa versa
    /// </summary>
    public interface IBinarySerialization : IBaseSerialization
    {
        /// <summary>
        /// serializa to byte array
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ReadOnlySpan<byte> Serialize<T>(T value);
        /// <summary>
        /// Deserialize from byte
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        T Deserialize<T>(ReadOnlySpan<byte> reader);

    }

}
