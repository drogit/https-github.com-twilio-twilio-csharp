using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Taskrouter.V1.Workspace;

namespace Twilio.Tests.Taskrouter.V1.Workspace {

    [TestFixture]
    public class WorkflowTest : TwilioTest {
        [SetUp]
        public void SetUp() {
        }
    
        [Test]
        public void TestFetchRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.GET,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows/WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                WorkflowResource.Fetch("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
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
                                                  "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assignment_callback_url\": \"http://example.com\",\"configuration\": \"task-routing:\\\\n- filter: \\\\n- 1 == 1\\\\ntarget:\\\\n- queue: WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\\\\nset-priority: 0\\\\n\",\"date_created\": \"2014-05-14T10:50:02Z\",\"date_updated\": \"2014-05-14T23:26:06Z\",\"document_content_type\": \"application/json\",\"fallback_assignment_callback_url\": null,\"friendly_name\": \"Default Fifo Workflow\",\"sid\": \"WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_reservation_timeout\": 120,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows/WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"));
            
            var response = WorkflowResource.Fetch("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestUpdateRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.POST,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows/WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                WorkflowResource.Update("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
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
                                                  "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assignment_callback_url\": \"http://example.com\",\"configuration\": \"task-routing:\\\\n- filter: \\\\n- 1 == 1\\\\ntarget:\\\\n- queue: WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\\\\nset-priority: 0\\\\n\",\"date_created\": \"2014-05-14T10:50:02Z\",\"date_updated\": \"2014-05-14T23:26:06Z\",\"document_content_type\": \"application/json\",\"fallback_assignment_callback_url\": null,\"friendly_name\": \"Default Fifo Workflow\",\"sid\": \"WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_reservation_timeout\": 120,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows/WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"));
            
            var response = WorkflowResource.Update("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestDeleteRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.DELETE,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows/WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                WorkflowResource.Delete("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
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
            
            WorkflowResource.Delete("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
        }
    
        [Test]
        public void TestReadRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.GET,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows");
            request.AddQueryParam("PageSize", "50");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                WorkflowResource.Read("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
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
                                                  "{\"meta\": {\"first_page_url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows?PageSize=50&Page=0\",\"key\": \"workflows\",\"last_page_url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows?PageSize=50&Page=0\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows?PageSize=50&Page=0\"},\"workflows\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assignment_callback_url\": \"http://example.com\",\"configuration\": \"task-routing:\\\\n- filter: \\\\n- 1 == 1\\\\ntarget:\\\\n- queue: WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\\\\nset-priority: 0\\\\n\",\"date_created\": \"2014-05-14T10:50:02Z\",\"date_updated\": \"2014-05-15T16:47:51Z\",\"document_content_type\": \"application/json\",\"fallback_assignment_callback_url\": null,\"friendly_name\": \"Default Fifo Workflow\",\"sid\": \"WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_reservation_timeout\": 120,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows/WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"));
            
            var response = WorkflowResource.Read("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestReadEmptyResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                                  "{\"meta\": {\"first_page_url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows?PageSize=50&Page=0\",\"key\": \"workflows\",\"last_page_url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows?PageSize=50&Page=0\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows?PageSize=50&Page=0\"},\"workflows\": []}"));
            
            var response = WorkflowResource.Read("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestCreateRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(Twilio.Http.HttpMethod.POST,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows");
            request.AddPostParam("FriendlyName", Serialize("friendlyName"));
            request.AddPostParam("Configuration", Serialize("configuration"));
            request.AddPostParam("AssignmentCallbackUrl", Serialize("/example"));
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try {
                WorkflowResource.Create("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "friendlyName", "configuration", "/example").Execute(twilioRestClient);
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
                                                  "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assignment_callback_url\": \"http://example.com\",\"configuration\": \"task-routing:\\\\n- filter: \\\\n- 1 == 1\\\\ntarget:\\\\n- queue: WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\\\\nset-priority: 0\\\\n\",\"date_created\": \"2014-05-14T10:50:02Z\",\"date_updated\": \"2014-05-14T23:26:06Z\",\"document_content_type\": \"application/json\",\"fallback_assignment_callback_url\": null,\"friendly_name\": \"Default Fifo Workflow\",\"sid\": \"WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_reservation_timeout\": 120,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Workflows/WFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"));
            
            var response = WorkflowResource.Create("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "friendlyName", "configuration", "/example").Execute(twilioRestClient);
            Assert.NotNull(response);
        }
    }
}