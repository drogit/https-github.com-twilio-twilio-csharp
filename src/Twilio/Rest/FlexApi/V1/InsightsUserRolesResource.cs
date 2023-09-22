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
    public class InsightsUserRolesResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchInsightsUserRolesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/UserRoles";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> This is used by Flex UI and Quality Management to fetch the Flex Insights roles for the user </summary>
        /// <param name="options"> Fetch InsightsUserRoles parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsUserRoles </returns>
        public static InsightsUserRolesResource Fetch(FetchInsightsUserRolesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> This is used by Flex UI and Quality Management to fetch the Flex Insights roles for the user </summary>
        /// <param name="options"> Fetch InsightsUserRoles parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsUserRoles </returns>
        public static async System.Threading.Tasks.Task<InsightsUserRolesResource> FetchAsync(FetchInsightsUserRolesOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> This is used by Flex UI and Quality Management to fetch the Flex Insights roles for the user </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsUserRoles </returns>
        public static InsightsUserRolesResource Fetch(
                                         string authorization = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchInsightsUserRolesOptions(){ Authorization = authorization };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> This is used by Flex UI and Quality Management to fetch the Flex Insights roles for the user </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsUserRoles </returns>
        public static async System.Threading.Tasks.Task<InsightsUserRolesResource> FetchAsync(string authorization = null, ITwilioRestClient client = null)
        {
            var options = new FetchInsightsUserRolesOptions(){ Authorization = authorization };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a InsightsUserRolesResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InsightsUserRolesResource object represented by the provided JSON </returns>
        public static InsightsUserRolesResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InsightsUserRolesResource>(json);
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

    
        ///<summary> Flex Insights roles for the user </summary> 
        [JsonProperty("roles")]
        public List<string> Roles { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private InsightsUserRolesResource() {

        }
    }
}

