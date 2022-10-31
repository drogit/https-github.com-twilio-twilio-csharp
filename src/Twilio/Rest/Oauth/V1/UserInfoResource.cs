/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// UserInfoResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Oauth.V1
{

    public class UserInfoResource : Resource
    {
        private static Request BuildFetchRequest(FetchUserInfoOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Oauth,
                "/v1/userinfo",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Retrieves the consented UserInfo and other claims about the logged-in subject (end-user).
        /// </summary>
        /// <param name="options"> Fetch UserInfo parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserInfo </returns>
        public static UserInfoResource Fetch(FetchUserInfoOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieves the consented UserInfo and other claims about the logged-in subject (end-user).
        /// </summary>
        /// <param name="options"> Fetch UserInfo parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserInfo </returns>
        public static async System.Threading.Tasks.Task<UserInfoResource> FetchAsync(FetchUserInfoOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieves the consented UserInfo and other claims about the logged-in subject (end-user).
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserInfo </returns>
        public static UserInfoResource Fetch(ITwilioRestClient client = null)
        {
            var options = new FetchUserInfoOptions();
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieves the consented UserInfo and other claims about the logged-in subject (end-user).
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserInfo </returns>
        public static async System.Threading.Tasks.Task<UserInfoResource> FetchAsync(ITwilioRestClient client = null)
        {
            var options = new FetchUserInfoOptions();
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a UserInfoResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UserInfoResource object represented by the provided JSON </returns>
        public static UserInfoResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<UserInfoResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The user sid
        /// </summary>
        [JsonProperty("user_sid")]
        public string UserSid { get; private set; }
        /// <summary>
        /// The first name of the end-user
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; private set; }
        /// <summary>
        /// The last name of the end-user
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; private set; }
        /// <summary>
        /// The friendly name of the end-user
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The end-user's preferred email address
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private UserInfoResource()
        {

        }
    }

}