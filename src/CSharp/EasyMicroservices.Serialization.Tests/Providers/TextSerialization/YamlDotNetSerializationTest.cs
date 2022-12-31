// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using EasyMicroservices.Serialization.YamlDotNet.Providers;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerialization
{
    public class YamlDotNetSerializationTest : BaseTextSerializationTest
    {
        public YamlDotNetSerializationTest() : base(new YamlDotNetProvider())
        {
        }
        /// <summary>
        /// yml output format is different from json format
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        [Theory]
        [ClassData(typeof(YamlDotNetSerializeDataTest))]
        public override async Task Serialize(string name, int age, Gender gender, string expected)
        {
            await base.Serialize(name, age, gender, expected);
        }
        /// <summary>
        /// yml support json format for deserialization
        /// </summary>
        /// <param name="json"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <returns></returns>  
        [Theory]
        [ClassData(typeof(YamlDotNetDeserializeDataTest))]
        public override async Task Deserialize(string json, string name, int age, Gender gender)
        {
            await base.Deserialize(json, name, age, gender);
        }
    }
    /// <summary>
    /// data for test Serialize in yml
    /// </summary>
    public class YamlDotNetSerializeDataTest : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "Mahdi", 30, Gender.Male, $"Name: Mahdi{Environment.NewLine}Age: 30{Environment.NewLine}Gender: Male{Environment.NewLine}" };
            yield return new object[] { "Maryam", 15, Gender.Female, $"Name: Maryam{Environment.NewLine}Age: 15{Environment.NewLine}Gender: Female{Environment.NewLine}" };
            yield return new object[] { "ali", 15, Gender.None, $"Name: ali{Environment.NewLine}Age: 15{Environment.NewLine}Gender: None{Environment.NewLine}" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    /// <summary>
    /// data for test Deserialize in yml
    /// </summary>
    public class YamlDotNetDeserializeDataTest : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            /// yml format
            yield return new object[] { $"Name: Mahdi{Environment.NewLine}Age: 30{Environment.NewLine}Gender: Male{Environment.NewLine}", "Mahdi", 30, Gender.Male };
            yield return new object[] { $"Name: Maryam{Environment.NewLine}Age: 15{Environment.NewLine}Gender: Female{Environment.NewLine}", "Maryam", 15, Gender.Female };
            yield return new object[] { $"Name: ali{Environment.NewLine}Age: 15{Environment.NewLine}Gender: None{Environment.NewLine}", "ali", 15, Gender.None };
            /// json format
            yield return new object[] { "{\"Name\":\"Mahdi\",\"Age\":30,\"Gender\":1}", "Mahdi", 30, Gender.Male };
            yield return new object[] { "{\"Name\":\"Maryam\",\"Age\":15,\"Gender\":2}", "Maryam", 15, Gender.Female };
            yield return new object[] { "{\"Name\":\"ali\",\"Age\":15,\"Gender\":0}", "ali", 15, Gender.None };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
