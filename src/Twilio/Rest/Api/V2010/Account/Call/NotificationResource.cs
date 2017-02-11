using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Call 
{

    public class NotificationResource : Resource 
    {
        private static Request BuildFetchRequest(FetchNotificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Calls/" + options.CallSid + "/Notifications/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static NotificationResource Fetch(FetchNotificationOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<NotificationResource> FetchAsync(FetchNotificationOptions options, ITwilioRestClient client = null)
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
        /// <param name="callSid"> The call_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static NotificationResource Fetch(string callSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchNotificationOptions(callSid, sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<NotificationResource> FetchAsync(string callSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchNotificationOptions(callSid, sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteNotificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Calls/" + options.CallSid + "/Notifications/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static bool Delete(DeleteNotificationOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Delete Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteNotificationOptions options, ITwilioRestClient client = null)
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
        /// <param name="callSid"> The call_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static bool Delete(string callSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteNotificationOptions(callSid, sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string callSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteNotificationOptions(callSid, sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadNotificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Calls/" + options.CallSid + "/Notifications.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static ResourceSet<NotificationResource> Read(ReadNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<NotificationResource>.FromJson("notifications", response.Content);
            return new ResourceSet<NotificationResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<NotificationResource>> ReadAsync(ReadNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<NotificationResource>.FromJson("notifications", response.Content);
            return new ResourceSet<NotificationResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="log"> The log </param>
        /// <param name="messageDateBefore"> The message_date </param>
        /// <param name="messageDate"> The message_date </param>
        /// <param name="messageDateAfter"> The message_date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns> 
        public static ResourceSet<NotificationResource> Read(string callSid, string accountSid = null, int? log = null, DateTime? messageDateBefore = null, DateTime? messageDate = null, DateTime? messageDateAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadNotificationOptions(callSid){AccountSid = accountSid, Log = log, MessageDateBefore = messageDateBefore, MessageDate = messageDate, MessageDateAfter = messageDateAfter, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="log"> The log </param>
        /// <param name="messageDateBefore"> The message_date </param>
        /// <param name="messageDate"> The message_date </param>
        /// <param name="messageDateAfter"> The message_date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<NotificationResource>> ReadAsync(string callSid, string accountSid = null, int? log = null, DateTime? messageDateBefore = null, DateTime? messageDate = null, DateTime? messageDateAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadNotificationOptions(callSid){AccountSid = accountSid, Log = log, MessageDateBefore = messageDateBefore, MessageDate = messageDate, MessageDateAfter = messageDateAfter, PageSize = pageSize, Limit = limit};
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
        public static Page<NotificationResource> NextPage(Page<NotificationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<NotificationResource>.FromJson("notifications", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a NotificationResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NotificationResource object represented by the provided JSON </returns> 
        public static NotificationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<NotificationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The api_version
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The call_sid
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
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
        /// The error_code
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; private set; }
        /// <summary>
        /// The log
        /// </summary>
        [JsonProperty("log")]
        public string Log { get; private set; }
        /// <summary>
        /// The message_date
        /// </summary>
        [JsonProperty("message_date")]
        public DateTime? MessageDate { get; private set; }
        /// <summary>
        /// The message_text
        /// </summary>
        [JsonProperty("message_text")]
        public string MessageText { get; private set; }
        /// <summary>
        /// The more_info
        /// </summary>
        [JsonProperty("more_info")]
        public Uri MoreInfo { get; private set; }
        /// <summary>
        /// The request_method
        /// </summary>
        [JsonProperty("request_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod RequestMethod { get; private set; }
        /// <summary>
        /// The request_url
        /// </summary>
        [JsonProperty("request_url")]
        public Uri RequestUrl { get; private set; }
        /// <summary>
        /// The request_variables
        /// </summary>
        [JsonProperty("request_variables")]
        public string RequestVariables { get; private set; }
        /// <summary>
        /// The response_body
        /// </summary>
        [JsonProperty("response_body")]
        public string ResponseBody { get; private set; }
        /// <summary>
        /// The response_headers
        /// </summary>
        [JsonProperty("response_headers")]
        public string ResponseHeaders { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private NotificationResource()
        {
        
        }
    }

}