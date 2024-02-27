/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Numbers
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


namespace Twilio.Rest.Numbers.V2
{
    public class BulkHostedNumberOrderResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class RequestStatusEnum : StringEnum
        {
            private RequestStatusEnum(string value) : base(value) {}
            public RequestStatusEnum() {}
            public static implicit operator RequestStatusEnum(string value)
            {
                return new RequestStatusEnum(value);
            }
            public static readonly RequestStatusEnum Queued = new RequestStatusEnum("QUEUED");
            public static readonly RequestStatusEnum InProgress = new RequestStatusEnum("IN_PROGRESS");
            public static readonly RequestStatusEnum Processed = new RequestStatusEnum("PROCESSED");

        }

        
        private static Request BuildCreateRequest(CreateBulkHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/Orders/Bulk";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                path,
                
                contentType: EnumConstants.ContentTypeEnum.JSON,
                body: options.GetBody(),
                headerParams: null
            );
        }

        /// <summary> Host multiple phone numbers on Twilio's platform. </summary>
        /// <param name="options"> Create BulkHostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkHostedNumberOrder </returns>
        public static BulkHostedNumberOrderResource Create(CreateBulkHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Host multiple phone numbers on Twilio's platform. </summary>
        /// <param name="options"> Create BulkHostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkHostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<BulkHostedNumberOrderResource> CreateAsync(CreateBulkHostedNumberOrderOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Host multiple phone numbers on Twilio's platform. </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkHostedNumberOrder </returns>
        public static BulkHostedNumberOrderResource Create(
                                          ITwilioRestClient client = null)
        {
            var options = new CreateBulkHostedNumberOrderOptions(){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Host multiple phone numbers on Twilio's platform. </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkHostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<BulkHostedNumberOrderResource> CreateAsync(
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateBulkHostedNumberOrderOptions(){  };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchBulkHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/Orders/Bulk/{BulkHostingSid}";

            string PathBulkHostingSid = options.PathBulkHostingSid;
            path = path.Replace("{"+"BulkHostingSid"+"}", PathBulkHostingSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific BulkHostedNumberOrder. </summary>
        /// <param name="options"> Fetch BulkHostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkHostedNumberOrder </returns>
        public static BulkHostedNumberOrderResource Fetch(FetchBulkHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific BulkHostedNumberOrder. </summary>
        /// <param name="options"> Fetch BulkHostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkHostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<BulkHostedNumberOrderResource> FetchAsync(FetchBulkHostedNumberOrderOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific BulkHostedNumberOrder. </summary>
        /// <param name="pathBulkHostingSid"> A 34 character string that uniquely identifies this BulkHostedNumberOrder. </param>
        /// <param name="orderStatus"> Order status can be used for filtering on Hosted Number Order status values. To see a complete list of order statuses, please check 'https://www.twilio.com/docs/phone-numbers/hosted-numbers/hosted-numbers-api/hosted-number-order-resource#status-values'. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkHostedNumberOrder </returns>
        public static BulkHostedNumberOrderResource Fetch(
                                         string pathBulkHostingSid, 
                                         string orderStatus = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchBulkHostedNumberOrderOptions(pathBulkHostingSid){ OrderStatus = orderStatus };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific BulkHostedNumberOrder. </summary>
        /// <param name="pathBulkHostingSid"> A 34 character string that uniquely identifies this BulkHostedNumberOrder. </param>
        /// <param name="orderStatus"> Order status can be used for filtering on Hosted Number Order status values. To see a complete list of order statuses, please check 'https://www.twilio.com/docs/phone-numbers/hosted-numbers/hosted-numbers-api/hosted-number-order-resource#status-values'. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkHostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<BulkHostedNumberOrderResource> FetchAsync(string pathBulkHostingSid, string orderStatus = null, ITwilioRestClient client = null)
        {
            var options = new FetchBulkHostedNumberOrderOptions(pathBulkHostingSid){ OrderStatus = orderStatus };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BulkHostedNumberOrderResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BulkHostedNumberOrderResource object represented by the provided JSON </returns>
        public static BulkHostedNumberOrderResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BulkHostedNumberOrderResource>(json);
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

    
        ///<summary> A 34 character string that uniquely identifies this BulkHostedNumberOrder. </summary> 
        [JsonProperty("bulk_hosting_sid")]
        public string BulkHostingSid { get; private set; }

        
        [JsonProperty("request_status")]
        public BulkHostedNumberOrderResource.RequestStatusEnum RequestStatus { get; private set; }

        ///<summary> A 128 character string that is a human-readable text that describes this resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> Email address used for send notifications about this Bulk hosted number request. </summary> 
        [JsonProperty("notification_email")]
        public string NotificationEmail { get; private set; }

        ///<summary> The date this resource was created, given as [GMT RFC 2822](http://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was completed, given as [GMT RFC 2822](http://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_completed")]
        public DateTime? DateCompleted { get; private set; }

        ///<summary> The URL of this BulkHostedNumberOrder resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The total count of phone numbers in this Bulk hosting request. </summary> 
        [JsonProperty("total_count")]
        public int? TotalCount { get; private set; }

        ///<summary> Contains a list of all the individual hosting orders and their information, for this Bulk request. Each result object is grouped by its order status. To see a complete list of order status, please check 'https://www.twilio.com/docs/phone-numbers/hosted-numbers/hosted-numbers-api/hosted-number-order-resource#status-values'. </summary> 
        [JsonProperty("results")]
        public List<object> Results { get; private set; }



        private BulkHostedNumberOrderResource() {

        }
    }
}

