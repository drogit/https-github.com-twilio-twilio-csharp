/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Bulkexports
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



namespace Twilio.Rest.Bulkexports.V1
{
    public class ExportResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchExportOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Exports/{ResourceType}";

            string PathResourceType = options.PathResourceType;
            path = path.Replace("{"+"ResourceType"+"}", PathResourceType);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Bulkexports,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Export. </summary>
        /// <param name="options"> Fetch Export parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Export </returns>
        public static ExportResource Fetch(FetchExportOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Export. </summary>
        /// <param name="options"> Fetch Export parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Export </returns>
        public static async System.Threading.Tasks.Task<ExportResource> FetchAsync(FetchExportOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Export. </summary>
        /// <param name="pathResourceType"> The type of communication – Messages, Calls, Conferences, and Participants </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Export </returns>
        public static ExportResource Fetch(
                                         string pathResourceType, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchExportOptions(pathResourceType){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Export. </summary>
        /// <param name="pathResourceType"> The type of communication – Messages, Calls, Conferences, and Participants </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Export </returns>
        public static async System.Threading.Tasks.Task<ExportResource> FetchAsync(string pathResourceType, ITwilioRestClient client = null)
        {
            var options = new FetchExportOptions(pathResourceType){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ExportResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ExportResource object represented by the provided JSON </returns>
        public static ExportResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ExportResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The type of communication – Messages, Calls, Conferences, and Participants </summary> 
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Contains a dictionary of URL links to nested resources of this Export. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private ExportResource() {

        }
    }
}

