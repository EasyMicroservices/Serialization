using System;
using EasyMicroservices.Serialization.Options;
using EasyMicroservices.Serialization.System.Text.Json.Providers;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public static class SystemTextJsonExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static SerializationOption UseSystemTextJson(this SerializationOption options)
        {
            options.ThrowIfNull(nameof(options));
            SerializationOptionBuilder.UseTextSerialization(() => new SystemTextJsonProvider());
            return options;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static SerializationOption UseSystemTextJsonBinary(this SerializationOption options)
        {
            options.ThrowIfNull(nameof(options));
            SerializationOptionBuilder.UseBinarySerialization(() => new SystemTextJsonBinaryProvider());
            return options;
        }
    }
}
