using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Pricing.V1.Voice;

namespace Twilio.Tests.Rest.Pricing.V1.Voice 
{

    [TestFixture]
    public class NumberTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Pricing,
                "/v1/Voice/Numbers/+987654321",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                NumberResource.Fetch(new Twilio.Types.PhoneNumber("+987654321"), client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"country\": \"United States\",\"inbound_call_price\": {\"base_price\": null,\"current_price\": null,\"number_type\": null},\"iso_country\": \"US\",\"number\": \"+987654321\",\"outbound_call_price\": {\"base_price\": \"0.015\",\"current_price\": \"0.015\"},\"price_unit\": \"USD\",\"url\": \"https://pricing.twilio.com/v1/Voice/Numbers/+987654321\"}"
                                     ));
            
            var response = NumberResource.Fetch(new Twilio.Types.PhoneNumber("+987654321"), client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}