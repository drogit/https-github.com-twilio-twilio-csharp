using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Api.V2010.Account.Call;

namespace Twilio.Tests.Api.V2010.Account.Call {

    [TestFixture]
    public class FeedbackSummaryTest : TwilioTest {
        [SetUp]
        public void SetUp() {
        }
    
        [Test]
        public void TestCreateRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.POST,
                                          Domains.API,
                                          "/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Calls/FeedbackSummary.json");
            request.AddPostParam("StartDate", Serialize(MarshalConverter.DateTimeFromString("2008-01-02")));
            request.AddPostParam("EndDate", Serialize(MarshalConverter.DateTimeFromString("2008-01-02")));
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                FeedbackSummaryResource.Create("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", MarshalConverter.DateTimeFromString("2008-01-02"), MarshalConverter.DateTimeFromString("2008-01-02")).Execute(twilioRestClient);
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
                                                  "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"call_count\": 10200,\"call_feedback_count\": 729,\"end_date\": \"2011-01-01\",\"include_subaccounts\": false,\"issues\": [{\"count\": 45,\"description\": \"imperfect-audio\",\"percentage_of_total_calls\": \"0.04%\"}],\"quality_score_average\": 4.5,\"quality_score_median\": 4,\"quality_score_standard_deviation\": 1,\"sid\": \"FSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"start_date\": \"2011-01-01\",\"status\": \"completed\",\"date_created\": \"Tue, 31 Aug 2010 20:36:28 +0000\",\"date_updated\": \"Tue, 31 Aug 2010 20:36:44 +0000\"}"));
            
            var response = FeedbackSummaryResource.Create("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", MarshalConverter.DateTimeFromString("2008-01-02"), MarshalConverter.DateTimeFromString("2008-01-02")).Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestFetchRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.GET,
                                          Domains.API,
                                          "/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Calls/FeedbackSummary/FSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                FeedbackSummaryResource.Fetch("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "FSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
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
                                                  "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"call_count\": 10200,\"call_feedback_count\": 729,\"end_date\": \"2011-01-01\",\"include_subaccounts\": false,\"issues\": [{\"count\": 45,\"description\": \"imperfect-audio\",\"percentage_of_total_calls\": \"0.04%\"}],\"quality_score_average\": 4.5,\"quality_score_median\": 4,\"quality_score_standard_deviation\": 1,\"sid\": \"FSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"start_date\": \"2011-01-01\",\"status\": \"completed\",\"date_created\": \"Tue, 31 Aug 2010 20:36:28 +0000\",\"date_updated\": \"Tue, 31 Aug 2010 20:36:44 +0000\"}"));
            
            var response = FeedbackSummaryResource.Fetch("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "FSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestDeleteRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.DELETE,
                                          Domains.API,
                                          "/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Calls/FeedbackSummary/FSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa.json");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                FeedbackSummaryResource.Delete("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "FSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
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
            
            FeedbackSummaryResource.Delete("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "FSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
        }
    }
}