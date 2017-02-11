using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Recording 
{

    public class AddOnResultResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
        
            public static readonly StatusEnum Canceled = new StatusEnum("canceled");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Deleted = new StatusEnum("deleted");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum InProgress = new StatusEnum("in-progress");
            public static readonly StatusEnum Init = new StatusEnum("init");
            public static readonly StatusEnum Processing = new StatusEnum("processing");
            public static readonly StatusEnum Queued = new StatusEnum("queued");
        }
    
        private static Request BuildFetchRequest(FetchAddOnResultOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Recordings/" + options.ReferenceSid + "/AddOnResults/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of an Add-on result
        /// </summary>
        ///
        /// <param name="options"> Fetch AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns> 
        public static AddOnResultResource Fetch(FetchAddOnResultOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of an Add-on result
        /// </summary>
        ///
        /// <param name="options"> Fetch AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns> 
        public static async System.Threading.Tasks.Task<AddOnResultResource> FetchAsync(FetchAddOnResultOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of an Add-on result
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="sid"> Fetch by unique result Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns> 
        public static AddOnResultResource Fetch(string referenceSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAddOnResultOptions(referenceSid, sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of an Add-on result
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="sid"> Fetch by unique result Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns> 
        public static async System.Threading.Tasks.Task<AddOnResultResource> FetchAsync(string referenceSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAddOnResultOptions(referenceSid, sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadAddOnResultOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Recordings/" + options.ReferenceSid + "/AddOnResults.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of results belonging to the recording
        /// </summary>
        ///
        /// <param name="options"> Read AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns> 
        public static ResourceSet<AddOnResultResource> Read(ReadAddOnResultOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<AddOnResultResource>.FromJson("add_on_results", response.Content);
            return new ResourceSet<AddOnResultResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of results belonging to the recording
        /// </summary>
        ///
        /// <param name="options"> Read AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AddOnResultResource>> ReadAsync(ReadAddOnResultOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<AddOnResultResource>.FromJson("add_on_results", response.Content);
            return new ResourceSet<AddOnResultResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of results belonging to the recording
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns> 
        public static ResourceSet<AddOnResultResource> Read(string referenceSid, string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAddOnResultOptions(referenceSid){AccountSid = accountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of results belonging to the recording
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AddOnResultResource>> ReadAsync(string referenceSid, string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAddOnResultOptions(referenceSid){AccountSid = accountSid, PageSize = pageSize, Limit = limit};
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
        public static Page<AddOnResultResource> NextPage(Page<AddOnResultResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<AddOnResultResource>.FromJson("add_on_results", response.Content);
        }
    
        private static Request BuildDeleteRequest(DeleteAddOnResultOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Recordings/" + options.ReferenceSid + "/AddOnResults/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Delete a result and purge all associated Payloads
        /// </summary>
        ///
        /// <param name="options"> Delete AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns> 
        public static bool Delete(DeleteAddOnResultOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Delete a result and purge all associated Payloads
        /// </summary>
        ///
        /// <param name="options"> Delete AddOnResult parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAddOnResultOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Delete a result and purge all associated Payloads
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="sid"> Delete by unique result Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AddOnResult </returns> 
        public static bool Delete(string referenceSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteAddOnResultOptions(referenceSid, sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Delete a result and purge all associated Payloads
        /// </summary>
        ///
        /// <param name="referenceSid"> The reference_sid </param>
        /// <param name="sid"> Delete by unique result Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AddOnResult </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string referenceSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteAddOnResultOptions(referenceSid, sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a AddOnResultResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AddOnResultResource object represented by the provided JSON </returns> 
        public static AddOnResultResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AddOnResultResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// A string that uniquely identifies this result
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The status of this result.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AddOnResultResource.StatusEnum Status { get; private set; }
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
        /// The date this result was completed.
        /// </summary>
        [JsonProperty("date_completed")]
        public DateTime? DateCompleted { get; private set; }
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
    
        private AddOnResultResource()
        {
        
        }
    }

}