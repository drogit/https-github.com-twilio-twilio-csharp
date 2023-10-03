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


namespace Twilio.Rest.Numbers.V1
{
    public class PortingPortabilityResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class NumberTypeEnum : StringEnum
        {
            private NumberTypeEnum(string value) : base(value) {}
            public NumberTypeEnum() {}
            public static implicit operator NumberTypeEnum(string value)
            {
                return new NumberTypeEnum(value);
            }
            public static readonly NumberTypeEnum Local = new NumberTypeEnum("LOCAL");
            public static readonly NumberTypeEnum Unknown = new NumberTypeEnum("UNKNOWN");
            public static readonly NumberTypeEnum Mobile = new NumberTypeEnum("MOBILE");
            public static readonly NumberTypeEnum TollFree = new NumberTypeEnum("TOLL-FREE");

        }

        
        private static Request BuildFetchRequest(FetchPortingPortabilityOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Porting/Portability/PhoneNumber/{PhoneNumber}";

            string PathPhoneNumber = options.PathPhoneNumber.ToString();
            path = path.Replace("{"+"PhoneNumber"+"}", PathPhoneNumber);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Allows to check if a single phone number can be ported to Twilio or not. </summary>
        /// <param name="options"> Fetch PortingPortability parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PortingPortability </returns>
        public static PortingPortabilityResource Fetch(FetchPortingPortabilityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Allows to check if a single phone number can be ported to Twilio or not. </summary>
        /// <param name="options"> Fetch PortingPortability parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PortingPortability </returns>
        public static async System.Threading.Tasks.Task<PortingPortabilityResource> FetchAsync(FetchPortingPortabilityOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Allows to check if a single phone number can be ported to Twilio or not. </summary>
        /// <param name="pathPhoneNumber"> The phone number which portability is to be checked. Phone numbers are in E.164 format (e.g. +16175551212). </param>
        /// <param name="targetAccountSid"> The SID of the account where the phone number(s) will be ported. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PortingPortability </returns>
        public static PortingPortabilityResource Fetch(
                                         Types.PhoneNumber pathPhoneNumber, 
                                         string targetAccountSid = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchPortingPortabilityOptions(pathPhoneNumber){ TargetAccountSid = targetAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Allows to check if a single phone number can be ported to Twilio or not. </summary>
        /// <param name="pathPhoneNumber"> The phone number which portability is to be checked. Phone numbers are in E.164 format (e.g. +16175551212). </param>
        /// <param name="targetAccountSid"> The SID of the account where the phone number(s) will be ported. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PortingPortability </returns>
        public static async System.Threading.Tasks.Task<PortingPortabilityResource> FetchAsync(Types.PhoneNumber pathPhoneNumber, string targetAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchPortingPortabilityOptions(pathPhoneNumber){ TargetAccountSid = targetAccountSid };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a PortingPortabilityResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PortingPortabilityResource object represented by the provided JSON </returns>
        public static PortingPortabilityResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PortingPortabilityResource>(json);
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

    
        ///<summary> The phone number which portability is to be checked. Phone numbers are in E.164 format (e.g. +16175551212). </summary> 
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }

        ///<summary> The target account sid to which the number will be ported </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> Boolean flag specifying if phone number is portable or not. </summary> 
        [JsonProperty("portable")]
        public bool? Portable { get; private set; }

        ///<summary> Boolean flag specifying if PIN and account number is required for the phone number. </summary> 
        [JsonProperty("pin_and_account_number_required")]
        public bool? PinAndAccountNumberRequired { get; private set; }

        ///<summary> Reason why the phone number cannot be ported into Twilio, `null` otherwise. </summary> 
        [JsonProperty("not_portable_reason")]
        public string NotPortableReason { get; private set; }

        ///<summary> The Portability Reason Code for the phone number if it cannot be ported into Twilio, `null` otherwise. One of `22131`, `22132`, `22130`, `22133`, `22102` or `22135`. </summary> 
        [JsonProperty("not_portable_reason_code")]
        public int? NotPortableReasonCode { get; private set; }

        
        [JsonProperty("number_type")]
        public PortingPortabilityResource.NumberTypeEnum NumberType { get; private set; }

        ///<summary> Country the phone number belongs to. </summary> 
        [JsonProperty("country")]
        public string Country { get; private set; }

        ///<summary> Current messaging carrier of the phone number </summary> 
        [JsonProperty("messaging_carrier")]
        public string MessagingCarrier { get; private set; }

        ///<summary> Current voice carrier of the phone number </summary> 
        [JsonProperty("voice_carrier")]
        public string VoiceCarrier { get; private set; }

        ///<summary> This is the url of the request that you're trying to reach out to locate the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private PortingPortabilityResource() {

        }
    }
}

