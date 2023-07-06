// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using EasyMicroservices.Serialization.Providers;
using Newtonsoft.Json;

namespace EasyMicroservices.Serialization.Newtonsoft.Json.Providers
{
    /// <summary>
    /// use NewtonsoftJson package as text serialization provider 
    /// </summary>
    public class NewtonsoftJsonProvider : TextSerializationBaseProvider
    {
        private readonly JsonSerializerSettings _options;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public NewtonsoftJsonProvider(JsonSerializerSettings options)
        {
            _options = options;
        }

        /// <summary>
        /// 
        /// </summary>
        public NewtonsoftJsonProvider()
        {
        }

        /// <summary>
        /// Deserialize from string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public override T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value, _options);
        }
        /// <summary>
        /// Serialize to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value, _options);
        }
    }
}
