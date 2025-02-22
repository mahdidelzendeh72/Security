﻿using EasyMicroservices.Security.Providers.EncriptionProviders;
using Xunit;

namespace EasyMicroservices.Security.Tests.Providers.EncriptionProviders
{
    public class AesEncryptionAlgorithmTest : BaseEncryptionAlgorithmProviderTest
    {
        public AesEncryptionAlgorithmTest() : base(new AesEncryptionAlgorithm())
        {
        }
        [Theory]
        [InlineData("Hello Easy-MicroService!","MySecurityKey")]
        [InlineData("سلام ایزی میکروسرویس","کلید امنیتی")]
        public override void Test_Symmetric_ValidData(string originalDataString, string keyString)
        {
            base.Test_Symmetric_ValidData(originalDataString, keyString);
        }
        [Theory]
        [InlineData("Hello Easy-MicroService!", "MySecurityKey1", "Invalidkey")]
        public override void Test_Symmetric_WithDifferentKey(string originalDataString, string stringKey1, string stringKey2)
        {
            base.Test_Symmetric_WithDifferentKey(originalDataString, stringKey1, stringKey2);
        }
    }
}
