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
using Twilio.Rest.Media.V1;

namespace Twilio.Tests.Rest.Media.V1
{

    [TestFixture]
    public class PlayerStreamerTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Media,
                "/v1/PlayerStreamers/VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PlayerStreamerResource.Fetch("VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"created\",\"video\": true,\"sid\": \"VJcafebabecafebabecafebabecafebabe\",\"status_callback\": \"http://www.example.com\",\"status_callback_method\": \"POST\",\"ended_reason\": null,\"url\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe\",\"max_duration\": 300,\"links\": {\"timed_metadata\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/TimedMetadata\",\"playback_grant\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/PlaybackGrant\"}}"
                                     ));

            var response = PlayerStreamerResource.Fetch("VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Media,
                "/v1/PlayerStreamers",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PlayerStreamerResource.Create(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"created\",\"video\": true,\"sid\": \"VJcafebabecafebabecafebabecafebabe\",\"status_callback\": \"http://www.example.com\",\"status_callback_method\": \"POST\",\"ended_reason\": null,\"url\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe\",\"max_duration\": 300,\"links\": {\"timed_metadata\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/TimedMetadata\",\"playback_grant\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/PlaybackGrant\"}}"
                                     ));

            var response = PlayerStreamerResource.Create(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Media,
                "/v1/PlayerStreamers/VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            request.AddPostParam("Status", Serialize(PlayerStreamerResource.UpdateStatusEnum.Ended));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PlayerStreamerResource.Update("VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", PlayerStreamerResource.UpdateStatusEnum.Ended, client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:01:00Z\",\"status\": \"ended\",\"video\": true,\"sid\": \"VJcafebabecafebabecafebabecafebabe\",\"status_callback\": \"http://www.example.com\",\"status_callback_method\": \"POST\",\"ended_reason\": \"ended-via-api\",\"url\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe\",\"max_duration\": 300,\"links\": {\"timed_metadata\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/TimedMetadata\",\"playback_grant\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/PlaybackGrant\"}}"
                                     ));

            var response = PlayerStreamerResource.Update("VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", PlayerStreamerResource.UpdateStatusEnum.Ended, client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Media,
                "/v1/PlayerStreamers",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PlayerStreamerResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 10,\"first_page_url\": \"https://media.twilio.com/v1/PlayerStreamers?Status=started&Order=asc&PageSize=10&Page=0\",\"previous_page_url\": null,\"url\": \"https://media.twilio.com/v1/PlayerStreamers?Status=started&Order=asc&PageSize=10&Page=0\",\"next_page_url\": null,\"key\": \"player_streamers\"},\"player_streamers\": []}"
                                     ));

            var response = PlayerStreamerResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadItemsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 10,\"first_page_url\": \"https://media.twilio.com/v1/PlayerStreamers?Status=ended&Order=desc&PageSize=10&Page=0\",\"previous_page_url\": null,\"url\": \"https://media.twilio.com/v1/PlayerStreamers?Status=ended&Order=desc&PageSize=10&Page=0\",\"next_page_url\": null,\"key\": \"player_streamers\"},\"player_streamers\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:01:00Z\",\"status\": \"ended\",\"video\": true,\"sid\": \"VJcafebabecafebabecafebabecafebabe\",\"status_callback\": \"http://www.example.com\",\"status_callback_method\": \"POST\",\"ended_reason\": \"ended-via-api\",\"url\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe\",\"max_duration\": 300,\"links\": {\"timed_metadata\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/TimedMetadata\",\"playback_grant\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/PlaybackGrant\"}}]}"
                                     ));

            var response = PlayerStreamerResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadItemsPageLargerThanMaxResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 100,\"first_page_url\": \"https://media.twilio.com/v1/PlayerStreamers?Status=ended&Order=desc&PageSize=100&Page=0\",\"previous_page_url\": null,\"url\": \"https://media.twilio.com/v1/PlayerStreamers?Status=ended&Order=desc&PageSize=100&Page=0\",\"next_page_url\": null,\"key\": \"player_streamers\"},\"player_streamers\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:01:00Z\",\"status\": \"ended\",\"video\": true,\"sid\": \"VJcafebabecafebabecafebabecafebabe\",\"status_callback\": \"http://www.example.com\",\"status_callback_method\": \"POST\",\"ended_reason\": \"ended-via-api\",\"url\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe\",\"max_duration\": 300,\"links\": {\"timed_metadata\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/TimedMetadata\",\"playback_grant\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/PlaybackGrant\"}}]}"
                                     ));

            var response = PlayerStreamerResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}