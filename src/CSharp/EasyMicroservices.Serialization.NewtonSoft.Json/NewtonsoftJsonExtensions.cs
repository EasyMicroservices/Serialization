using System;
using EasyMicroservices.Serialization.Options;
using EasyMicroservices.Serialization.Newtonsoft.Json.Providers;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public static class NewtonsoftJsonExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static SerializationOption UseNewtonsoftJson(this SerializationOption options)
        {
            options.ThrowIfNull(nameof(options));
            SerializationOptionBuilder.UseTextSerialization(() => new NewtonsoftJsonProvider());
            return options;
        }
    }
}
