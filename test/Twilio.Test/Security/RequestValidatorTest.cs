﻿using System;
using System.Collections.Specialized;
using NUnit.Framework;
using Twilio.Security;

namespace Twilio.Tests.Security
{
    [TestFixture]
    public class RequestValidatorTest
    {
        private const string Url = "https://mycompany.com/myapp.php?foo=1&bar=2";
        private const string Body = "{\"property\": \"value\", \"boolean\": true}";
        private const string BodyHash = "0a1ff7634d9ab3b95db5c9a2dfe9416e41502b283a80c7cf19632632f96e6620";
        private readonly NameValueCollection _parameters = new NameValueCollection();
        private readonly RequestValidator _validator = new RequestValidator("12345");

        public RequestValidatorTest()
        {
            // Intentionally out of alphabetical order
            _parameters.Add("CallSid", "CA1234567890ABCDE");
            _parameters.Add("From", "+14158675309");
            _parameters.Add("Digits", "1234");
            _parameters.Add("To", "+18005551212");
            _parameters.Add("Caller", "+14158675309");
        }

        [Test]
        public void TestValidateDictionary()
        {
            const string signature = "RSOYDt4T1cUTdK1PDd93/VVr8B8=";
            Assert.IsTrue(_validator.Validate(Url, _parameters, signature), "Request does not match provided signature");
        }

        [Test]
        public void TestValidateDictionaryMixedCase()
        {
            const string signature = "RSOYDt4T1cUTdK1PDd93/VVr8B8=";
            const string url = "https://MyCompany.com:1234/myapp.php?foo=1&bar=2";
            Assert.IsTrue(_validator.Validate(url, _parameters, signature), "Request should have passed validation but didn't");
        }

        [Test]
        public void TestValidateFailsWhenIncorrect()
        {
            const string signature = "NOTRSOYDt4T1cUTdK1PDd93/VVr8B8=";
            Assert.IsFalse(_validator.Validate(Url, _parameters, signature), "Request should have failed validation but didn't");
        }

        [Test]
        public void TestValidateCollection()
        {
            const string signature = "RSOYDt4T1cUTdK1PDd93/VVr8B8=";
            Assert.IsTrue(_validator.Validate(Url, _parameters, signature), "Request does not match provided signature");
        }

        [Test]
        public void TestValidateBody()
        {
            Assert.IsTrue(_validator.ValidateBody(Body, BodyHash), "Request body validation failed");
        }

        [Test]
        public void TestValidateWithBody()
        {
            const string url = Url + "&bodySHA256=" + BodyHash;
            Assert.IsTrue(_validator.Validate(url, Body, "a9nBmqA0ju/hNViExpshrM61xv4="), "Request signature or body validation failed");
        }

        [Test]
        public void TestValidateWithOnlyHash()
        {
            const string url = "https://mycompany.com/myapp.php?bodySHA256=" + BodyHash;
            Assert.IsTrue(_validator.Validate(url, Body, "y77kIzt2vzLz71DgmJGsen2scGs="), "Request signature or body validation failed");
        }

        [Test]
        public void TestValidateWithBodyWithoutSignature()
        {
            Assert.IsFalse(_validator.Validate(Url, Body, "RSOYDt4T1cUTdK1PDd93/VVr8B8="), "Request signature or body validation failed");
        }

        [Test]
        public void TestValidateRemovesPortHttps()
        {
            const string url = "https://mycompany.com:1234/myapp.php?foo=1&bar=2";
            Assert.IsTrue(_validator.Validate(url, _parameters, "RSOYDt4T1cUTdK1PDd93/VVr8B8="), "Request does not match provided signature");
        }

        [Test]
        public void TestValidateRemovesPortHttp()
        {
            const string url = "http://mycompany.com:1234/myapp.php?foo=1&bar=2";
            Assert.IsTrue(_validator.Validate(url, _parameters, "Zmvh+3yNM1Phv2jhDCwEM3q5ebU="), "Request does not match provided signature");
        }

        [Test]
        public void TestValidateAddsPortHttps()
        {
            Assert.IsTrue(_validator.Validate(Url, _parameters, "kvajT1Ptam85bY51eRf/AJRuM3w="), "Request does not match provided signature");
        }

        [Test]
        public void TestValidateAddsPortHttp()
        {
            const string url = "http://mycompany.com/myapp.php?foo=1&bar=2";
            Assert.IsTrue(_validator.Validate(url, _parameters, "0ZXoZLH/DfblKGATFgpif+LLRf4="), "Request does not match provided signature");
        }

    }
}
