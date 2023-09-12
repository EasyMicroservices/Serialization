// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using EasyMicroservices.Serialization.Options;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public static class SerializationExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection AddSerialization(this IServiceCollection services, Action<SerializationOption> options)
        {
            options.ThrowIfNull(nameof(options));
            options(new SerializationOption());
            services.AddScoped(service => SerializationOptionBuilder.GetTextSerialization());
            services.AddScoped(service => SerializationOptionBuilder.GetBinarySerialization());
            return services;
        }
    }
}
