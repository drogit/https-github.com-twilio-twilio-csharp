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

    public class SigningKeyResource : Resource 
    {
        private static Request BuildFetchRequest(FetchSigningKeyOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SigningKeys/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns> 
        public static SigningKeyResource Fetch(FetchSigningKeyOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns> 
        public static async System.Threading.Tasks.Task<SigningKeyResource> FetchAsync(FetchSigningKeyOptions options, ITwilioRestClient client = null)
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
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns> 
        public static SigningKeyResource Fetch(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchSigningKeyOptions(sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns> 
        public static async System.Threading.Tasks.Task<SigningKeyResource> FetchAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchSigningKeyOptions(sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateSigningKeyOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SigningKeys/" + options.Sid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns> 
        public static SigningKeyResource Update(UpdateSigningKeyOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Update SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns> 
        public static async System.Threading.Tasks.Task<SigningKeyResource> UpdateAsync(UpdateSigningKeyOptions options, ITwilioRestClient client = null)
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
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns> 
        public static SigningKeyResource Update(string sid, string accountSid = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateSigningKeyOptions(sid){AccountSid = accountSid, FriendlyName = friendlyName};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns> 
        public static async System.Threading.Tasks.Task<SigningKeyResource> UpdateAsync(string sid, string accountSid = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateSigningKeyOptions(sid){AccountSid = accountSid, FriendlyName = friendlyName};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteSigningKeyOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SigningKeys/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns> 
        public static bool Delete(DeleteSigningKeyOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Delete SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSigningKeyOptions options, ITwilioRestClient client = null)
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
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns> 
        public static bool Delete(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteSigningKeyOptions(sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteSigningKeyOptions(sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadSigningKeyOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SigningKeys.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns> 
        public static ResourceSet<SigningKeyResource> Read(ReadSigningKeyOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<SigningKeyResource>.FromJson("signing_keys", response.Content);
            return new ResourceSet<SigningKeyResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<SigningKeyResource>> ReadAsync(ReadSigningKeyOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<SigningKeyResource>.FromJson("signing_keys", response.Content);
            return new ResourceSet<SigningKeyResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns> 
        public static ResourceSet<SigningKeyResource> Read(string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadSigningKeyOptions{AccountSid = accountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<SigningKeyResource>> ReadAsync(string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadSigningKeyOptions{AccountSid = accountSid, PageSize = pageSize, Limit = limit};
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
        public static Page<SigningKeyResource> NextPage(Page<SigningKeyResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<SigningKeyResource>.FromJson("signing_keys", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a SigningKeyResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SigningKeyResource object represented by the provided JSON </returns> 
        public static SigningKeyResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SigningKeyResource>(json);
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
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
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
    
        private SigningKeyResource()
        {
        
        }
    }

}