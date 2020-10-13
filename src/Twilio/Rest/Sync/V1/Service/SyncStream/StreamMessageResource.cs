/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// StreamMessageResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Sync.V1.Service.SyncStream
{

    public class StreamMessageResource : Resource
    {
        private static Request BuildCreateRequest(CreateStreamMessageOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Streams/" + options.PathStreamSid + "/Messages",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new Stream Message.
        /// </summary>
        /// <param name="options"> Create StreamMessage parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StreamMessage </returns>
        public static StreamMessageResource Create(CreateStreamMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Stream Message.
        /// </summary>
        /// <param name="options"> Create StreamMessage parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StreamMessage </returns>
        public static async System.Threading.Tasks.Task<StreamMessageResource> CreateAsync(CreateStreamMessageOptions options,
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Stream Message.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service to create the new Stream Message in </param>
        /// <param name="pathStreamSid"> The SID of the Sync Stream to create the new Stream Message resource for </param>
        /// <param name="data"> A JSON string that represents an arbitrary, schema-less object that makes up the Stream Message
        ///            body </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StreamMessage </returns>
        public static StreamMessageResource Create(string pathServiceSid,
                                                   string pathStreamSid,
                                                   object data,
                                                   ITwilioRestClient client = null)
        {
            var options = new CreateStreamMessageOptions(pathServiceSid, pathStreamSid, data);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Stream Message.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service to create the new Stream Message in </param>
        /// <param name="pathStreamSid"> The SID of the Sync Stream to create the new Stream Message resource for </param>
        /// <param name="data"> A JSON string that represents an arbitrary, schema-less object that makes up the Stream Message
        ///            body </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StreamMessage </returns>
        public static async System.Threading.Tasks.Task<StreamMessageResource> CreateAsync(string pathServiceSid,
                                                                                           string pathStreamSid,
                                                                                           object data,
                                                                                           ITwilioRestClient client = null)
        {
            var options = new CreateStreamMessageOptions(pathServiceSid, pathStreamSid, data);
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a StreamMessageResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> StreamMessageResource object represented by the provided JSON </returns>
        public static StreamMessageResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<StreamMessageResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Stream Message body
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; private set; }

        private StreamMessageResource()
        {

        }
    }

}