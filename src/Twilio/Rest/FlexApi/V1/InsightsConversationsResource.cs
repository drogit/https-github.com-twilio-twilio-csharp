/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.FlexApi.V1
{
    public class InsightsConversationsResource : Resource
    {
    

    

        
        private static Request BuildReadRequest(ReadInsightsConversationsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/Conversations";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }
        /// <summary> To get conversation with segment id </summary>
        /// <param name="options"> Read InsightsConversations parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsConversations </returns>
        public static ResourceSet<InsightsConversationsResource> Read(ReadInsightsConversationsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<InsightsConversationsResource>.FromJson("conversations", response.Content);
            return new ResourceSet<InsightsConversationsResource>(page, options, client);
        }

        #if !NET35
        /// <summary> To get conversation with segment id </summary>
        /// <param name="options"> Read InsightsConversations parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsConversations </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InsightsConversationsResource>> ReadAsync(ReadInsightsConversationsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<InsightsConversationsResource>.FromJson("conversations", response.Content);
            return new ResourceSet<InsightsConversationsResource>(page, options, client);
        }
        #endif
        /// <summary> To get conversation with segment id </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="segmentId"> Unique Id of the segment for which conversation details needs to be fetched </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsConversations </returns>
        public static ResourceSet<InsightsConversationsResource> Read(
                                                     string authorization = null,
                                                     string segmentId = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadInsightsConversationsOptions(){ Authorization = authorization, SegmentId = segmentId, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> To get conversation with segment id </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="segmentId"> Unique Id of the segment for which conversation details needs to be fetched </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsConversations </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InsightsConversationsResource>> ReadAsync(
                                                                                             string authorization = null,
                                                                                             string segmentId = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadInsightsConversationsOptions(){ Authorization = authorization, SegmentId = segmentId, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<InsightsConversationsResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<InsightsConversationsResource>.FromJson("conversations", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<InsightsConversationsResource> NextPage(Page<InsightsConversationsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InsightsConversationsResource>.FromJson("conversations", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<InsightsConversationsResource> PreviousPage(Page<InsightsConversationsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InsightsConversationsResource>.FromJson("conversations", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a InsightsConversationsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InsightsConversationsResource object represented by the provided JSON </returns>
        public static InsightsConversationsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InsightsConversationsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The id of the account. </summary> 
        [JsonProperty("account_id")]
        public string AccountId { get; private set; }

        ///<summary> The unique id of the conversation </summary> 
        [JsonProperty("conversation_id")]
        public string ConversationId { get; private set; }

        ///<summary> The count of segments for a conversation </summary> 
        [JsonProperty("segment_count")]
        public int? SegmentCount { get; private set; }

        ///<summary> The Segments of a conversation </summary> 
        [JsonProperty("segments")]
        public List<object> Segments { get; private set; }



        private InsightsConversationsResource() {

        }
    }
}

