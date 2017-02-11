using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class MessageResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
        
            public static readonly StatusEnum Queued = new StatusEnum("queued");
            public static readonly StatusEnum Sending = new StatusEnum("sending");
            public static readonly StatusEnum Sent = new StatusEnum("sent");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum Delivered = new StatusEnum("delivered");
            public static readonly StatusEnum Undelivered = new StatusEnum("undelivered");
            public static readonly StatusEnum Receiving = new StatusEnum("receiving");
            public static readonly StatusEnum Received = new StatusEnum("received");
        }
    
        public sealed class DirectionEnum : StringEnum 
        {
            private DirectionEnum(string value) : base(value) {}
            public DirectionEnum() {}
        
            public static readonly DirectionEnum Inbound = new DirectionEnum("inbound");
            public static readonly DirectionEnum OutboundApi = new DirectionEnum("outbound-api");
            public static readonly DirectionEnum OutboundCall = new DirectionEnum("outbound-call");
            public static readonly DirectionEnum OutboundReply = new DirectionEnum("outbound-reply");
        }
    
        private static Request BuildCreateRequest(CreateMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Messages.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Send a message from the account used to make the request
        /// </summary>
        ///
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
        /// <summary>
        /// Send a message from the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Create Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(CreateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Send a message from the account used to make the request
        /// </summary>
        ///
        /// <param name="to"> The phone number to receive the message </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="from"> The phone number that initiated the message </param>
        /// <param name="messagingServiceSid"> The messaging_service_sid </param>
        /// <param name="body"> The body </param>
        /// <param name="mediaUrl"> The media_url </param>
        /// <param name="statusCallback"> URL Twilio will request when the status changes </param>
        /// <param name="applicationSid"> The application to use for callbacks </param>
        /// <param name="maxPrice"> The max_price </param>
        /// <param name="provideFeedback"> The provide_feedback </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static MessageResource Create(Types.PhoneNumber to, string accountSid = null, Types.PhoneNumber from = null, string messagingServiceSid = null, string body = null, List<Uri> mediaUrl = null, Uri statusCallback = null, string applicationSid = null, decimal? maxPrice = null, bool? provideFeedback = null, ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(to){AccountSid = accountSid, From = from, MessagingServiceSid = messagingServiceSid, Body = body, MediaUrl = mediaUrl, StatusCallback = statusCallback, ApplicationSid = applicationSid, MaxPrice = maxPrice, ProvideFeedback = provideFeedback};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Send a message from the account used to make the request
        /// </summary>
        ///
        /// <param name="to"> The phone number to receive the message </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="from"> The phone number that initiated the message </param>
        /// <param name="messagingServiceSid"> The messaging_service_sid </param>
        /// <param name="body"> The body </param>
        /// <param name="mediaUrl"> The media_url </param>
        /// <param name="statusCallback"> URL Twilio will request when the status changes </param>
        /// <param name="applicationSid"> The application to use for callbacks </param>
        /// <param name="maxPrice"> The max_price </param>
        /// <param name="provideFeedback"> The provide_feedback </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(Types.PhoneNumber to, string accountSid = null, Types.PhoneNumber from = null, string messagingServiceSid = null, string body = null, List<Uri> mediaUrl = null, Uri statusCallback = null, string applicationSid = null, decimal? maxPrice = null, bool? provideFeedback = null, ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(to){AccountSid = accountSid, From = from, MessagingServiceSid = messagingServiceSid, Body = body, MediaUrl = mediaUrl, StatusCallback = statusCallback, ApplicationSid = applicationSid, MaxPrice = maxPrice, ProvideFeedback = provideFeedback};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Messages/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Deletes a message record from your account
        /// </summary>
        ///
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
        /// <summary>
        /// Deletes a message record from your account
        /// </summary>
        ///
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Deletes a message record from your account
        /// </summary>
        ///
        /// <param name="sid"> The message to delete </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static bool Delete(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Deletes a message record from your account
        /// </summary>
        ///
        /// <param name="sid"> The message to delete </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildFetchRequest(FetchMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Messages/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch a message belonging to the account used to make the request
        /// </summary>
        ///
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
        /// <summary>
        /// Fetch a message belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Fetch Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(FetchMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch a message belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique message Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static MessageResource Fetch(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch a message belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique message Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Messages.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of messages belonging to the account used to make the request
        /// </summary>
        ///
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
        /// <summary>
        /// Retrieve a list of messages belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(ReadMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<MessageResource>.FromJson("messages", response.Content);
            return new ResourceSet<MessageResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of messages belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="to"> Filter by messages to this number </param>
        /// <param name="from"> Filter by from number </param>
        /// <param name="dateSentBefore"> Filter by date sent </param>
        /// <param name="dateSent"> Filter by date sent </param>
        /// <param name="dateSentAfter"> Filter by date sent </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static ResourceSet<MessageResource> Read(string accountSid = null, Types.PhoneNumber to = null, Types.PhoneNumber from = null, DateTime? dateSentBefore = null, DateTime? dateSent = null, DateTime? dateSentAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions{AccountSid = accountSid, To = to, From = from, DateSentBefore = dateSentBefore, DateSent = dateSent, DateSentAfter = dateSentAfter, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of messages belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="to"> Filter by messages to this number </param>
        /// <param name="from"> Filter by from number </param>
        /// <param name="dateSentBefore"> Filter by date sent </param>
        /// <param name="dateSent"> Filter by date sent </param>
        /// <param name="dateSentAfter"> Filter by date sent </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(string accountSid = null, Types.PhoneNumber to = null, Types.PhoneNumber from = null, DateTime? dateSentBefore = null, DateTime? dateSent = null, DateTime? dateSentAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions{AccountSid = accountSid, To = to, From = from, DateSentBefore = dateSentBefore, DateSent = dateSent, DateSentAfter = dateSentAfter, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<MessageResource> NextPage(Page<MessageResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }
    
        private static Request BuildUpdateRequest(UpdateMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Messages/" + options.Sid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
        /// </summary>
        ///
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static MessageResource Update(UpdateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
        /// </summary>
        ///
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(UpdateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
        /// </summary>
        ///
        /// <param name="sid"> The message to redact </param>
        /// <param name="body"> The body </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static MessageResource Update(string sid, string body, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(sid, body){AccountSid = accountSid};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
        /// </summary>
        ///
        /// <param name="sid"> The message to redact </param>
        /// <param name="body"> The body </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(string sid, string body, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(sid, body){AccountSid = accountSid};
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a MessageResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MessageResource object represented by the provided JSON </returns> 
        public static MessageResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MessageResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The version of the Twilio API used to process the message.
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The text body of the message. Up to 1600 characters long.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; private set; }
        /// <summary>
        /// The date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The date the message was sent
        /// </summary>
        [JsonProperty("date_sent")]
        public DateTime? DateSent { get; private set; }
        /// <summary>
        /// The direction of the message
        /// </summary>
        [JsonProperty("direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageResource.DirectionEnum Direction { get; private set; }
        /// <summary>
        /// The error code associated with the message
        /// </summary>
        [JsonProperty("error_code")]
        public int? ErrorCode { get; private set; }
        /// <summary>
        /// Human readable description of the ErrorCode
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; private set; }
        /// <summary>
        /// The phone number that initiated the message
        /// </summary>
        [JsonProperty("from")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber From { get; private set; }
        /// <summary>
        /// The messaging_service_sid
        /// </summary>
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; private set; }
        /// <summary>
        /// Number of media files associated with the message
        /// </summary>
        [JsonProperty("num_media")]
        public string NumMedia { get; private set; }
        /// <summary>
        /// Indicates number of messages used to delivery the body
        /// </summary>
        [JsonProperty("num_segments")]
        public string NumSegments { get; private set; }
        /// <summary>
        /// The amount billed for the message
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; private set; }
        /// <summary>
        /// The currency in which Price is measured
        /// </summary>
        [JsonProperty("price_unit")]
        public string PriceUnit { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this message
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The status of this message
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
        /// <summary>
        /// The phone number that received the message
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private MessageResource()
        {
        
        }
    }

}