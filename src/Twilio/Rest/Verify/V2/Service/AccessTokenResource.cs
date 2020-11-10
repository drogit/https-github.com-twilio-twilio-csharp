/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// AccessTokenResource
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

namespace Twilio.Rest.Verify.V2.Service
{

    public class AccessTokenResource : Resource
    {
        public sealed class FactorTypesEnum : StringEnum
        {
            private FactorTypesEnum(string value) : base(value) {}
            public FactorTypesEnum() {}
            public static implicit operator FactorTypesEnum(string value)
            {
                return new FactorTypesEnum(value);
            }

            public static readonly FactorTypesEnum Push = new FactorTypesEnum("push");
        }

        private static Request BuildCreateRequest(CreateAccessTokenOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/AccessTokens",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new enrollment Access Token for the Entity
        /// </summary>
        /// <param name="options"> Create AccessToken parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccessToken </returns>
        public static AccessTokenResource Create(CreateAccessTokenOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new enrollment Access Token for the Entity
        /// </summary>
        /// <param name="options"> Create AccessToken parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccessToken </returns>
        public static async System.Threading.Tasks.Task<AccessTokenResource> CreateAsync(CreateAccessTokenOptions options,
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new enrollment Access Token for the Entity
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="identity"> Unique external identifier of the Entity </param>
        /// <param name="factorType"> The Type of this Factor </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccessToken </returns>
        public static AccessTokenResource Create(string pathServiceSid,
                                                 string identity,
                                                 AccessTokenResource.FactorTypesEnum factorType,
                                                 ITwilioRestClient client = null)
        {
            var options = new CreateAccessTokenOptions(pathServiceSid, identity, factorType);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new enrollment Access Token for the Entity
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="identity"> Unique external identifier of the Entity </param>
        /// <param name="factorType"> The Type of this Factor </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccessToken </returns>
        public static async System.Threading.Tasks.Task<AccessTokenResource> CreateAsync(string pathServiceSid,
                                                                                         string identity,
                                                                                         AccessTokenResource.FactorTypesEnum factorType,
                                                                                         ITwilioRestClient client = null)
        {
            var options = new CreateAccessTokenOptions(pathServiceSid, identity, factorType);
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a AccessTokenResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AccessTokenResource object represented by the provided JSON </returns>
        public static AccessTokenResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AccessTokenResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Generated access token.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; private set; }

        private AccessTokenResource()
        {

        }
    }

}