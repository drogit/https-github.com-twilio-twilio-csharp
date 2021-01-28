/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// ParticipantResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Insights.V1.Room
{

    public class ParticipantResource : Resource
    {
        public sealed class RoomStatusEnum : StringEnum
        {
            private RoomStatusEnum(string value) : base(value) {}
            public RoomStatusEnum() {}
            public static implicit operator RoomStatusEnum(string value)
            {
                return new RoomStatusEnum(value);
            }

            public static readonly RoomStatusEnum InProgress = new RoomStatusEnum("in_progress");
            public static readonly RoomStatusEnum Completed = new RoomStatusEnum("completed");
        }

        public sealed class CodecEnum : StringEnum
        {
            private CodecEnum(string value) : base(value) {}
            public CodecEnum() {}
            public static implicit operator CodecEnum(string value)
            {
                return new CodecEnum(value);
            }

            public static readonly CodecEnum Vp8 = new CodecEnum("VP8");
            public static readonly CodecEnum H264 = new CodecEnum("H264");
            public static readonly CodecEnum Vp9 = new CodecEnum("VP9");
        }

        public sealed class TwilioRealmEnum : StringEnum
        {
            private TwilioRealmEnum(string value) : base(value) {}
            public TwilioRealmEnum() {}
            public static implicit operator TwilioRealmEnum(string value)
            {
                return new TwilioRealmEnum(value);
            }

            public static readonly TwilioRealmEnum Us1 = new TwilioRealmEnum("us1");
            public static readonly TwilioRealmEnum Us2 = new TwilioRealmEnum("us2");
            public static readonly TwilioRealmEnum Au1 = new TwilioRealmEnum("au1");
            public static readonly TwilioRealmEnum Br1 = new TwilioRealmEnum("br1");
            public static readonly TwilioRealmEnum Ie1 = new TwilioRealmEnum("ie1");
            public static readonly TwilioRealmEnum Jp1 = new TwilioRealmEnum("jp1");
            public static readonly TwilioRealmEnum Sg1 = new TwilioRealmEnum("sg1");
            public static readonly TwilioRealmEnum In1 = new TwilioRealmEnum("in1");
            public static readonly TwilioRealmEnum De1 = new TwilioRealmEnum("de1");
            public static readonly TwilioRealmEnum Gll = new TwilioRealmEnum("gll");
        }

        public sealed class EdgeLocationEnum : StringEnum
        {
            private EdgeLocationEnum(string value) : base(value) {}
            public EdgeLocationEnum() {}
            public static implicit operator EdgeLocationEnum(string value)
            {
                return new EdgeLocationEnum(value);
            }

            public static readonly EdgeLocationEnum Ashburn = new EdgeLocationEnum("ashburn");
            public static readonly EdgeLocationEnum Dublin = new EdgeLocationEnum("dublin");
            public static readonly EdgeLocationEnum Frankfurt = new EdgeLocationEnum("frankfurt");
            public static readonly EdgeLocationEnum Singapore = new EdgeLocationEnum("singapore");
            public static readonly EdgeLocationEnum Sydney = new EdgeLocationEnum("sydney");
            public static readonly EdgeLocationEnum SaoPaulo = new EdgeLocationEnum("sao_paulo");
            public static readonly EdgeLocationEnum Roaming = new EdgeLocationEnum("roaming");
            public static readonly EdgeLocationEnum Umatilla = new EdgeLocationEnum("umatilla");
            public static readonly EdgeLocationEnum Tokyo = new EdgeLocationEnum("tokyo");
        }

        private static Request BuildFetchRequest(FetchParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                "/v1/Video/Rooms/" + options.PathRoomSid + "/Participants/" + options.PathParticipantSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns>
        public static ParticipantResource Fetch(FetchParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns>
        public static async System.Threading.Tasks.Task<ParticipantResource> FetchAsync(FetchParticipantOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns>
        public static ParticipantResource Fetch(string pathRoomSid,
                                                string pathParticipantSid,
                                                ITwilioRestClient client = null)
        {
            var options = new FetchParticipantOptions(pathRoomSid, pathParticipantSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns>
        public static async System.Threading.Tasks.Task<ParticipantResource> FetchAsync(string pathRoomSid,
                                                                                        string pathParticipantSid,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchParticipantOptions(pathRoomSid, pathParticipantSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                "/v1/Video/Rooms/" + options.PathRoomSid + "/Participants",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns>
        public static ResourceSet<ParticipantResource> Read(ReadParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ParticipantResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ParticipantResource>> ReadAsync(ReadParticipantOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ParticipantResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns>
        public static ResourceSet<ParticipantResource> Read(string pathRoomSid,
                                                            int? pageSize = null,
                                                            long? limit = null,
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadParticipantOptions(pathRoomSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ParticipantResource>> ReadAsync(string pathRoomSid,
                                                                                                    int? pageSize = null,
                                                                                                    long? limit = null,
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadParticipantOptions(pathRoomSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ParticipantResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ParticipantResource> NextPage(Page<ParticipantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Insights)
            );

            var response = client.Request(request);
            return Page<ParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ParticipantResource> PreviousPage(Page<ParticipantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Insights)
            );

            var response = client.Request(request);
            return Page<ParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a ParticipantResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ParticipantResource object represented by the provided JSON </returns>
        public static ParticipantResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ParticipantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The participant_sid
        /// </summary>
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }
        /// <summary>
        /// The participant_identity
        /// </summary>
        [JsonProperty("participant_identity")]
        public string ParticipantIdentity { get; private set; }
        /// <summary>
        /// The join_time
        /// </summary>
        [JsonProperty("join_time")]
        public DateTime? JoinTime { get; private set; }
        /// <summary>
        /// The leave_time
        /// </summary>
        [JsonProperty("leave_time")]
        public DateTime? LeaveTime { get; private set; }
        /// <summary>
        /// The duration_sec
        /// </summary>
        [JsonProperty("duration_sec")]
        public long? DurationSec { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The room_sid
        /// </summary>
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ParticipantResource.RoomStatusEnum Status { get; private set; }
        /// <summary>
        /// The codecs
        /// </summary>
        [JsonProperty("codecs")]
        [JsonConverter(typeof(StringEnumConverter))]
        public List<ParticipantResource.CodecEnum> Codecs { get; private set; }
        /// <summary>
        /// The end_reason
        /// </summary>
        [JsonProperty("end_reason")]
        public string EndReason { get; private set; }
        /// <summary>
        /// The error_code
        /// </summary>
        [JsonProperty("error_code")]
        public int? ErrorCode { get; private set; }
        /// <summary>
        /// The error_code_url
        /// </summary>
        [JsonProperty("error_code_url")]
        public string ErrorCodeUrl { get; private set; }
        /// <summary>
        /// The media_region
        /// </summary>
        [JsonProperty("media_region")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ParticipantResource.TwilioRealmEnum MediaRegion { get; private set; }
        /// <summary>
        /// The properties
        /// </summary>
        [JsonProperty("properties")]
        public object Properties { get; private set; }
        /// <summary>
        /// The edge_location
        /// </summary>
        [JsonProperty("edge_location")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ParticipantResource.EdgeLocationEnum EdgeLocation { get; private set; }
        /// <summary>
        /// The publisher_info
        /// </summary>
        [JsonProperty("publisher_info")]
        public object PublisherInfo { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private ParticipantResource()
        {

        }
    }

}