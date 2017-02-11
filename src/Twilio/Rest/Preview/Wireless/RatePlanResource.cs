using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Wireless 
{

    public class RatePlanResource : Resource 
    {
        private static Request BuildReadRequest(ReadRatePlanOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/wireless/RatePlans",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static ResourceSet<RatePlanResource> Read(ReadRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<RatePlanResource>.FromJson("rate_plans", response.Content);
            return new ResourceSet<RatePlanResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RatePlanResource>> ReadAsync(ReadRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<RatePlanResource>.FromJson("rate_plans", response.Content);
            return new ResourceSet<RatePlanResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static ResourceSet<RatePlanResource> Read(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadRatePlanOptions{PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RatePlanResource>> ReadAsync(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadRatePlanOptions{PageSize = pageSize, Limit = limit};
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
        public static Page<RatePlanResource> NextPage(Page<RatePlanResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<RatePlanResource>.FromJson("rate_plans", response.Content);
        }
    
        private static Request BuildFetchRequest(FetchRatePlanOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/wireless/RatePlans/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Fetch(FetchRatePlanOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> FetchAsync(FetchRatePlanOptions options, ITwilioRestClient client = null)
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
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Fetch(string sid, ITwilioRestClient client = null)
        {
            var options = new FetchRatePlanOptions(sid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> FetchAsync(string sid, ITwilioRestClient client = null)
        {
            var options = new FetchRatePlanOptions(sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildCreateRequest(CreateRatePlanOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/wireless/RatePlans",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Create(CreateRatePlanOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Create RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> CreateAsync(CreateRatePlanOptions options, ITwilioRestClient client = null)
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
        /// <param name="alias"> The alias </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="roaming"> The roaming </param>
        /// <param name="dataLimit"> The data_limit </param>
        /// <param name="dataMetering"> The data_metering </param>
        /// <param name="commandsEnabled"> The commands_enabled </param>
        /// <param name="renewal"> The renewal </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Create(string alias = null, string friendlyName = null, List<string> roaming = null, int? dataLimit = null, string dataMetering = null, bool? commandsEnabled = null, string renewal = null, ITwilioRestClient client = null)
        {
            var options = new CreateRatePlanOptions{Alias = alias, FriendlyName = friendlyName, Roaming = roaming, DataLimit = dataLimit, DataMetering = dataMetering, CommandsEnabled = commandsEnabled, Renewal = renewal};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="alias"> The alias </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="roaming"> The roaming </param>
        /// <param name="dataLimit"> The data_limit </param>
        /// <param name="dataMetering"> The data_metering </param>
        /// <param name="commandsEnabled"> The commands_enabled </param>
        /// <param name="renewal"> The renewal </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> CreateAsync(string alias = null, string friendlyName = null, List<string> roaming = null, int? dataLimit = null, string dataMetering = null, bool? commandsEnabled = null, string renewal = null, ITwilioRestClient client = null)
        {
            var options = new CreateRatePlanOptions{Alias = alias, FriendlyName = friendlyName, Roaming = roaming, DataLimit = dataLimit, DataMetering = dataMetering, CommandsEnabled = commandsEnabled, Renewal = renewal};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateRatePlanOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/wireless/RatePlans/" + options.Sid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Update(UpdateRatePlanOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Update RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> UpdateAsync(UpdateRatePlanOptions options, ITwilioRestClient client = null)
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
        /// <param name="sid"> The sid </param>
        /// <param name="alias"> The alias </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Update(string sid, string alias = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateRatePlanOptions(sid){Alias = alias, FriendlyName = friendlyName};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="alias"> The alias </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> UpdateAsync(string sid, string alias = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateRatePlanOptions(sid){Alias = alias, FriendlyName = friendlyName};
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a RatePlanResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RatePlanResource object represented by the provided JSON </returns> 
        public static RatePlanResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RatePlanResource>(json);
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
        /// The alias
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The roaming
        /// </summary>
        [JsonProperty("roaming")]
        public List<string> Roaming { get; private set; }
        /// <summary>
        /// The data
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; private set; }
        /// <summary>
        /// The commands
        /// </summary>
        [JsonProperty("commands")]
        public object Commands { get; private set; }
        /// <summary>
        /// The renewal
        /// </summary>
        [JsonProperty("renewal")]
        public string Renewal { get; private set; }
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
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private RatePlanResource()
        {
        
        }
    }

}