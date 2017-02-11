using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Notify.V1.Service 
{

    public class BindingResource : Resource 
    {
        public sealed class BindingTypeEnum : StringEnum 
        {
            private BindingTypeEnum(string value) : base(value) {}
            public BindingTypeEnum() {}
        
            public static readonly BindingTypeEnum Apn = new BindingTypeEnum("apn");
            public static readonly BindingTypeEnum Gcm = new BindingTypeEnum("gcm");
            public static readonly BindingTypeEnum Sms = new BindingTypeEnum("sms");
            public static readonly BindingTypeEnum Fcm = new BindingTypeEnum("fcm");
            public static readonly BindingTypeEnum FacebookMessenger = new BindingTypeEnum("facebook-messenger");
        }
    
        private static Request BuildFetchRequest(FetchBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Notify,
                "/v1/Services/" + options.ServiceSid + "/Bindings/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static BindingResource Fetch(FetchBindingOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<BindingResource> FetchAsync(FetchBindingOptions options, ITwilioRestClient client = null)
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
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static BindingResource Fetch(string serviceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchBindingOptions(serviceSid, sid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<BindingResource> FetchAsync(string serviceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchBindingOptions(serviceSid, sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Notify,
                "/v1/Services/" + options.ServiceSid + "/Bindings/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static bool Delete(DeleteBindingOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteBindingOptions options, ITwilioRestClient client = null)
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
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static bool Delete(string serviceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteBindingOptions(serviceSid, sid);
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string serviceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteBindingOptions(serviceSid, sid);
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildCreateRequest(CreateBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Notify,
                "/v1/Services/" + options.ServiceSid + "/Bindings",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static BindingResource Create(CreateBindingOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Create Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<BindingResource> CreateAsync(CreateBindingOptions options, ITwilioRestClient client = null)
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
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="endpoint"> The endpoint </param>
        /// <param name="identity"> The identity </param>
        /// <param name="bindingType"> The binding_type </param>
        /// <param name="address"> The address </param>
        /// <param name="tag"> The tag </param>
        /// <param name="notificationProtocolVersion"> The notification_protocol_version </param>
        /// <param name="credentialSid"> The credential_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static BindingResource Create(string serviceSid, string endpoint, string identity, BindingResource.BindingTypeEnum bindingType, string address, List<string> tag = null, string notificationProtocolVersion = null, string credentialSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateBindingOptions(serviceSid, endpoint, identity, bindingType, address){Tag = tag, NotificationProtocolVersion = notificationProtocolVersion, CredentialSid = credentialSid};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="endpoint"> The endpoint </param>
        /// <param name="identity"> The identity </param>
        /// <param name="bindingType"> The binding_type </param>
        /// <param name="address"> The address </param>
        /// <param name="tag"> The tag </param>
        /// <param name="notificationProtocolVersion"> The notification_protocol_version </param>
        /// <param name="credentialSid"> The credential_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<BindingResource> CreateAsync(string serviceSid, string endpoint, string identity, BindingResource.BindingTypeEnum bindingType, string address, List<string> tag = null, string notificationProtocolVersion = null, string credentialSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateBindingOptions(serviceSid, endpoint, identity, bindingType, address){Tag = tag, NotificationProtocolVersion = notificationProtocolVersion, CredentialSid = credentialSid};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadBindingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Notify,
                "/v1/Services/" + options.ServiceSid + "/Bindings",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static ResourceSet<BindingResource> Read(ReadBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<BindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<BindingResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<BindingResource>> ReadAsync(ReadBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<BindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<BindingResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        /// <param name="identity"> The identity </param>
        /// <param name="tag"> The tag </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns> 
        public static ResourceSet<BindingResource> Read(string serviceSid, DateTime? startDate = null, DateTime? endDate = null, List<string> identity = null, List<string> tag = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadBindingOptions(serviceSid){StartDate = startDate, EndDate = endDate, Identity = identity, Tag = tag, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        /// <param name="identity"> The identity </param>
        /// <param name="tag"> The tag </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<BindingResource>> ReadAsync(string serviceSid, DateTime? startDate = null, DateTime? endDate = null, List<string> identity = null, List<string> tag = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadBindingOptions(serviceSid){StartDate = startDate, EndDate = endDate, Identity = identity, Tag = tag, PageSize = pageSize, Limit = limit};
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
        public static Page<BindingResource> NextPage(Page<BindingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Notify,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a BindingResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BindingResource object represented by the provided JSON </returns> 
        public static BindingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<BindingResource>(json);
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
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The credential_sid
        /// </summary>
        [JsonProperty("credential_sid")]
        public string CredentialSid { get; private set; }
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
        /// The notification_protocol_version
        /// </summary>
        [JsonProperty("notification_protocol_version")]
        public string NotificationProtocolVersion { get; private set; }
        /// <summary>
        /// The endpoint
        /// </summary>
        [JsonProperty("endpoint")]
        public string Endpoint { get; private set; }
        /// <summary>
        /// The identity
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
        /// <summary>
        /// The binding_type
        /// </summary>
        [JsonProperty("binding_type")]
        public string BindingType { get; private set; }
        /// <summary>
        /// The address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; private set; }
        /// <summary>
        /// The tags
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private BindingResource()
        {
        
        }
    }

}