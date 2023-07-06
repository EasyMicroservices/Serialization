// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Text.Json;
using EasyMicroservices.Serialization.Providers;

namespace EasyMicroservices.Serialization.System.Text.Json.Providers
{
    /// <summary>
    ///  use mocrosoft SystemTextJson package as text serialization provider 
    /// </summary>
    public class SystemTextJsonProvider : TextSerializationBaseProvider
    {
        private readonly JsonSerializerOptions _options;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public SystemTextJsonProvider(JsonSerializerOptions options)
        {
            _options = options;
        }

        /// <summary>
        /// 
        /// </summary>
        public SystemTextJsonProvider()
        {
        }

        /// <summary>
        /// Deserialize from string        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override T Deserialize<T>(string value)
        {
            return JsonSerializer.Deserialize<T>(value, _options);
        }
        /// <summary>
        /// Serialize to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string Serialize<T>(T value)
        {
            return JsonSerializer.Serialize(value, _options);
        }
    }
}
