using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Api.V2010.Account.Sms;

namespace Twilio.Tests.Api.V2010.Account.Sms {

    [TestFixture]
    public class SmsMessageTest : TwilioTest {
        [SetUp]
        public void SetUp() {
        }
    
        [Test]
        public void TestCreateRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.POST,
                                          Domains.API,
                                          "/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages.json");
            request.AddPostParam("To", Serialize(new Twilio.Types.PhoneNumber("+123456789")));
            request.AddPostParam("From", Serialize(new Twilio.Types.PhoneNumber("+987654321")));
            request.AddPostParam("Body", Serialize("body"));
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                SmsMessageResource.Create("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", new Twilio.Types.PhoneNumber("+123456789"), new Twilio.Types.PhoneNumber("+987654321"), "body").Execute(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (AggregateException ae) {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException)) {
                        throw e;
                    }
            
                    return true;
                });
            } catch (ApiException) {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestCreateResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.Created,
                                                  "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"api_version\": \"2008-08-01\",\"body\": \"n\",\"date_created\": \"Mon, 26 Jul 2010 21:46:42 +0000\",\"date_sent\": \"Mon, 26 Jul 2010 21:46:44 +0000\",\"date_updated\": \"Mon, 26 Jul 2010 21:46:44 +0000\",\"direction\": \"outbound-api\",\"from\": \"+141586753093\",\"price\": \"-0.03000\",\"price_unit\": \"USD\",\"sid\": \"SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"sent\",\"to\": \"+141586753096\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages/SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\"}"));
            
            var response = SmsMessageResource.Create("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", new Twilio.Types.PhoneNumber("+123456789"), new Twilio.Types.PhoneNumber("+987654321"), "body").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestDeleteRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.DELETE,
                                          Domains.API,
                                          "/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages/SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                SmsMessageResource.Delete("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (AggregateException ae) {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException)) {
                        throw e;
                    }
            
                    return true;
                });
            } catch (ApiException) {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestDeleteResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.NoContent,
                                                  "null"));
            
            SmsMessageResource.Delete("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
        }
    
        [Test]
        public void TestFetchRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.GET,
                                          Domains.API,
                                          "/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages/SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                SmsMessageResource.Fetch("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (AggregateException ae) {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException)) {
                        throw e;
                    }
            
                    return true;
                });
            } catch (ApiException) {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestFetchResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                                  "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"api_version\": \"2008-08-01\",\"body\": \"n\",\"date_created\": \"Mon, 26 Jul 2010 21:46:42 +0000\",\"date_sent\": \"Mon, 26 Jul 2010 21:46:44 +0000\",\"date_updated\": \"Mon, 26 Jul 2010 21:46:44 +0000\",\"direction\": \"outbound-api\",\"from\": \"+141586753093\",\"price\": \"-0.03000\",\"price_unit\": \"USD\",\"sid\": \"SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"sent\",\"to\": \"+141586753096\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages/SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\"}"));
            
            var response = SmsMessageResource.Fetch("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestReadRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.GET,
                                          Domains.API,
                                          "/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages.json");
            request.AddQueryParam("PageSize", "50");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                SmsMessageResource.Read("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (AggregateException ae) {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException)) {
                        throw e;
                    }
            
                    return true;
                });
            } catch (ApiException) {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestReadFullResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                                  "{\"end\": 0,\"first_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages.json?PageSize=1&Page=0\",\"last_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages.json?PageSize=1&Page=119771\",\"next_page_uri\": null,\"num_pages\": 119772,\"page\": 0,\"page_size\": 1,\"previous_page_uri\": null,\"sms_messages\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"api_version\": \"2010-04-01\",\"body\": \"O Slash: \\u00d8, PoP: \\ud83d\\udca9\",\"date_created\": \"Fri, 04 Sep 2015 22:54:39 +0000\",\"date_sent\": \"Fri, 04 Sep 2015 22:54:41 +0000\",\"date_updated\": \"Fri, 04 Sep 2015 22:54:41 +0000\",\"direction\": \"outbound-api\",\"from\": \"+14155552345\",\"num_segments\": \"1\",\"price\": \"-0.00750\",\"price_unit\": \"USD\",\"sid\": \"SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"sent\",\"to\": \"+14155552345\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages/SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\"}],\"start\": 0,\"total\": 119772,\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages.json?PageSize=1&Page=0\"}"));
            
            var response = SmsMessageResource.Read("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestReadEmptyResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                                  "{\"end\": 0,\"first_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages.json?PageSize=1&Page=0\",\"last_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages.json?PageSize=1&Page=119771\",\"next_page_uri\": null,\"num_pages\": 119772,\"page\": 0,\"page_size\": 1,\"previous_page_uri\": null,\"sms_messages\": [],\"start\": 0,\"total\": 119772,\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages.json?PageSize=1&Page=0\"}"));
            
            var response = SmsMessageResource.Read("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestUpdateRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.POST,
                                          Domains.API,
                                          "/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages/SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                SmsMessageResource.Update("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (AggregateException ae) {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException)) {
                        throw e;
                    }
            
                    return true;
                });
            } catch (ApiException) {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestUpdateResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                                  "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"api_version\": \"2008-08-01\",\"body\": \"n\",\"date_created\": \"Mon, 26 Jul 2010 21:46:42 +0000\",\"date_sent\": \"Mon, 26 Jul 2010 21:46:44 +0000\",\"date_updated\": \"Mon, 26 Jul 2010 21:46:44 +0000\",\"direction\": \"outbound-api\",\"from\": \"+141586753093\",\"price\": \"-0.03000\",\"price_unit\": \"USD\",\"sid\": \"SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"sent\",\"to\": \"+141586753096\",\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/SMS/Messages/SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json\"}"));
            
            var response = SmsMessageResource.Update("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "SMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    }
}