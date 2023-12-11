using System;
using EasyMicroservices.Serialization.MemoryPack.Providers;
using EasyMicroservices.Serialization.Options;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public static class MemoryPackExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static SerializationOption UseMemoryPack(this SerializationOption options)
        {
            options.ThrowIfNull(nameof(options));
            SerializationOptionBuilder.UseBinarySerialization(() => new MemoryPackProvider());
            return options;
        }
    }
}
