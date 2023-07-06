// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using EasyMicroservices.Serialization.Providers;
using MessagePack;
using MessagePack.Resolvers;

namespace EasyMicroservices.Serialization.MessagePack.Providers
{
    /// <summary>
    /// use MessagePack package as binary serialization provider 
    /// </summary>
    public class MessagePackProvider : BinarySerializationBaseProvider
    {
        /// <summary>
        /// Deserialize from byte
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        public override T Deserialize<T>(ReadOnlySpan<byte> reader)
        {
            return MessagePackSerializer.Deserialize<T>(reader.ToArray(), ContractlessStandardResolver.Options);
        }


        /// <summary>
        /// serilize T to byte array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ReadOnlySpan<byte> Serialize<T>(T value)
        {
            return MessagePackSerializer.Serialize(value, ContractlessStandardResolver.Options);
        }
    }
}
