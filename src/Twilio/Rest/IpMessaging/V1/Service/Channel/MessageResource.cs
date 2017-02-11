using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.IpMessaging.V1.Service.Channel 
{

    public class MessageResource : Resource 
    {
        private static Request BuildFetchRequest(FetchMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v1/Services/" + options.ServiceSid + "/Channels/" + options.ChannelSid + "/Messages/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
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
        /// fetch
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
        /// fetch
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static MessageResource Fetch(string serviceSid, string channelSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(serviceSid, channelSid, sid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(string serviceSid, string channelSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(serviceSid, channelSid, sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildCreateRequest(CreateMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                "/v1/Services/" + options.ServiceSid + "/Channels/" + options.ChannelSid + "/Messages",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
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
        /// create
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
        /// create
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="body"> The body </param>
        /// <param name="from"> The from </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static MessageResource Create(string serviceSid, string channelSid, string body, string from = null, string attributes = null, ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(serviceSid, channelSid, body){From = from, Attributes = attributes};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="body"> The body </param>
        /// <param name="from"> The from </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(string serviceSid, string channelSid, string body, string from = null, string attributes = null, ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(serviceSid, channelSid, body){From = from, Attributes = attributes};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                "/v1/Services/" + options.ServiceSid + "/Channels/" + options.ChannelSid + "/Messages",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
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
        /// read
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
        /// read
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static ResourceSet<MessageResource> Read(string serviceSid, string channelSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(serviceSid, channelSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(string serviceSid, string channelSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(serviceSid, channelSid){PageSize = pageSize, Limit = limit};
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
                    Rest.Domain.IpMessaging,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }
    
        private static Request BuildDeleteRequest(DeleteMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.IpMessaging,
                "/v1/Services/" + options.ServiceSid + "/Channels/" + options.ChannelSid + "/Messages/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
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
        /// delete
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
        /// delete
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static bool Delete(string serviceSid, string channelSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(serviceSid, channelSid, sid);
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string serviceSid, string channelSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(serviceSid, channelSid, sid);
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                "/v1/Services/" + options.ServiceSid + "/Channels/" + options.ChannelSid + "/Messages/" + options.Sid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
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
        /// update
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
        /// update
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="body"> The body </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns> 
        public static MessageResource Update(string serviceSid, string channelSid, string sid, string body = null, string attributes = null, ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(serviceSid, channelSid, sid){Body = body, Attributes = attributes};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="channelSid"> The channel_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="body"> The body </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns> 
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(string serviceSid, string channelSid, string sid, string body = null, string attributes = null, ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(serviceSid, channelSid, sid){Body = body, Attributes = attributes};
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
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The attributes
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The to
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The was_edited
        /// </summary>
        [JsonProperty("was_edited")]
        public bool? WasEdited { get; private set; }
        /// <summary>
        /// The from
        /// </summary>
        [JsonProperty("from")]
        public string From { get; private set; }
        /// <summary>
        /// The body
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; private set; }
        /// <summary>
        /// The index
        /// </summary>
        [JsonProperty("index")]
        public int? Index { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private MessageResource()
        {
        
        }
    }

}