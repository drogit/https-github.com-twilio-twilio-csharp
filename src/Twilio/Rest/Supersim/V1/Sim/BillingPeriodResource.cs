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
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Supersim.V1.Sim
{
    public class BillingPeriodResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class BpTypeEnum : StringEnum
        {
            private BpTypeEnum(string value) : base(value) {}
            public BpTypeEnum() {}
            public static implicit operator BpTypeEnum(string value)
            {
                return new BpTypeEnum(value);
            }
            public static readonly BpTypeEnum Ready = new BpTypeEnum("ready");
            public static readonly BpTypeEnum Active = new BpTypeEnum("active");

        }

        
        private static Request BuildReadRequest(ReadBillingPeriodOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sims/{SimSid}/BillingPeriods";

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
        /// <summary> Retrieve a list of Billing Periods for a Super SIM. </summary>
        /// <param name="options"> Read BillingPeriod parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BillingPeriod </returns>
        public static ResourceSet<BillingPeriodResource> Read(ReadBillingPeriodOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<BillingPeriodResource>.FromJson("billing_periods", response.Content);
            return new ResourceSet<BillingPeriodResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Billing Periods for a Super SIM. </summary>
        /// <param name="options"> Read BillingPeriod parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BillingPeriod </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BillingPeriodResource>> ReadAsync(ReadBillingPeriodOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BillingPeriodResource>.FromJson("billing_periods", response.Content);
            return new ResourceSet<BillingPeriodResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Billing Periods for a Super SIM. </summary>
        /// <param name="pathSimSid"> The SID of the Super SIM to list Billing Periods for. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BillingPeriod </returns>
        public static ResourceSet<BillingPeriodResource> Read(
                                                     string pathSimSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadBillingPeriodOptions(pathSimSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Billing Periods for a Super SIM. </summary>
        /// <param name="pathSimSid"> The SID of the Super SIM to list Billing Periods for. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BillingPeriod </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BillingPeriodResource>> ReadAsync(
                                                                                             string pathSimSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadBillingPeriodOptions(pathSimSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<BillingPeriodResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BillingPeriodResource>.FromJson("billing_periods", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<BillingPeriodResource> NextPage(Page<BillingPeriodResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BillingPeriodResource>.FromJson("billing_periods", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<BillingPeriodResource> PreviousPage(Page<BillingPeriodResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BillingPeriodResource>.FromJson("billing_periods", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a BillingPeriodResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BillingPeriodResource object represented by the provided JSON </returns>
        public static BillingPeriodResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BillingPeriodResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the Billing Period. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) the Super SIM belongs to. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Super SIM the Billing Period belongs to. </summary> 
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }

        ///<summary> The start time of the Billing Period specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("start_time")]
        public DateTime? StartTime { get; private set; }

        ///<summary> The end time of the Billing Period specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; private set; }

        
        [JsonProperty("period_type")]
        public BillingPeriodResource.BpTypeEnum PeriodType { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }



        private BillingPeriodResource() {

        }
    }
}

