/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Verify.V2.Service;

namespace Twilio.Tests.Rest.Verify.V2.Service
{

    [TestFixture]
    public class AccessTokenTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/AccessTokens",
                ""
            );
            request.AddPostParam("Identity", Serialize("identity"));
            request.AddPostParam("FactorType", Serialize(AccessTokenResource.FactorTypesEnum.Push));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                AccessTokenResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", AccessTokenResource.FactorTypesEnum.Push, client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateWithTtlResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"YKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_type\": \"push\",\"factor_friendly_name\": \"John Doe iPhone\",\"ttl\": 300,\"date_created\": \"2015-07-30T20:00:00Z\",\"token\": \"eyJ6aXAiOiJERUYiLCJraWQiOiJTQVNfUzNfX19LTVNfdjEiLCJjdHkiOiJ0d2lsaW8tZnBhO3Y9MSIsImVuYyI6IkEyNTZHQ00iLCJhbGciOiJkaXIifQ..qjltWfIgQaTwp2De.81Z_6W4kR-hdlAUvJQCbwS8CQ7QAoFRkOvNMoySEj8zEB4BAY3MXhPARfaK4Lnr4YceA2cXEmrzPKQ7bPm0XZMGYm1fqLYzAR8YAqUetI9WEdQLFytg1h4XnJnXhgd99eNXsLkpKHhsCnFkchV9eGpRrdrfB0STR5Xq0fdakomb98iuIFt1XtP0_iqxvxQZKe1O4035XhK_ELVwQBz_qdI77XRZBFM0REAzlnEOe61nOcQxkaIM9Qel9L7RPhcndcCPFAyYjxo6Ri5c4vOnszLDiHmeK9Ep9fRE5-Oz0px0ZEg_FgTUEPFPo2OHQj076H1plJnFr-qPINDJkUL_i7loqG1IlapOi1JSlflPH-Ebj4hhpBdMIcs-OX7jhqzmVqkIKWkpPyPEmfvY2-eA5Zpoo08YpqAJ3G1l_xEcHl28Ijkefj1mdb6E8POx41skAwXCpdfIbzWzV_VjFpmwhacS3JZNt9C4hVG4Yp-RGPEl1C7aJHRIUavAmoRHaXbfG20zzv5Zu0P5PcopDszzoqVfZpzc.GCt35DWTurtP-QaIL5aBSQ\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/AccessTokens/YKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = AccessTokenResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", AccessTokenResource.FactorTypesEnum.Push, client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateWithoutTtlResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"YKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_type\": \"push\",\"factor_friendly_name\": \"John Doe iPhone\",\"ttl\": 60,\"date_created\": \"2015-07-30T20:00:00Z\",\"token\": \"eyJ6aXAiOiJERUYiLCJraWQiOiJTQVNfUzNfX19LTVNfdjEiLCJjdHkiOiJ0d2lsaW8tZnBhO3Y9MSIsImVuYyI6IkEyNTZHQ00iLCJhbGciOiJkaXIifQ..qjltWfIgQaTwp2De.81Z_6W4kR-hdlAUvJQCbwS8CQ7QAoFRkOvNMoySEj8zEB4BAY3MXhPARfaK4Lnr4YceA2cXEmrzPKQ7bPm0XZMGYm1fqLYzAR8YAqUetI9WEdQLFytg1h4XnJnXhgd99eNXsLkpKHhsCnFkchV9eGpRrdrfB0STR5Xq0fdakomb98iuIFt1XtP0_iqxvxQZKe1O4035XhK_ELVwQBz_qdI77XRZBFM0REAzlnEOe61nOcQxkaIM9Qel9L7RPhcndcCPFAyYjxo6Ri5c4vOnszLDiHmeK9Ep9fRE5-Oz0px0ZEg_FgTUEPFPo2OHQj076H1plJnFr-qPINDJkUL_i7loqG1IlapOi1JSlflPH-Ebj4hhpBdMIcs-OX7jhqzmVqkIKWkpPyPEmfvY2-eA5Zpoo08YpqAJ3G1l_xEcHl28Ijkefj1mdb6E8POx41skAwXCpdfIbzWzV_VjFpmwhacS3JZNt9C4hVG4Yp-RGPEl1C7aJHRIUavAmoRHaXbfG20zzv5Zu0P5PcopDszzoqVfZpzc.GCt35DWTurtP-QaIL5aBSQ\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/AccessTokens/YKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = AccessTokenResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", AccessTokenResource.FactorTypesEnum.Push, client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/AccessTokens/YKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                AccessTokenResource.Fetch("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "YKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"YKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_type\": \"push\",\"factor_friendly_name\": \"John Doe iPhone\",\"ttl\": 60,\"date_created\": \"2015-07-30T20:00:00Z\",\"token\": \"eyJ6aXAiOiJERUYiLCJraWQiOiJTQVNfUzNfX19LTVNfdjEiLCJjdHkiOiJ0d2lsaW8tZnBhO3Y9MSIsImVuYyI6IkEyNTZHQ00iLCJhbGciOiJkaXIifQ..qjltWfIgQaTwp2De.81Z_6W4kR-hdlAUvJQCbwS8CQ7QAoFRkOvNMoySEj8zEB4BAY3MXhPARfaK4Lnr4YceA2cXEmrzPKQ7bPm0XZMGYm1fqLYzAR8YAqUetI9WEdQLFytg1h4XnJnXhgd99eNXsLkpKHhsCnFkchV9eGpRrdrfB0STR5Xq0fdakomb98iuIFt1XtP0_iqxvxQZKe1O4035XhK_ELVwQBz_qdI77XRZBFM0REAzlnEOe61nOcQxkaIM9Qel9L7RPhcndcCPFAyYjxo6Ri5c4vOnszLDiHmeK9Ep9fRE5-Oz0px0ZEg_FgTUEPFPo2OHQj076H1plJnFr-qPINDJkUL_i7loqG1IlapOi1JSlflPH-Ebj4hhpBdMIcs-OX7jhqzmVqkIKWkpPyPEmfvY2-eA5Zpoo08YpqAJ3G1l_xEcHl28Ijkefj1mdb6E8POx41skAwXCpdfIbzWzV_VjFpmwhacS3JZNt9C4hVG4Yp-RGPEl1C7aJHRIUavAmoRHaXbfG20zzv5Zu0P5PcopDszzoqVfZpzc.GCt35DWTurtP-QaIL5aBSQ\",\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/AccessTokens/YKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = AccessTokenResource.Fetch("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "YKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}