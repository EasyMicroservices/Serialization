// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Text;
using EasyMicroservices.Serialization.Interfaces;

namespace EasyMicroservices.Serialization.Providers
{
    /// <summary>
    ///  base string implimentaion
    /// </summary>
    public abstract class TextSerializationBaseProvider : BaseProvider, ITextSerializationProvider
    {

        /// <summary>
        /// Deserialize from string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract T Deserialize<T>(string value);
        /// <summary>
        /// Serialize to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract string Serialize<T>(T value);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ReadOnlySpan<byte> SerializeToBytes<T>(T value)
        {
            return Encoding.UTF8.GetBytes(Serialize(value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public override T DeserializeFromBytes<T>(ReadOnlySpan<byte> bytes)
        {
            return Deserialize<T>(Encoding.UTF8.GetString(bytes.ToArray()));
        }
    }
}
