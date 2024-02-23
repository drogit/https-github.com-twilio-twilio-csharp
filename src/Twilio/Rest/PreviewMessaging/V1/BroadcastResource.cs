/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Bulk Messaging and Broadcast
 * Bulk Sending is a public Twilio REST API for 1:Many Message creation up to 100 recipients. Broadcast is a public Twilio REST API for 1:Many Message creation up to 10,000 recipients via file upload.
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



namespace Twilio.Rest.PreviewMessaging.V1
{
    public class BroadcastResource : Resource
    {
    
        public class MessagingV1BroadcastExecutionDetails
        {
            [JsonProperty("total_records")]
            private int? TotalRecords {get; set;}
            [JsonProperty("total_completed")]
            private int? TotalCompleted {get; set;}
            [JsonProperty("total_errors")]
            private int? TotalErrors {get; set;}
            public MessagingV1BroadcastExecutionDetails() { }
            public class Builder
            {
                private MessagingV1BroadcastExecutionDetails _messagingV1BroadcastExecutionDetails = new MessagingV1BroadcastExecutionDetails();
                public Builder()
                {
                }
                public Builder WithTotalRecords(int? totalRecords)
                {
                    _messagingV1BroadcastExecutionDetails.TotalRecords= totalRecords;
                    return this;
                }
                public Builder WithTotalCompleted(int? totalCompleted)
                {
                    _messagingV1BroadcastExecutionDetails.TotalCompleted= totalCompleted;
                    return this;
                }
                public Builder WithTotalErrors(int? totalErrors)
                {
                    _messagingV1BroadcastExecutionDetails.TotalErrors= totalErrors;
                    return this;
                }
                public MessagingV1BroadcastExecutionDetails Build()
                {
                    return _messagingV1BroadcastExecutionDetails;
                }
            }
        }

    

        
        private static Request BuildCreateRequest(CreateBroadcastOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Broadcasts";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.PreviewMessaging,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Create a new Broadcast </summary>
        /// <param name="options"> Create Broadcast parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Broadcast </returns>
        public static BroadcastResource Create(CreateBroadcastOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Broadcast </summary>
        /// <param name="options"> Create Broadcast parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Broadcast </returns>
        public static async System.Threading.Tasks.Task<BroadcastResource> CreateAsync(CreateBroadcastOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Broadcast </summary>
        /// <param name="xTwilioRequestKey"> Idempotency key provided by the client </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Broadcast </returns>
        public static BroadcastResource Create(
                                          Guid? xTwilioRequestKey = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateBroadcastOptions(){  XTwilioRequestKey = xTwilioRequestKey };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Broadcast </summary>
        /// <param name="xTwilioRequestKey"> Idempotency key provided by the client </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Broadcast </returns>
        public static async System.Threading.Tasks.Task<BroadcastResource> CreateAsync(
                                                                                  Guid? xTwilioRequestKey = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateBroadcastOptions(){  XTwilioRequestKey = xTwilioRequestKey };
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BroadcastResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BroadcastResource object represented by the provided JSON </returns>
        public static BroadcastResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BroadcastResource>(json);
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

    
        ///<summary> Numeric ID indentifying individual Broadcast requests </summary> 
        [JsonProperty("broadcast_sid")]
        public string BroadcastSid { get; private set; }

        ///<summary> Timestamp of when the Broadcast was created </summary> 
        [JsonProperty("created_date")]
        public DateTime? CreatedDate { get; private set; }

        ///<summary> Timestamp of when the Broadcast was last updated </summary> 
        [JsonProperty("updated_date")]
        public DateTime? UpdatedDate { get; private set; }

        ///<summary> Status of the Broadcast request. Valid values are None, Pending-Upload, Uploaded, Queued, Executing, Execution-Failure, Execution-Completed, Cancelation-Requested, and Canceled </summary> 
        [JsonProperty("broadcast_status")]
        public string BroadcastStatus { get; private set; }

        ///<summary> The execution_details </summary> 
        [JsonProperty("execution_details")]
        public MessagingV1BroadcastExecutionDetails ExecutionDetails { get; private set; }

        ///<summary> Path to a file detailing successful requests and errors from Broadcast execution </summary> 
        [JsonProperty("results_file")]
        public Uri ResultsFile { get; private set; }

        ///<summary> The Twilio error code </summary> 
        [JsonProperty("code")]
        public int? Code { get; private set; }

        ///<summary> The error message details </summary> 
        [JsonProperty("message")]
        public string Message { get; private set; }

        ///<summary> The HTTP status code </summary> 
        [JsonProperty("status")]
        public int? Status { get; private set; }

        ///<summary> More information on the error </summary> 
        [JsonProperty("more_info")]
        public string MoreInfo { get; private set; }



        private BroadcastResource() {

        }
    }
}

