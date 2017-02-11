using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Message 
{

    public class MediaResource : Resource 
    {
        private static Request BuildDeleteRequest(DeleteMediaOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Messages/" + options.MessageSid + "/Media/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Delete media from your account. Once delete, you will no longer be billed
        /// </summary>
        ///
        /// <param name="options"> Delete Media parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Media </returns> 
        public static bool Delete(DeleteMediaOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Delete media from your account. Once delete, you will no longer be billed
        /// </summary>
        ///
        /// <param name="options"> Delete Media parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Media </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMediaOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Delete media from your account. Once delete, you will no longer be billed
        /// </summary>
        ///
        /// <param name="messageSid"> The message_sid </param>
        /// <param name="sid"> Delete by unique media Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Media </returns> 
        public static bool Delete(string messageSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteMediaOptions(messageSid, sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Delete media from your account. Once delete, you will no longer be billed
        /// </summary>
        ///
        /// <param name="messageSid"> The message_sid </param>
        /// <param name="sid"> Delete by unique media Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Media </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string messageSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteMediaOptions(messageSid, sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildFetchRequest(FetchMediaOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Messages/" + options.MessageSid + "/Media/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch a single media instance belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Fetch Media parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Media </returns> 
        public static MediaResource Fetch(FetchMediaOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch a single media instance belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Fetch Media parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Media </returns> 
        public static async System.Threading.Tasks.Task<MediaResource> FetchAsync(FetchMediaOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch a single media instance belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="messageSid"> The message_sid </param>
        /// <param name="sid"> Fetch by unique media Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Media </returns> 
        public static MediaResource Fetch(string messageSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchMediaOptions(messageSid, sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch a single media instance belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="messageSid"> The message_sid </param>
        /// <param name="sid"> Fetch by unique media Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Media </returns> 
        public static async System.Threading.Tasks.Task<MediaResource> FetchAsync(string messageSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchMediaOptions(messageSid, sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadMediaOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Messages/" + options.MessageSid + "/Media.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of medias belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Media parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Media </returns> 
        public static ResourceSet<MediaResource> Read(ReadMediaOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<MediaResource>.FromJson("media_list", response.Content);
            return new ResourceSet<MediaResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of medias belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Media parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Media </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MediaResource>> ReadAsync(ReadMediaOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<MediaResource>.FromJson("media_list", response.Content);
            return new ResourceSet<MediaResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of medias belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="messageSid"> The message_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="dateCreatedBefore"> Filter by date created </param>
        /// <param name="dateCreated"> Filter by date created </param>
        /// <param name="dateCreatedAfter"> Filter by date created </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Media </returns> 
        public static ResourceSet<MediaResource> Read(string messageSid, string accountSid = null, DateTime? dateCreatedBefore = null, DateTime? dateCreated = null, DateTime? dateCreatedAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMediaOptions(messageSid){AccountSid = accountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of medias belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="messageSid"> The message_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="dateCreatedBefore"> Filter by date created </param>
        /// <param name="dateCreated"> Filter by date created </param>
        /// <param name="dateCreatedAfter"> Filter by date created </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Media </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MediaResource>> ReadAsync(string messageSid, string accountSid = null, DateTime? dateCreatedBefore = null, DateTime? dateCreated = null, DateTime? dateCreatedAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMediaOptions(messageSid){AccountSid = accountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, PageSize = pageSize, Limit = limit};
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
        public static Page<MediaResource> NextPage(Page<MediaResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<MediaResource>.FromJson("media_list", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a MediaResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MediaResource object represented by the provided JSON </returns> 
        public static MediaResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MediaResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The default mime-type of the media
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
        /// The unique id of the resource that created the media.
        /// </summary>
        [JsonProperty("parent_sid")]
        public string ParentSid { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this media
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private MediaResource()
        {
        
        }
    }

}