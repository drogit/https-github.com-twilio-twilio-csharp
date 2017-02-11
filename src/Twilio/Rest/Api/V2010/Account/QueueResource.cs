using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class QueueResource : Resource 
    {
        private static Request BuildFetchRequest(FetchQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Queues/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of a queue identified by the QueueSid
        /// </summary>
        ///
        /// <param name="options"> Fetch Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Fetch(FetchQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a queue identified by the QueueSid
        /// </summary>
        ///
        /// <param name="options"> Fetch Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> FetchAsync(FetchQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of a queue identified by the QueueSid
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique queue Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Fetch(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchQueueOptions(sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a queue identified by the QueueSid
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique queue Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> FetchAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchQueueOptions(sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Queues/" + options.Sid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Update the queue with the new parameters
        /// </summary>
        ///
        /// <param name="options"> Update Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Update(UpdateQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Update the queue with the new parameters
        /// </summary>
        ///
        /// <param name="options"> Update Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> UpdateAsync(UpdateQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Update the queue with the new parameters
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> A human readable description of the queue </param>
        /// <param name="maxSize"> The max number of members allowed in the queue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Update(string sid, string accountSid = null, string friendlyName = null, int? maxSize = null, ITwilioRestClient client = null)
        {
            var options = new UpdateQueueOptions(sid){AccountSid = accountSid, FriendlyName = friendlyName, MaxSize = maxSize};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Update the queue with the new parameters
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> A human readable description of the queue </param>
        /// <param name="maxSize"> The max number of members allowed in the queue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> UpdateAsync(string sid, string accountSid = null, string friendlyName = null, int? maxSize = null, ITwilioRestClient client = null)
        {
            var options = new UpdateQueueOptions(sid){AccountSid = accountSid, FriendlyName = friendlyName, MaxSize = maxSize};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Queues/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Remove an empty queue
        /// </summary>
        ///
        /// <param name="options"> Delete Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static bool Delete(DeleteQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Remove an empty queue
        /// </summary>
        ///
        /// <param name="options"> Delete Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Remove an empty queue
        /// </summary>
        ///
        /// <param name="sid"> Delete by unique queue Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static bool Delete(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteQueueOptions(sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Remove an empty queue
        /// </summary>
        ///
        /// <param name="sid"> Delete by unique queue Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteQueueOptions(sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Queues.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of queues belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static ResourceSet<QueueResource> Read(ReadQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<QueueResource>.FromJson("queues", response.Content);
            return new ResourceSet<QueueResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of queues belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<QueueResource>> ReadAsync(ReadQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<QueueResource>.FromJson("queues", response.Content);
            return new ResourceSet<QueueResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of queues belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static ResourceSet<QueueResource> Read(string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadQueueOptions{AccountSid = accountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of queues belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<QueueResource>> ReadAsync(string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadQueueOptions{AccountSid = accountSid, PageSize = pageSize, Limit = limit};
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
        public static Page<QueueResource> NextPage(Page<QueueResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<QueueResource>.FromJson("queues", response.Content);
        }
    
        private static Request BuildCreateRequest(CreateQueueOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Queues.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Create a queue
        /// </summary>
        ///
        /// <param name="options"> Create Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Create(CreateQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Create a queue
        /// </summary>
        ///
        /// <param name="options"> Create Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> CreateAsync(CreateQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Create a queue
        /// </summary>
        ///
        /// <param name="friendlyName"> A user-provided string that identifies this queue. </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="maxSize"> The max number of calls allowed in the queue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns> 
        public static QueueResource Create(string friendlyName, string accountSid = null, int? maxSize = null, ITwilioRestClient client = null)
        {
            var options = new CreateQueueOptions(friendlyName){AccountSid = accountSid, MaxSize = maxSize};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Create a queue
        /// </summary>
        ///
        /// <param name="friendlyName"> A user-provided string that identifies this queue. </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="maxSize"> The max number of calls allowed in the queue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns> 
        public static async System.Threading.Tasks.Task<QueueResource> CreateAsync(string friendlyName, string accountSid = null, int? maxSize = null, ITwilioRestClient client = null)
        {
            var options = new CreateQueueOptions(friendlyName){AccountSid = accountSid, MaxSize = maxSize};
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a QueueResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> QueueResource object represented by the provided JSON </returns> 
        public static QueueResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<QueueResource>(json);
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
        /// Average wait time of members in the queue
        /// </summary>
        [JsonProperty("average_wait_time")]
        public int? AverageWaitTime { get; private set; }
        /// <summary>
        /// The count of calls currently in the queue.
        /// </summary>
        [JsonProperty("current_size")]
        public int? CurrentSize { get; private set; }
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
        /// A user-provided string that identifies this queue.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The max number of calls allowed in the queue
        /// </summary>
        [JsonProperty("max_size")]
        public int? MaxSize { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this queue
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private QueueResource()
        {
        
        }
    }

}