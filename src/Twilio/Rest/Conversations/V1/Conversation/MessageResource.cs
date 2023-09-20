/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Conversations
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Conversations.V1.Conversation
{
    public class MessageResource : Resource
    {
    

    
        public sealed class WebhookEnabledTypeEnum : StringEnum
        {
            private WebhookEnabledTypeEnum(string value) : base(value) {}
            public WebhookEnabledTypeEnum() {}
            public static implicit operator WebhookEnabledTypeEnum(string value)
            {
                return new WebhookEnabledTypeEnum(value);
            }
            public static readonly WebhookEnabledTypeEnum True = new WebhookEnabledTypeEnum("true");
            public static readonly WebhookEnabledTypeEnum False = new WebhookEnabledTypeEnum("false");

        }
        public sealed class OrderTypeEnum : StringEnum
        {
            private OrderTypeEnum(string value) : base(value) {}
            public OrderTypeEnum() {}
            public static implicit operator OrderTypeEnum(string value)
            {
                return new OrderTypeEnum(value);
            }
            public static readonly OrderTypeEnum Asc = new OrderTypeEnum("asc");
            public static readonly OrderTypeEnum Desc = new OrderTypeEnum("desc");

        }

        
        private static Request BuildCreateRequest(CreateMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Conversations/{ConversationSid}/Messages";

            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{"+"ConversationSid"+"}", PathConversationSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Add a new message to the conversation </summary>
        /// <param name="options"> Create Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Create(CreateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Add a new message to the conversation </summary>
        /// <param name="options"> Create Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(CreateMessageOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Add a new message to the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this message. </param>
        /// <param name="author"> The channel specific identifier of the message's author. Defaults to `system`. </param>
        /// <param name="body"> The content of the message, can be up to 1,600 characters long. </param>
        /// <param name="dateCreated"> The date that this resource was created. </param>
        /// <param name="dateUpdated"> The date that this resource was last updated. `null` if the message has not been edited. </param>
        /// <param name="attributes"> A string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \\\"{}\\\" will be returned. </param>
        /// <param name="mediaSid"> The Media SID to be attached to the new Message. </param>
        /// <param name="contentSid"> The unique ID of the multi-channel [Rich Content](https://www.twilio.com/docs/content-api) template, required for template-generated messages.  **Note** that if this field is set, `Body` and `MediaSid` parameters are ignored. </param>
        /// <param name="contentVariables"> A structurally valid JSON string that contains values to resolve Rich Content template variables. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Create(
                                          string pathConversationSid,
                                          string author = null,
                                          string body = null,
                                          DateTime? dateCreated = null,
                                          DateTime? dateUpdated = null,
                                          string attributes = null,
                                          string mediaSid = null,
                                          string contentSid = null,
                                          string contentVariables = null,
                                          MessageResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(pathConversationSid){  Author = author, Body = body, DateCreated = dateCreated, DateUpdated = dateUpdated, Attributes = attributes, MediaSid = mediaSid, ContentSid = contentSid, ContentVariables = contentVariables, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Add a new message to the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this message. </param>
        /// <param name="author"> The channel specific identifier of the message's author. Defaults to `system`. </param>
        /// <param name="body"> The content of the message, can be up to 1,600 characters long. </param>
        /// <param name="dateCreated"> The date that this resource was created. </param>
        /// <param name="dateUpdated"> The date that this resource was last updated. `null` if the message has not been edited. </param>
        /// <param name="attributes"> A string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \\\"{}\\\" will be returned. </param>
        /// <param name="mediaSid"> The Media SID to be attached to the new Message. </param>
        /// <param name="contentSid"> The unique ID of the multi-channel [Rich Content](https://www.twilio.com/docs/content-api) template, required for template-generated messages.  **Note** that if this field is set, `Body` and `MediaSid` parameters are ignored. </param>
        /// <param name="contentVariables"> A structurally valid JSON string that contains values to resolve Rich Content template variables. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(
                                                                                  string pathConversationSid,
                                                                                  string author = null,
                                                                                  string body = null,
                                                                                  DateTime? dateCreated = null,
                                                                                  DateTime? dateUpdated = null,
                                                                                  string attributes = null,
                                                                                  string mediaSid = null,
                                                                                  string contentSid = null,
                                                                                  string contentVariables = null,
                                                                                  MessageResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateMessageOptions(pathConversationSid){  Author = author, Body = body, DateCreated = dateCreated, DateUpdated = dateUpdated, Attributes = attributes, MediaSid = mediaSid, ContentSid = contentSid, ContentVariables = contentVariables, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Remove a message from the conversation </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        private static Request BuildDeleteRequest(DeleteMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Conversations/{ConversationSid}/Messages/{Sid}";

            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{"+"ConversationSid"+"}", PathConversationSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Remove a message from the conversation </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static bool Delete(DeleteMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Remove a message from the conversation </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMessageOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Remove a message from the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static bool Delete(string pathConversationSid, string pathSid, MessageResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null, ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(pathConversationSid, pathSid)         { XTwilioWebhookEnabled = xTwilioWebhookEnabled }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Remove a message from the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathConversationSid, string pathSid, MessageResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null, ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(pathConversationSid, pathSid)  { XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Conversations/{ConversationSid}/Messages/{Sid}";

            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{"+"ConversationSid"+"}", PathConversationSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a message from the conversation </summary>
        /// <param name="options"> Fetch Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Fetch(FetchMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a message from the conversation </summary>
        /// <param name="options"> Fetch Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(FetchMessageOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a message from the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Fetch(
                                         string pathConversationSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(pathConversationSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a message from the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(string pathConversationSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(pathConversationSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Conversations/{ConversationSid}/Messages";

            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{"+"ConversationSid"+"}", PathConversationSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all messages in the conversation </summary>
        /// <param name="options"> Read Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static ResourceSet<MessageResource> Read(ReadMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<MessageResource>.FromJson("messages", response.Content);
            return new ResourceSet<MessageResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all messages in the conversation </summary>
        /// <param name="options"> Read Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(ReadMessageOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MessageResource>.FromJson("messages", response.Content);
            return new ResourceSet<MessageResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all messages in the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for messages. </param>
        /// <param name="order"> The sort order of the returned messages. Can be: `asc` (ascending) or `desc` (descending), with `asc` as the default. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static ResourceSet<MessageResource> Read(
                                                     string pathConversationSid,
                                                     MessageResource.OrderTypeEnum order = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(pathConversationSid){ Order = order, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all messages in the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for messages. </param>
        /// <param name="order"> The sort order of the returned messages. Can be: `asc` (ascending) or `desc` (descending), with `asc` as the default. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(
                                                                                             string pathConversationSid,
                                                                                             MessageResource.OrderTypeEnum order = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(pathConversationSid){ Order = order, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<MessageResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<MessageResource> NextPage(Page<MessageResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<MessageResource> PreviousPage(Page<MessageResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Conversations/{ConversationSid}/Messages/{Sid}";

            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{"+"ConversationSid"+"}", PathConversationSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Update an existing message in the conversation </summary>
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Update(UpdateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an existing message in the conversation </summary>
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(UpdateMessageOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update an existing message in the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="author"> The channel specific identifier of the message's author. Defaults to `system`. </param>
        /// <param name="body"> The content of the message, can be up to 1,600 characters long. </param>
        /// <param name="dateCreated"> The date that this resource was created. </param>
        /// <param name="dateUpdated"> The date that this resource was last updated. `null` if the message has not been edited. </param>
        /// <param name="attributes"> A string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \\\"{}\\\" will be returned. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Update(
                                          string pathConversationSid,
                                          string pathSid,
                                          string author = null,
                                          string body = null,
                                          DateTime? dateCreated = null,
                                          DateTime? dateUpdated = null,
                                          string attributes = null,
                                          MessageResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(pathConversationSid, pathSid){ Author = author, Body = body, DateCreated = dateCreated, DateUpdated = dateUpdated, Attributes = attributes, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update an existing message in the conversation </summary>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="author"> The channel specific identifier of the message's author. Defaults to `system`. </param>
        /// <param name="body"> The content of the message, can be up to 1,600 characters long. </param>
        /// <param name="dateCreated"> The date that this resource was created. </param>
        /// <param name="dateUpdated"> The date that this resource was last updated. `null` if the message has not been edited. </param>
        /// <param name="attributes"> A string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \\\"{}\\\" will be returned. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(
                                                                              string pathConversationSid,
                                                                              string pathSid,
                                                                              string author = null,
                                                                              string body = null,
                                                                              DateTime? dateCreated = null,
                                                                              DateTime? dateUpdated = null,
                                                                              string attributes = null,
                                                                              MessageResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(pathConversationSid, pathSid){ Author = author, Body = body, DateCreated = dateCreated, DateUpdated = dateUpdated, Attributes = attributes, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a MessageResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MessageResource object represented by the provided JSON </returns>
        public static MessageResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<MessageResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique ID of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this message. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this message. </summary> 
        [JsonProperty("conversation_sid")]
        public string ConversationSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The index of the message within the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource).  Indices may skip numbers, but will always be in order of when the message was received. </summary> 
        [JsonProperty("index")]
        public int? Index { get; private set; }

        ///<summary> The channel specific identifier of the message's author. Defaults to `system`. </summary> 
        [JsonProperty("author")]
        public string Author { get; private set; }

        ///<summary> The content of the message, can be up to 1,600 characters long. </summary> 
        [JsonProperty("body")]
        public string Body { get; private set; }

        ///<summary> An array of objects that describe the Message's media, if the message contains media. Each object contains these fields: `content_type` with the MIME type of the media, `filename` with the name of the media, `sid` with the SID of the Media resource, and `size` with the media object's file size in bytes. If the Message has no media, this value is `null`. </summary> 
        [JsonProperty("media")]
        public List<object> Media { get; private set; }

        ///<summary> A string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \"{}\" will be returned. </summary> 
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }

        ///<summary> The unique ID of messages's author participant. Null in case of `system` sent message. </summary> 
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }

        ///<summary> The date that this resource was created. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was last updated. `null` if the message has not been edited. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> An absolute API resource API URL for this message. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> An object that contains the summary of delivery statuses for the message to non-chat participants. </summary> 
        [JsonProperty("delivery")]
        public object Delivery { get; private set; }

        ///<summary> Contains an absolute API resource URL to access the delivery & read receipts of this message. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        ///<summary> The unique ID of the multi-channel [Rich Content](https://www.twilio.com/docs/content-api) template. </summary> 
        [JsonProperty("content_sid")]
        public string ContentSid { get; private set; }



        private MessageResource() {

        }
    }
}

