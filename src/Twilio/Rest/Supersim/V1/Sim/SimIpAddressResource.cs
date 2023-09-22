/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Supersim
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
using Twilio.Types;


namespace Twilio.Rest.Supersim.V1.Sim
{
    public class SimIpAddressResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class IpAddressVersionEnum : StringEnum
        {
            private IpAddressVersionEnum(string value) : base(value) {}
            public IpAddressVersionEnum() {}
            public static implicit operator IpAddressVersionEnum(string value)
            {
                return new IpAddressVersionEnum(value);
            }
            public static readonly IpAddressVersionEnum Ipv4 = new IpAddressVersionEnum("IPv4");
            public static readonly IpAddressVersionEnum Ipv6 = new IpAddressVersionEnum("IPv6");

        }

        
        private static Request BuildReadRequest(ReadSimIpAddressOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sims/{SimSid}/IpAddresses";

            string PathSimSid = options.PathSimSid;
            path = path.Replace("{"+"SimSid"+"}", PathSimSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of IP Addresses for the given Super SIM. </summary>
        /// <param name="options"> Read SimIpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SimIpAddress </returns>
        public static ResourceSet<SimIpAddressResource> Read(ReadSimIpAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SimIpAddressResource>.FromJson("ip_addresses", response.Content);
            return new ResourceSet<SimIpAddressResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of IP Addresses for the given Super SIM. </summary>
        /// <param name="options"> Read SimIpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SimIpAddress </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SimIpAddressResource>> ReadAsync(ReadSimIpAddressOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SimIpAddressResource>.FromJson("ip_addresses", response.Content);
            return new ResourceSet<SimIpAddressResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of IP Addresses for the given Super SIM. </summary>
        /// <param name="pathSimSid"> The SID of the Super SIM to list IP Addresses for. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SimIpAddress </returns>
        public static ResourceSet<SimIpAddressResource> Read(
                                                     string pathSimSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadSimIpAddressOptions(pathSimSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of IP Addresses for the given Super SIM. </summary>
        /// <param name="pathSimSid"> The SID of the Super SIM to list IP Addresses for. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SimIpAddress </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SimIpAddressResource>> ReadAsync(
                                                                                             string pathSimSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadSimIpAddressOptions(pathSimSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SimIpAddressResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SimIpAddressResource>.FromJson("ip_addresses", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SimIpAddressResource> NextPage(Page<SimIpAddressResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SimIpAddressResource>.FromJson("ip_addresses", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SimIpAddressResource> PreviousPage(Page<SimIpAddressResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SimIpAddressResource>.FromJson("ip_addresses", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a SimIpAddressResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SimIpAddressResource object represented by the provided JSON </returns>
        public static SimIpAddressResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SimIpAddressResource>(json);
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

    
        ///<summary> IP address assigned to the given Super SIM </summary> 
        [JsonProperty("ip_address")]
        public string IpAddress { get; private set; }

        
        [JsonProperty("ip_address_version")]
        public SimIpAddressResource.IpAddressVersionEnum IpAddressVersion { get; private set; }



        private SimIpAddressResource() {

        }
    }
}

