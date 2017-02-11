using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Preview.Sync.Service.SyncMap;

namespace Twilio.Tests.Rest.Preview.Sync.Service.SyncMap 
{

    [TestFixture]
    public class SyncMapItemTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items/Key",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                SyncMapItemResource.Fetch("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Key", client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_by\": \"created_by\",\"data\": {},\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"key\": \"key\",\"map_sid\": \"MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"revision\": \"revision\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://preview.twilio.com/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items/key\"}"
                                     ));
            
            var response = SyncMapItemResource.Fetch("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Key", client: twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Preview,
                "/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items/Key",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                SyncMapItemResource.Delete("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Key", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));
            
            var response = SyncMapItemResource.Delete("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Key", client: twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items",
                ""
            );
            request.AddPostParam("Key", Serialize("Key"));
            request.AddPostParam("Data", Serialize("{}"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                SyncMapItemResource.Create("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Key", "{}", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_by\": \"created_by\",\"data\": {},\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"key\": \"key\",\"map_sid\": \"MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"revision\": \"revision\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://preview.twilio.com/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items/key\"}"
                                     ));
            
            var response = SyncMapItemResource.Create("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Key", "{}", client: twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                SyncMapItemResource.Read("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"items\": [],\"meta\": {\"first_page_url\": \"https://preview.twilio.com/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items?PageSize=50&Page=0\",\"key\": \"items\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://preview.twilio.com/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items?PageSize=50&Page=0\"}}"
                                     ));
            
            var response = SyncMapItemResource.Read("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"items\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_by\": \"created_by\",\"data\": {},\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"key\": \"key\",\"map_sid\": \"MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"revision\": \"revision\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://preview.twilio.com/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items/key\"}],\"meta\": {\"first_page_url\": \"https://preview.twilio.com/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items?PageSize=50&Page=0\",\"key\": \"items\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://preview.twilio.com/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items?PageSize=50&Page=0\"}}"
                                     ));
            
            var response = SyncMapItemResource.Read("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items/Key",
                ""
            );
            request.AddPostParam("Data", Serialize("{}"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                SyncMapItemResource.Update("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Key", "{}", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_by\": \"created_by\",\"data\": {},\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"key\": \"key\",\"map_sid\": \"MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"revision\": \"revision\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://preview.twilio.com/Sync/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items/key\"}"
                                     ));
            
            var response = SyncMapItemResource.Update("ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Key", "{}", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}