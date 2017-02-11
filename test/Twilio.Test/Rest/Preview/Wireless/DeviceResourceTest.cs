using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Preview.Wireless;

namespace Twilio.Tests.Rest.Preview.Wireless 
{

    [TestFixture]
    public class DeviceTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                DeviceResource.Fetch("DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"alias\": \"alias\",\"commands_callback_method\": \"commands_callback_method\",\"commands_callback_url\": \"http://www.example.com\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"links\": {\"usage\": \"https://preview.twilio.com/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage\",\"rate_plan\": \"https://preview.twilio.com/wireless/RatePlans/WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"rate_plan_sid\": \"WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sim_identifier\": \"sim_identifier\",\"status\": \"status\",\"url\": \"https://preview.twilio.com/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));
            
            var response = DeviceResource.Fetch("DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/wireless/Devices",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                DeviceResource.Read(client: twilioRestClient);
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
                                         "{\"devices\": [],\"meta\": {\"first_page_url\": \"https://preview.twilio.com/wireless/Devices?PageSize=50&Page=0\",\"key\": \"devices\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://preview.twilio.com/wireless/Devices?PageSize=50&Page=0\"}}"
                                     ));
            
            var response = DeviceResource.Read(client: twilioRestClient);
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
                                         "{\"devices\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"alias\": \"alias\",\"commands_callback_method\": \"commands_callback_method\",\"commands_callback_url\": \"http://www.example.com\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"links\": {\"usage\": \"https://preview.twilio.com/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage\",\"rate_plan\": \"https://preview.twilio.com/wireless/RatePlans/WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"rate_plan_sid\": \"WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sim_identifier\": \"sim_identifier\",\"status\": \"status\",\"url\": \"https://preview.twilio.com/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}],\"meta\": {\"first_page_url\": \"https://preview.twilio.com/wireless/Devices?PageSize=50&Page=0\",\"key\": \"devices\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://preview.twilio.com/wireless/Devices?PageSize=50&Page=0\"}}"
                                     ));
            
            var response = DeviceResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/wireless/Devices",
                ""
            );
            request.AddPostParam("RatePlan", Serialize("RatePlan"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                DeviceResource.Create("RatePlan", client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"alias\": \"alias\",\"commands_callback_method\": \"commands_callback_method\",\"commands_callback_url\": \"http://www.example.com\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"links\": {\"usage\": \"https://preview.twilio.com/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage\",\"rate_plan\": \"https://preview.twilio.com/wireless/RatePlans/WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"rate_plan_sid\": \"WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sim_identifier\": \"sim_identifier\",\"status\": \"status\",\"url\": \"https://preview.twilio.com/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));
            
            var response = DeviceResource.Create("RatePlan", client: twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));
            
            try
            {
                DeviceResource.Update("DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"alias\": \"alias\",\"commands_callback_method\": \"commands_callback_method\",\"commands_callback_url\": \"http://www.example.com\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"links\": {\"usage\": \"https://preview.twilio.com/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Usage\",\"rate_plan\": \"https://preview.twilio.com/wireless/RatePlans/WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"rate_plan_sid\": \"WPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sim_identifier\": \"sim_identifier\",\"status\": \"status\",\"url\": \"https://preview.twilio.com/wireless/Devices/DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));
            
            var response = DeviceResource.Update("DEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}