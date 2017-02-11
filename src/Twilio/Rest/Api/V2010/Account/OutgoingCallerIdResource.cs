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

    public class OutgoingCallerIdResource : Resource 
    {
        private static Request BuildFetchRequest(FetchOutgoingCallerIdOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/OutgoingCallerIds/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an outgoing-caller-id belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Fetch OutgoingCallerId parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OutgoingCallerId </returns> 
        public static OutgoingCallerIdResource Fetch(FetchOutgoingCallerIdOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an outgoing-caller-id belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Fetch OutgoingCallerId parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OutgoingCallerId </returns> 
        public static async System.Threading.Tasks.Task<OutgoingCallerIdResource> FetchAsync(FetchOutgoingCallerIdOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an outgoing-caller-id belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique outgoing-caller-id Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OutgoingCallerId </returns> 
        public static OutgoingCallerIdResource Fetch(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchOutgoingCallerIdOptions(sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an outgoing-caller-id belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique outgoing-caller-id Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OutgoingCallerId </returns> 
        public static async System.Threading.Tasks.Task<OutgoingCallerIdResource> FetchAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchOutgoingCallerIdOptions(sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateOutgoingCallerIdOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/OutgoingCallerIds/" + options.Sid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Updates the caller-id
        /// </summary>
        ///
        /// <param name="options"> Update OutgoingCallerId parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OutgoingCallerId </returns> 
        public static OutgoingCallerIdResource Update(UpdateOutgoingCallerIdOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Updates the caller-id
        /// </summary>
        ///
        /// <param name="options"> Update OutgoingCallerId parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OutgoingCallerId </returns> 
        public static async System.Threading.Tasks.Task<OutgoingCallerIdResource> UpdateAsync(UpdateOutgoingCallerIdOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Updates the caller-id
        /// </summary>
        ///
        /// <param name="sid"> Update by unique outgoing-caller-id Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> A human readable description of the caller ID </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OutgoingCallerId </returns> 
        public static OutgoingCallerIdResource Update(string sid, string accountSid = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateOutgoingCallerIdOptions(sid){AccountSid = accountSid, FriendlyName = friendlyName};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Updates the caller-id
        /// </summary>
        ///
        /// <param name="sid"> Update by unique outgoing-caller-id Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> A human readable description of the caller ID </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OutgoingCallerId </returns> 
        public static async System.Threading.Tasks.Task<OutgoingCallerIdResource> UpdateAsync(string sid, string accountSid = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateOutgoingCallerIdOptions(sid){AccountSid = accountSid, FriendlyName = friendlyName};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteOutgoingCallerIdOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/OutgoingCallerIds/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Delete the caller-id specified from the account
        /// </summary>
        ///
        /// <param name="options"> Delete OutgoingCallerId parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OutgoingCallerId </returns> 
        public static bool Delete(DeleteOutgoingCallerIdOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Delete the caller-id specified from the account
        /// </summary>
        ///
        /// <param name="options"> Delete OutgoingCallerId parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OutgoingCallerId </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteOutgoingCallerIdOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Delete the caller-id specified from the account
        /// </summary>
        ///
        /// <param name="sid"> Delete by unique outgoing-caller-id Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OutgoingCallerId </returns> 
        public static bool Delete(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteOutgoingCallerIdOptions(sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Delete the caller-id specified from the account
        /// </summary>
        ///
        /// <param name="sid"> Delete by unique outgoing-caller-id Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OutgoingCallerId </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteOutgoingCallerIdOptions(sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadOutgoingCallerIdOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/OutgoingCallerIds.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of outgoing-caller-ids belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read OutgoingCallerId parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OutgoingCallerId </returns> 
        public static ResourceSet<OutgoingCallerIdResource> Read(ReadOutgoingCallerIdOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<OutgoingCallerIdResource>.FromJson("outgoing_caller_ids", response.Content);
            return new ResourceSet<OutgoingCallerIdResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of outgoing-caller-ids belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read OutgoingCallerId parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OutgoingCallerId </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<OutgoingCallerIdResource>> ReadAsync(ReadOutgoingCallerIdOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<OutgoingCallerIdResource>.FromJson("outgoing_caller_ids", response.Content);
            return new ResourceSet<OutgoingCallerIdResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of outgoing-caller-ids belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="phoneNumber"> Filter by phone number </param>
        /// <param name="friendlyName"> Filter by friendly name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OutgoingCallerId </returns> 
        public static ResourceSet<OutgoingCallerIdResource> Read(string accountSid = null, Types.PhoneNumber phoneNumber = null, string friendlyName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadOutgoingCallerIdOptions{AccountSid = accountSid, PhoneNumber = phoneNumber, FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of outgoing-caller-ids belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="phoneNumber"> Filter by phone number </param>
        /// <param name="friendlyName"> Filter by friendly name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OutgoingCallerId </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<OutgoingCallerIdResource>> ReadAsync(string accountSid = null, Types.PhoneNumber phoneNumber = null, string friendlyName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadOutgoingCallerIdOptions{AccountSid = accountSid, PhoneNumber = phoneNumber, FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
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
        public static Page<OutgoingCallerIdResource> NextPage(Page<OutgoingCallerIdResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<OutgoingCallerIdResource>.FromJson("outgoing_caller_ids", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a OutgoingCallerIdResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> OutgoingCallerIdResource object represented by the provided JSON </returns> 
        public static OutgoingCallerIdResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<OutgoingCallerIdResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// A string that uniquely identifies this outgoing-caller-ids
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
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
        /// A human readable description for this resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The incoming phone number
        /// </summary>
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private OutgoingCallerIdResource()
        {
        
        }
    }

}