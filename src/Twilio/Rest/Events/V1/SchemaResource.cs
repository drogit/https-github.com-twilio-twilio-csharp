/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Events
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



namespace Twilio.Rest.Events.V1
{
    public class SchemaResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchSchemaOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Schemas/{Id}";

            string PathId = options.PathId;
            path = path.Replace("{"+"Id"+"}", PathId);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Events,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific schema with its nested versions. </summary>
        /// <param name="options"> Fetch Schema parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Schema </returns>
        public static SchemaResource Fetch(FetchSchemaOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific schema with its nested versions. </summary>
        /// <param name="options"> Fetch Schema parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Schema </returns>
        public static async System.Threading.Tasks.Task<SchemaResource> FetchAsync(FetchSchemaOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific schema with its nested versions. </summary>
        /// <param name="pathId"> The unique identifier of the schema. Each schema can have multiple versions, that share the same id. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Schema </returns>
        public static SchemaResource Fetch(
                                         string pathId, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchSchemaOptions(pathId){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific schema with its nested versions. </summary>
        /// <param name="pathId"> The unique identifier of the schema. Each schema can have multiple versions, that share the same id. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Schema </returns>
        public static async System.Threading.Tasks.Task<SchemaResource> FetchAsync(string pathId, ITwilioRestClient client = null)
        {
            var options = new FetchSchemaOptions(pathId){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a SchemaResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SchemaResource object represented by the provided JSON </returns>
        public static SchemaResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SchemaResource>(json);
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

    
        ///<summary> The unique identifier of the schema. Each schema can have multiple versions, that share the same id. </summary> 
        [JsonProperty("id")]
        public string Id { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Contains a dictionary of URL links to nested resources of this schema. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        ///<summary> The date that the latest schema version was created, given in ISO 8601 format. </summary> 
        [JsonProperty("latest_version_date_created")]
        public DateTime? LatestVersionDateCreated { get; private set; }

        ///<summary> The latest version published of this schema. </summary> 
        [JsonProperty("latest_version")]
        public int? LatestVersion { get; private set; }



        private SchemaResource() {

        }
    }
}

