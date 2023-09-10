using System;
using EasyMicroservices.Serialization.Options;
using EasyMicroservices.Serialization.MessagePack.Providers;

namespace EasyMicroservices.Serialization
{
    /// <summary>
    /// 
    /// </summary>
    public static class MessagePackExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static SerializationOption UseMessagePack(this SerializationOption options)
        {
            options.ThrowIfNull(nameof(options));
            SerializationOptionBuilder.UseBinarySerialization(() => new MessagePackProvider());
            return options;
        }
    }
}
