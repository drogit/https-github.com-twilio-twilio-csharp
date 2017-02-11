using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Call 
{

    public class FeedbackResource : Resource 
    {
        public sealed class IssuesEnum : StringEnum 
        {
            private IssuesEnum(string value) : base(value) {}
            public IssuesEnum() {}
        
            public static readonly IssuesEnum AudioLatency = new IssuesEnum("audio-latency");
            public static readonly IssuesEnum DigitsNotCaptured = new IssuesEnum("digits-not-captured");
            public static readonly IssuesEnum DroppedCall = new IssuesEnum("dropped-call");
            public static readonly IssuesEnum ImperfectAudio = new IssuesEnum("imperfect-audio");
            public static readonly IssuesEnum IncorrectCallerId = new IssuesEnum("incorrect-caller-id");
            public static readonly IssuesEnum OneWayAudio = new IssuesEnum("one-way-audio");
            public static readonly IssuesEnum PostDialDelay = new IssuesEnum("post-dial-delay");
            public static readonly IssuesEnum UnsolicitedCall = new IssuesEnum("unsolicited-call");
        }
    
        private static Request BuildCreateRequest(CreateFeedbackOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Calls/" + options.CallSid + "/Feedback.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Feedback parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Feedback </returns> 
        public static FeedbackResource Create(CreateFeedbackOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Create Feedback parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Feedback </returns> 
        public static async System.Threading.Tasks.Task<FeedbackResource> CreateAsync(CreateFeedbackOptions options, ITwilioRestClient client = null)
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
        /// <param name="callSid"> The call_sid </param>
        /// <param name="qualityScore"> The quality_score </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="issue"> The issue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Feedback </returns> 
        public static FeedbackResource Create(string callSid, int? qualityScore, string accountSid = null, List<FeedbackResource.IssuesEnum> issue = null, ITwilioRestClient client = null)
        {
            var options = new CreateFeedbackOptions(callSid, qualityScore){AccountSid = accountSid, Issue = issue};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="qualityScore"> The quality_score </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="issue"> The issue </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Feedback </returns> 
        public static async System.Threading.Tasks.Task<FeedbackResource> CreateAsync(string callSid, int? qualityScore, string accountSid = null, List<FeedbackResource.IssuesEnum> issue = null, ITwilioRestClient client = null)
        {
            var options = new CreateFeedbackOptions(callSid, qualityScore){AccountSid = accountSid, Issue = issue};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildFetchRequest(FetchFeedbackOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Calls/" + options.CallSid + "/Feedback.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of a feedback entry for a call
        /// </summary>
        ///
        /// <param name="options"> Fetch Feedback parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Feedback </returns> 
        public static FeedbackResource Fetch(FetchFeedbackOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a feedback entry for a call
        /// </summary>
        ///
        /// <param name="options"> Fetch Feedback parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Feedback </returns> 
        public static async System.Threading.Tasks.Task<FeedbackResource> FetchAsync(FetchFeedbackOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of a feedback entry for a call
        /// </summary>
        ///
        /// <param name="callSid"> The call sid that uniquely identifies the call </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Feedback </returns> 
        public static FeedbackResource Fetch(string callSid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchFeedbackOptions(callSid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a feedback entry for a call
        /// </summary>
        ///
        /// <param name="callSid"> The call sid that uniquely identifies the call </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Feedback </returns> 
        public static async System.Threading.Tasks.Task<FeedbackResource> FetchAsync(string callSid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchFeedbackOptions(callSid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateFeedbackOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Calls/" + options.CallSid + "/Feedback.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Create or update a feedback entry for a call
        /// </summary>
        ///
        /// <param name="options"> Update Feedback parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Feedback </returns> 
        public static FeedbackResource Update(UpdateFeedbackOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Create or update a feedback entry for a call
        /// </summary>
        ///
        /// <param name="options"> Update Feedback parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Feedback </returns> 
        public static async System.Threading.Tasks.Task<FeedbackResource> UpdateAsync(UpdateFeedbackOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Create or update a feedback entry for a call
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="qualityScore"> An integer from 1 to 5 </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="issue"> Issues experienced during the call </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Feedback </returns> 
        public static FeedbackResource Update(string callSid, int? qualityScore, string accountSid = null, List<FeedbackResource.IssuesEnum> issue = null, ITwilioRestClient client = null)
        {
            var options = new UpdateFeedbackOptions(callSid, qualityScore){AccountSid = accountSid, Issue = issue};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Create or update a feedback entry for a call
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="qualityScore"> An integer from 1 to 5 </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="issue"> Issues experienced during the call </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Feedback </returns> 
        public static async System.Threading.Tasks.Task<FeedbackResource> UpdateAsync(string callSid, int? qualityScore, string accountSid = null, List<FeedbackResource.IssuesEnum> issue = null, ITwilioRestClient client = null)
        {
            var options = new UpdateFeedbackOptions(callSid, qualityScore){AccountSid = accountSid, Issue = issue};
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a FeedbackResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FeedbackResource object represented by the provided JSON </returns> 
        public static FeedbackResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FeedbackResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
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
        /// The issues
        /// </summary>
        [JsonProperty("issues")]
        [JsonConverter(typeof(StringEnumConverter))]
        public List<FeedbackResource.IssuesEnum> Issues { get; private set; }
        /// <summary>
        /// 1 to 5 quality score
        /// </summary>
        [JsonProperty("quality_score")]
        public int? QualityScore { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
    
        private FeedbackResource()
        {
        
        }
    }

}