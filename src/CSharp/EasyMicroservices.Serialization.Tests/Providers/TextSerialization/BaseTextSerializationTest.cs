// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;
using EasyMicroservices.Serialization.Interfaces;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerialization
{
    /// <summary>
    /// base class for test
    /// </summary>
    public abstract class BaseTextSerializationTest
    {
        /// <summary>
        /// text serilaze provider
        /// </summary>
        public ITextSerializationProvider _provider { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        public BaseTextSerializationTest(ITextSerializationProvider provider)
        {
            _provider = provider;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        public virtual Task Serialize(string name, int age, Gender gender, string expected)
        {
            var request = new ClassToSerialize()
            {
                Name = name,
                Age = age,
                Gender = gender
            };
            var result = _provider.Serialize(request);

            Assert.Equal(expected, result);
            return TaskHelper.GetCompletedTask();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public virtual Task Deserialize(string json, string name, int age, Gender gender)
        {
            var result = _provider.Deserialize<ClassToSerialize>(json);

            Assert.True(result.Name == name && result.Age == age && result.Gender == gender);
            return TaskHelper.GetCompletedTask();
        }

    }
}
