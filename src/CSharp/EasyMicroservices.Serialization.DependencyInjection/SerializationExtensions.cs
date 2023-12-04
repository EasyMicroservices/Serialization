// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using EasyMicroservices.Serialization.Interfaces;
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
            return AddSerializationTransient(services, options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection AddSerializationTransient(this IServiceCollection services, Action<SerializationOption> options)
        {
            options.ThrowIfNull(nameof(options));
            options(new SerializationOption());
            services.AddTransient<ITextSerializationProvider>(service => SerializationOptionBuilder.GetTextSerialization());
            services.AddTransient<IBinarySerializationProvider>(service => SerializationOptionBuilder.GetBinarySerialization());
            return services;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection AddSerializationScoped(this IServiceCollection services, Action<SerializationOption> options)
        {
            options.ThrowIfNull(nameof(options));
            options(new SerializationOption());
            services.AddScoped<ITextSerializationProvider>(service => SerializationOptionBuilder.GetTextSerialization());
            services.AddScoped<IBinarySerializationProvider>(service => SerializationOptionBuilder.GetBinarySerialization());
            return services;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IServiceCollection AddSerializationSingleton(this IServiceCollection services, Action<SerializationOption> options)
        {
            options.ThrowIfNull(nameof(options));
            options(new SerializationOption());
            services.AddSingleton<ITextSerializationProvider>(service => SerializationOptionBuilder.GetTextSerialization());
            services.AddSingleton<IBinarySerializationProvider>(service => SerializationOptionBuilder.GetBinarySerialization());
            return services;
        }
    }
}
