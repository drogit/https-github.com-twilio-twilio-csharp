/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Insights
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


namespace Twilio.Rest.Insights.V1
{
    public class CallSummariesResource : Resource
    {
    

    
        public sealed class ProcessingStateRequestEnum : StringEnum
        {
            private ProcessingStateRequestEnum(string value) : base(value) {}
            public ProcessingStateRequestEnum() {}
            public static implicit operator ProcessingStateRequestEnum(string value)
            {
                return new ProcessingStateRequestEnum(value);
            }
            public static readonly ProcessingStateRequestEnum Completed = new ProcessingStateRequestEnum("completed");
            public static readonly ProcessingStateRequestEnum Started = new ProcessingStateRequestEnum("started");
            public static readonly ProcessingStateRequestEnum Partial = new ProcessingStateRequestEnum("partial");
            public static readonly ProcessingStateRequestEnum All = new ProcessingStateRequestEnum("all");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class ProcessingStateEnum : StringEnum
        {
            private ProcessingStateEnum(string value) : base(value) {}
            public ProcessingStateEnum() {}
            public static implicit operator ProcessingStateEnum(string value)
            {
                return new ProcessingStateEnum(value);
            }
            public static readonly ProcessingStateEnum Complete = new ProcessingStateEnum("complete");
            public static readonly ProcessingStateEnum Partial = new ProcessingStateEnum("partial");

        }
        public sealed class SortByEnum : StringEnum
        {
            private SortByEnum(string value) : base(value) {}
            public SortByEnum() {}
            public static implicit operator SortByEnum(string value)
            {
                return new SortByEnum(value);
            }
            public static readonly SortByEnum StartTime = new SortByEnum("start_time");
            public static readonly SortByEnum EndTime = new SortByEnum("end_time");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class AnsweredByEnum : StringEnum
        {
            private AnsweredByEnum(string value) : base(value) {}
            public AnsweredByEnum() {}
            public static implicit operator AnsweredByEnum(string value)
            {
                return new AnsweredByEnum(value);
            }
            public static readonly AnsweredByEnum Unknown = new AnsweredByEnum("unknown");
            public static readonly AnsweredByEnum MachineStart = new AnsweredByEnum("machine_start");
            public static readonly AnsweredByEnum MachineEndBeep = new AnsweredByEnum("machine_end_beep");
            public static readonly AnsweredByEnum MachineEndSilence = new AnsweredByEnum("machine_end_silence");
            public static readonly AnsweredByEnum MachineEndOther = new AnsweredByEnum("machine_end_other");
            public static readonly AnsweredByEnum Human = new AnsweredByEnum("human");
            public static readonly AnsweredByEnum Fax = new AnsweredByEnum("fax");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class CallStateEnum : StringEnum
        {
            private CallStateEnum(string value) : base(value) {}
            public CallStateEnum() {}
            public static implicit operator CallStateEnum(string value)
            {
                return new CallStateEnum(value);
            }
            public static readonly CallStateEnum Ringing = new CallStateEnum("ringing");
            public static readonly CallStateEnum Completed = new CallStateEnum("completed");
            public static readonly CallStateEnum Busy = new CallStateEnum("busy");
            public static readonly CallStateEnum Fail = new CallStateEnum("fail");
            public static readonly CallStateEnum Noanswer = new CallStateEnum("noanswer");
            public static readonly CallStateEnum Canceled = new CallStateEnum("canceled");
            public static readonly CallStateEnum Answered = new CallStateEnum("answered");
            public static readonly CallStateEnum Undialed = new CallStateEnum("undialed");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class CallTypeEnum : StringEnum
        {
            private CallTypeEnum(string value) : base(value) {}
            public CallTypeEnum() {}
            public static implicit operator CallTypeEnum(string value)
            {
                return new CallTypeEnum(value);
            }
            public static readonly CallTypeEnum Carrier = new CallTypeEnum("carrier");
            public static readonly CallTypeEnum Sip = new CallTypeEnum("sip");
            public static readonly CallTypeEnum Trunking = new CallTypeEnum("trunking");
            public static readonly CallTypeEnum Client = new CallTypeEnum("client");

        }

        
        private static Request BuildReadRequest(ReadCallSummariesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Voice/Summaries";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Get a list of Call Summaries. </summary>
        /// <param name="options"> Read CallSummaries parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CallSummaries </returns>
        public static ResourceSet<CallSummariesResource> Read(ReadCallSummariesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CallSummariesResource>.FromJson("call_summaries", response.Content);
            return new ResourceSet<CallSummariesResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Get a list of Call Summaries. </summary>
        /// <param name="options"> Read CallSummaries parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CallSummaries </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CallSummariesResource>> ReadAsync(ReadCallSummariesOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CallSummariesResource>.FromJson("call_summaries", response.Content);
            return new ResourceSet<CallSummariesResource>(page, options, client);
        }
        #endif
        /// <summary> Get a list of Call Summaries. </summary>
        /// <param name="from"> A calling party. Could be an E.164 number, a SIP URI, or a Twilio Client registered name. </param>
        /// <param name="to"> A called party. Could be an E.164 number, a SIP URI, or a Twilio Client registered name. </param>
        /// <param name="fromCarrier"> An origination carrier. </param>
        /// <param name="toCarrier"> A destination carrier. </param>
        /// <param name="fromCountryCode"> A source country code based on phone number in From. </param>
        /// <param name="toCountryCode"> A destination country code. Based on phone number in To. </param>
        /// <param name="branded"> A boolean flag indicating whether or not the calls were branded using Twilio Branded Calls. </param>
        /// <param name="verifiedCaller"> A boolean flag indicating whether or not the caller was verified using SHAKEN/STIR. </param>
        /// <param name="hasTag"> A boolean flag indicating the presence of one or more [Voice Insights Call Tags](https://www.twilio.com/docs/voice/voice-insights/api/call/details-call-tags). </param>
        /// <param name="startTime"> A Start time of the calls. xm (x minutes), xh (x hours), xd (x days), 1w, 30m, 3d, 4w or datetime-ISO. Defaults to 4h. </param>
        /// <param name="endTime"> An End Time of the calls. xm (x minutes), xh (x hours), xd (x days), 1w, 30m, 3d, 4w or datetime-ISO. Defaults to 0m. </param>
        /// <param name="callType"> A Call Type of the calls. One of `carrier`, `sip`, `trunking` or `client`. </param>
        /// <param name="callState"> A Call State of the calls. One of `ringing`, `completed`, `busy`, `fail`, `noanswer`, `canceled`, `answered`, `undialed`. </param>
        /// <param name="direction"> A Direction of the calls. One of `outbound_api`, `outbound_dial`, `inbound`, `trunking_originating`, `trunking_terminating`. </param>
        /// <param name="processingState"> A Processing State of the Call Summaries. One of `completed`, `partial` or `all`. </param>
        /// <param name="sortBy"> A Sort By criterion for the returned list of Call Summaries. One of `start_time` or `end_time`. </param>
        /// <param name="subaccount"> A unique SID identifier of a Subaccount. </param>
        /// <param name="abnormalSession"> A boolean flag indicating an abnormal session where the last SIP response was not 200 OK. </param>
        /// <param name="answeredBy"> An Answered By value for the calls based on `Answering Machine Detection (AMD)`. One of `unknown`, `machine_start`, `machine_end_beep`, `machine_end_silence`, `machine_end_other`, `human` or `fax`. </param>
        /// <param name="answeredByAnnotation"> Either machine or human. </param>
        /// <param name="connectivityIssueAnnotation"> A Connectivity Issue with the calls. One of `no_connectivity_issue`, `invalid_number`, `caller_id`, `dropped_call`, or `number_reachability`. </param>
        /// <param name="qualityIssueAnnotation"> A subjective Quality Issue with the calls. One of `no_quality_issue`, `low_volume`, `choppy_robotic`, `echo`, `dtmf`, `latency`, `owa`, `static_noise`. </param>
        /// <param name="spamAnnotation"> A boolean flag indicating spam calls. </param>
        /// <param name="callScoreAnnotation"> A Call Score of the calls. Use a range of 1-5 to indicate the call experience score, with the following mapping as a reference for the rated call [5: Excellent, 4: Good, 3 : Fair, 2 : Poor, 1: Bad]. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CallSummaries </returns>
        public static ResourceSet<CallSummariesResource> Read(
                                                     string from = null,
                                                     string to = null,
                                                     string fromCarrier = null,
                                                     string toCarrier = null,
                                                     string fromCountryCode = null,
                                                     string toCountryCode = null,
                                                     bool? branded = null,
                                                     bool? verifiedCaller = null,
                                                     bool? hasTag = null,
                                                     string startTime = null,
                                                     string endTime = null,
                                                     string callType = null,
                                                     string callState = null,
                                                     string direction = null,
                                                     CallSummariesResource.ProcessingStateRequestEnum processingState = null,
                                                     CallSummariesResource.SortByEnum sortBy = null,
                                                     string subaccount = null,
                                                     bool? abnormalSession = null,
                                                     CallSummariesResource.AnsweredByEnum answeredBy = null,
                                                     string answeredByAnnotation = null,
                                                     string connectivityIssueAnnotation = null,
                                                     string qualityIssueAnnotation = null,
                                                     bool? spamAnnotation = null,
                                                     string callScoreAnnotation = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadCallSummariesOptions(){ From = from, To = to, FromCarrier = fromCarrier, ToCarrier = toCarrier, FromCountryCode = fromCountryCode, ToCountryCode = toCountryCode, Branded = branded, VerifiedCaller = verifiedCaller, HasTag = hasTag, StartTime = startTime, EndTime = endTime, CallType = callType, CallState = callState, Direction = direction, ProcessingState = processingState, SortBy = sortBy, Subaccount = subaccount, AbnormalSession = abnormalSession, AnsweredBy = answeredBy, AnsweredByAnnotation = answeredByAnnotation, ConnectivityIssueAnnotation = connectivityIssueAnnotation, QualityIssueAnnotation = qualityIssueAnnotation, SpamAnnotation = spamAnnotation, CallScoreAnnotation = callScoreAnnotation, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Get a list of Call Summaries. </summary>
        /// <param name="from"> A calling party. Could be an E.164 number, a SIP URI, or a Twilio Client registered name. </param>
        /// <param name="to"> A called party. Could be an E.164 number, a SIP URI, or a Twilio Client registered name. </param>
        /// <param name="fromCarrier"> An origination carrier. </param>
        /// <param name="toCarrier"> A destination carrier. </param>
        /// <param name="fromCountryCode"> A source country code based on phone number in From. </param>
        /// <param name="toCountryCode"> A destination country code. Based on phone number in To. </param>
        /// <param name="branded"> A boolean flag indicating whether or not the calls were branded using Twilio Branded Calls. </param>
        /// <param name="verifiedCaller"> A boolean flag indicating whether or not the caller was verified using SHAKEN/STIR. </param>
        /// <param name="hasTag"> A boolean flag indicating the presence of one or more [Voice Insights Call Tags](https://www.twilio.com/docs/voice/voice-insights/api/call/details-call-tags). </param>
        /// <param name="startTime"> A Start time of the calls. xm (x minutes), xh (x hours), xd (x days), 1w, 30m, 3d, 4w or datetime-ISO. Defaults to 4h. </param>
        /// <param name="endTime"> An End Time of the calls. xm (x minutes), xh (x hours), xd (x days), 1w, 30m, 3d, 4w or datetime-ISO. Defaults to 0m. </param>
        /// <param name="callType"> A Call Type of the calls. One of `carrier`, `sip`, `trunking` or `client`. </param>
        /// <param name="callState"> A Call State of the calls. One of `ringing`, `completed`, `busy`, `fail`, `noanswer`, `canceled`, `answered`, `undialed`. </param>
        /// <param name="direction"> A Direction of the calls. One of `outbound_api`, `outbound_dial`, `inbound`, `trunking_originating`, `trunking_terminating`. </param>
        /// <param name="processingState"> A Processing State of the Call Summaries. One of `completed`, `partial` or `all`. </param>
        /// <param name="sortBy"> A Sort By criterion for the returned list of Call Summaries. One of `start_time` or `end_time`. </param>
        /// <param name="subaccount"> A unique SID identifier of a Subaccount. </param>
        /// <param name="abnormalSession"> A boolean flag indicating an abnormal session where the last SIP response was not 200 OK. </param>
        /// <param name="answeredBy"> An Answered By value for the calls based on `Answering Machine Detection (AMD)`. One of `unknown`, `machine_start`, `machine_end_beep`, `machine_end_silence`, `machine_end_other`, `human` or `fax`. </param>
        /// <param name="answeredByAnnotation"> Either machine or human. </param>
        /// <param name="connectivityIssueAnnotation"> A Connectivity Issue with the calls. One of `no_connectivity_issue`, `invalid_number`, `caller_id`, `dropped_call`, or `number_reachability`. </param>
        /// <param name="qualityIssueAnnotation"> A subjective Quality Issue with the calls. One of `no_quality_issue`, `low_volume`, `choppy_robotic`, `echo`, `dtmf`, `latency`, `owa`, `static_noise`. </param>
        /// <param name="spamAnnotation"> A boolean flag indicating spam calls. </param>
        /// <param name="callScoreAnnotation"> A Call Score of the calls. Use a range of 1-5 to indicate the call experience score, with the following mapping as a reference for the rated call [5: Excellent, 4: Good, 3 : Fair, 2 : Poor, 1: Bad]. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CallSummaries </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CallSummariesResource>> ReadAsync(
                                                                                             string from = null,
                                                                                             string to = null,
                                                                                             string fromCarrier = null,
                                                                                             string toCarrier = null,
                                                                                             string fromCountryCode = null,
                                                                                             string toCountryCode = null,
                                                                                             bool? branded = null,
                                                                                             bool? verifiedCaller = null,
                                                                                             bool? hasTag = null,
                                                                                             string startTime = null,
                                                                                             string endTime = null,
                                                                                             string callType = null,
                                                                                             string callState = null,
                                                                                             string direction = null,
                                                                                             CallSummariesResource.ProcessingStateRequestEnum processingState = null,
                                                                                             CallSummariesResource.SortByEnum sortBy = null,
                                                                                             string subaccount = null,
                                                                                             bool? abnormalSession = null,
                                                                                             CallSummariesResource.AnsweredByEnum answeredBy = null,
                                                                                             string answeredByAnnotation = null,
                                                                                             string connectivityIssueAnnotation = null,
                                                                                             string qualityIssueAnnotation = null,
                                                                                             bool? spamAnnotation = null,
                                                                                             string callScoreAnnotation = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadCallSummariesOptions(){ From = from, To = to, FromCarrier = fromCarrier, ToCarrier = toCarrier, FromCountryCode = fromCountryCode, ToCountryCode = toCountryCode, Branded = branded, VerifiedCaller = verifiedCaller, HasTag = hasTag, StartTime = startTime, EndTime = endTime, CallType = callType, CallState = callState, Direction = direction, ProcessingState = processingState, SortBy = sortBy, Subaccount = subaccount, AbnormalSession = abnormalSession, AnsweredBy = answeredBy, AnsweredByAnnotation = answeredByAnnotation, ConnectivityIssueAnnotation = connectivityIssueAnnotation, QualityIssueAnnotation = qualityIssueAnnotation, SpamAnnotation = spamAnnotation, CallScoreAnnotation = callScoreAnnotation, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CallSummariesResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CallSummariesResource>.FromJson("call_summaries", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CallSummariesResource> NextPage(Page<CallSummariesResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CallSummariesResource>.FromJson("call_summaries", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CallSummariesResource> PreviousPage(Page<CallSummariesResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CallSummariesResource>.FromJson("call_summaries", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a CallSummariesResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CallSummariesResource object represented by the provided JSON </returns>
        public static CallSummariesResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CallSummariesResource>(json);
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

    
        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique SID identifier of the Call. </summary> 
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }

        
        [JsonProperty("answered_by")]
        public CallSummariesResource.AnsweredByEnum AnsweredBy { get; private set; }

        
        [JsonProperty("call_type")]
        public CallSummariesResource.CallTypeEnum CallType { get; private set; }

        
        [JsonProperty("call_state")]
        public CallSummariesResource.CallStateEnum CallState { get; private set; }

        
        [JsonProperty("processing_state")]
        public CallSummariesResource.ProcessingStateEnum ProcessingState { get; private set; }

        ///<summary> The time at which the Call was created, given in ISO 8601 format. Can be different from `start_time` in the event of queueing due to CPS </summary> 
        [JsonProperty("created_time")]
        public DateTime? CreatedTime { get; private set; }

        ///<summary> The time at which the Call was started, given in ISO 8601 format. </summary> 
        [JsonProperty("start_time")]
        public DateTime? StartTime { get; private set; }

        ///<summary> The time at which the Call was ended, given in ISO 8601 format. </summary> 
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; private set; }

        ///<summary> Duration between when the call was initiated and the call was ended </summary> 
        [JsonProperty("duration")]
        public int? Duration { get; private set; }

        ///<summary> Duration between when the call was answered and when it ended </summary> 
        [JsonProperty("connect_duration")]
        public int? ConnectDuration { get; private set; }

        ///<summary> The calling party. </summary> 
        [JsonProperty("from")]
        public object From { get; private set; }

        ///<summary> The called party. </summary> 
        [JsonProperty("to")]
        public object To { get; private set; }

        ///<summary> Contains metrics and properties for the Twilio media gateway of a PSTN call. </summary> 
        [JsonProperty("carrier_edge")]
        public object CarrierEdge { get; private set; }

        ///<summary> Contains metrics and properties for the Twilio media gateway of a Client call. </summary> 
        [JsonProperty("client_edge")]
        public object ClientEdge { get; private set; }

        ///<summary> Contains metrics and properties for the SDK sensor library for Client calls. </summary> 
        [JsonProperty("sdk_edge")]
        public object SdkEdge { get; private set; }

        ///<summary> Contains metrics and properties for the Twilio media gateway of a SIP Interface or Trunking call. </summary> 
        [JsonProperty("sip_edge")]
        public object SipEdge { get; private set; }

        ///<summary> Tags applied to calls by Voice Insights analysis indicating a condition that could result in subjective degradation of the call quality. </summary> 
        [JsonProperty("tags")]
        public List<string> Tags { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Attributes capturing call-flow-specific details. </summary> 
        [JsonProperty("attributes")]
        public object Attributes { get; private set; }

        ///<summary> Contains edge-agnostic call-level details. </summary> 
        [JsonProperty("properties")]
        public object Properties { get; private set; }

        ///<summary> Contains trusted communications details including Branded Call and verified caller ID. </summary> 
        [JsonProperty("trust")]
        public object Trust { get; private set; }

        ///<summary> The annotation </summary> 
        [JsonProperty("annotation")]
        public object Annotation { get; private set; }



        private CallSummariesResource() {

        }
    }
}

