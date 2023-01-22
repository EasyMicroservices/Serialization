// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using EasyMicroservices.Serialization.Providers;
using MemoryPack;

namespace EasyMicroservices.Serialization.MemoryPack.Providers
{
    /// <summary>
    /// use memory pack package for fastest Serialization and deserialization
    /// </summary>
    /// <remarks>
    /// read more about memory pack 
    /// <br/>
    /// https://neuecc.medium.com/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516
    /// </remarks>
    public class MemoryPackProvider : BinarySerializationBaseProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        public override T Deserialize<T>(ReadOnlySpan<byte> reader)
        {
            return (T)MemoryPackSerializer.Deserialize(typeof(T), reader);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ReadOnlySpan<byte> Serialize<T>(T value)
        {
            return MemoryPackSerializer.Serialize(value);
        }
    }
}
