// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
        [InlineData("Mahdi", 30, Gender.Male, "Name: Mahdi\r\nAge: 30\r\nGender: Male\r\n")]
        [InlineData("Maryam", 15, Gender.Female, "Name: Maryam\r\nAge: 15\r\nGender: Female\r\n")]
        [InlineData("ali", 15, Gender.None, "Name: ali\r\nAge: 15\r\nGender: None\r\n")]
        public override async Task Serilize(string name, int age, Gender gender, string expected)
        {
            await base.Serilize(name, age, gender, expected);
        }
        /// <summary>
        /// yml support json format for deserilizing
        /// </summary>
        /// <param name="json"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        /// json format
        [InlineData("{\"Name\":\"Mahdi\",\"Age\":30,\"Gender\":1}", "Mahdi", 30, Gender.Male)]
        [InlineData("{\"Name\":\"Maryam\",\"Age\":15,\"Gender\":2}", "Maryam", 15, Gender.Female)]
        [InlineData("{\"Name\":\"ali\",\"Age\":15,\"Gender\":0}", "ali", 15, Gender.None)]
        /// yml format
        [InlineData("Name: Mahdi\r\nAge: 30\r\nGender: Male\r\n", "Mahdi", 30, Gender.Male)]
        [InlineData("Name: Maryam\r\nAge: 15\r\nGender: Female\r\n", "Maryam", 15, Gender.Female)]
        [InlineData("Name: ali\r\nAge: 15\r\nGender: None\r\n", "ali", 15, Gender.None)]
        [Theory]
        public override async Task Deserilize(string json, string name, int age, Gender gender)
        {
            await base.Deserilize(json, name, age, gender);
        }
    }
}
