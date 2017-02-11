using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Recording.AddOnResult 
{

    public class PayloadResource : Resource 
    {
        private static Request BuildFetchRequest(FetchPayloadOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Recordings/" + options.ReferenceSid + "/AddOnResults/" + options.AddOnResultSid + "/Payloads/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of a result payload
        /// </summary>
        ///
        /// <param name="options"> Fetch Payload parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payload </returns> 
        public static PayloadResource Fetch(FetchPayloadOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a result payload
        /// </summary>
        ///
        /// <param name="options"> Fetch Payload parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payload </returns> 
        public static async System.Threading.Tasks.Task<PayloadResource> FetchAsync(FetchPayloadOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of a result payload
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="addOnResultSid"> The add_on_result_sid </param>
        /// <param name="sid"> Fetch by unique payload Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payload </returns> 
        public static PayloadResource Fetch(string referenceSid, string addOnResultSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchPayloadOptions(referenceSid, addOnResultSid, sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a result payload
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="addOnResultSid"> The add_on_result_sid </param>
        /// <param name="sid"> Fetch by unique payload Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payload </returns> 
        public static async System.Threading.Tasks.Task<PayloadResource> FetchAsync(string referenceSid, string addOnResultSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchPayloadOptions(referenceSid, addOnResultSid, sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadPayloadOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Recordings/" + options.ReferenceSid + "/AddOnResults/" + options.AddOnResultSid + "/Payloads.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of payloads belonging to the Add-on result
        /// </summary>
        ///
        /// <param name="options"> Read Payload parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payload </returns> 
        public static ResourceSet<PayloadResource> Read(ReadPayloadOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<PayloadResource>.FromJson("payloads", response.Content);
            return new ResourceSet<PayloadResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of payloads belonging to the Add-on result
        /// </summary>
        ///
        /// <param name="options"> Read Payload parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payload </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<PayloadResource>> ReadAsync(ReadPayloadOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<PayloadResource>.FromJson("payloads", response.Content);
            return new ResourceSet<PayloadResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of payloads belonging to the Add-on result
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="addOnResultSid"> The add_on_result_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payload </returns> 
        public static ResourceSet<PayloadResource> Read(string referenceSid, string addOnResultSid, string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadPayloadOptions(referenceSid, addOnResultSid){AccountSid = accountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of payloads belonging to the Add-on result
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="addOnResultSid"> The add_on_result_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payload </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<PayloadResource>> ReadAsync(string referenceSid, string addOnResultSid, string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadPayloadOptions(referenceSid, addOnResultSid){AccountSid = accountSid, PageSize = pageSize, Limit = limit};
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
        public static Page<PayloadResource> NextPage(Page<PayloadResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<PayloadResource>.FromJson("payloads", response.Content);
        }
    
        private static Request BuildDeleteRequest(DeletePayloadOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Recordings/" + options.ReferenceSid + "/AddOnResults/" + options.AddOnResultSid + "/Payloads/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Delete a payload from the result along with all associated Data
        /// </summary>
        ///
        /// <param name="options"> Delete Payload parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payload </returns> 
        public static bool Delete(DeletePayloadOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Delete a payload from the result along with all associated Data
        /// </summary>
        ///
        /// <param name="options"> Delete Payload parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payload </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeletePayloadOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Delete a payload from the result along with all associated Data
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="addOnResultSid"> The add_on_result_sid </param>
        /// <param name="sid"> Delete by unique payload Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payload </returns> 
        public static bool Delete(string referenceSid, string addOnResultSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeletePayloadOptions(referenceSid, addOnResultSid, sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Delete a payload from the result along with all associated Data
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="addOnResultSid"> The add_on_result_sid </param>
        /// <param name="sid"> Delete by unique payload Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payload </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string referenceSid, string addOnResultSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeletePayloadOptions(referenceSid, addOnResultSid, sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a PayloadResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PayloadResource object represented by the provided JSON </returns> 
        public static PayloadResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<PayloadResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// A string that uniquely identifies this payload
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// A string that uniquely identifies the result
        /// </summary>
        [JsonProperty("add_on_result_sid")]
        public string AddOnResultSid { get; private set; }
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A string that describes the payload.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; private set; }
        /// <summary>
        /// A string that uniquely identifies the Add-on.
        /// </summary>
        [JsonProperty("add_on_sid")]
        public string AddOnSid { get; private set; }
        /// <summary>
        /// A string that uniquely identifies the Add-on configuration.
        /// </summary>
        [JsonProperty("add_on_configuration_sid")]
        public string AddOnConfigurationSid { get; private set; }
        /// <summary>
        /// The MIME type of the payload.
        /// </summary>
        [JsonProperty("content_type")]
        public string ContentType { get; private set; }
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
        /// A string that uniquely identifies the recording.
        /// </summary>
        [JsonProperty("reference_sid")]
        public string ReferenceSid { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
    
        private PayloadResource()
        {
        
        }
    }

}