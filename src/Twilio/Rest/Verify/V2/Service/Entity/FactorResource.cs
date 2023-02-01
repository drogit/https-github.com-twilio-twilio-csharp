/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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


namespace Twilio.Rest.Verify.V2.Service.Entity
{
    public class FactorResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class FactorTypesEnum : StringEnum
        {
            private FactorTypesEnum(string value) : base(value) {}
            public FactorTypesEnum() {}
            public static implicit operator FactorTypesEnum(string value)
            {
                return new FactorTypesEnum(value);
            }
            public static readonly FactorTypesEnum Push = new FactorTypesEnum("push");
            public static readonly FactorTypesEnum Totp = new FactorTypesEnum("totp");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class FactorStatusesEnum : StringEnum
        {
            private FactorStatusesEnum(string value) : base(value) {}
            public FactorStatusesEnum() {}
            public static implicit operator FactorStatusesEnum(string value)
            {
                return new FactorStatusesEnum(value);
            }
            public static readonly FactorStatusesEnum Unverified = new FactorStatusesEnum("unverified");
            public static readonly FactorStatusesEnum Verified = new FactorStatusesEnum("verified");

        }
        public sealed class TotpAlgorithmsEnum : StringEnum
        {
            private TotpAlgorithmsEnum(string value) : base(value) {}
            public TotpAlgorithmsEnum() {}
            public static implicit operator TotpAlgorithmsEnum(string value)
            {
                return new TotpAlgorithmsEnum(value);
            }
            public static readonly TotpAlgorithmsEnum Sha1 = new TotpAlgorithmsEnum("sha1");
            public static readonly TotpAlgorithmsEnum Sha256 = new TotpAlgorithmsEnum("sha256");
            public static readonly TotpAlgorithmsEnum Sha512 = new TotpAlgorithmsEnum("sha512");

        }

        
        /// <summary> Delete a specific Factor. </summary>
        /// <param name="options"> Delete Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns>
        private static Request BuildDeleteRequest(DeleteFactorOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Entities/{Identity}/Factors/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{"+"Identity"+"}", PathIdentity);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Factor. </summary>
        /// <param name="options"> Delete Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns>
        public static bool Delete(DeleteFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Factor. </summary>
        /// <param name="options"> Delete Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFactorOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Factor. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Factor. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns>
        public static bool Delete(string pathServiceSid, string pathIdentity, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFactorOptions(pathServiceSid, pathIdentity, pathSid)           ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Factor. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Factor. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathIdentity, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFactorOptions(pathServiceSid, pathIdentity, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchFactorOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Entities/{Identity}/Factors/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{"+"Identity"+"}", PathIdentity);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Factor. </summary>
        /// <param name="options"> Fetch Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns>
        public static FactorResource Fetch(FetchFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Factor. </summary>
        /// <param name="options"> Fetch Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns>
        public static async System.Threading.Tasks.Task<FactorResource> FetchAsync(FetchFactorOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Factor. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Factor. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns>
        public static FactorResource Fetch(
                                         string pathServiceSid, 
                                         string pathIdentity, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchFactorOptions(pathServiceSid, pathIdentity, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Factor. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Factor. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns>
        public static async System.Threading.Tasks.Task<FactorResource> FetchAsync(string pathServiceSid, string pathIdentity, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchFactorOptions(pathServiceSid, pathIdentity, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadFactorOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Entities/{Identity}/Factors";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{"+"Identity"+"}", PathIdentity);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Factors for an Entity. </summary>
        /// <param name="options"> Read Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns>
        public static ResourceSet<FactorResource> Read(ReadFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<FactorResource>.FromJson("factors", response.Content);
            return new ResourceSet<FactorResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Factors for an Entity. </summary>
        /// <param name="options"> Read Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FactorResource>> ReadAsync(ReadFactorOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FactorResource>.FromJson("factors", response.Content);
            return new ResourceSet<FactorResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Factors for an Entity. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factors. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of Factor </returns>
        public static ResourceSet<FactorResource> Read(
                                                     string pathServiceSid,
                                                     string pathIdentity,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadFactorOptions(pathServiceSid, pathIdentity){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Factors for an Entity. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factors. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of Factor </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FactorResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathIdentity,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadFactorOptions(pathServiceSid, pathIdentity){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FactorResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FactorResource>.FromJson("factors", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FactorResource> NextPage(Page<FactorResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FactorResource>.FromJson("factors", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FactorResource> PreviousPage(Page<FactorResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FactorResource>.FromJson("factors", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateFactorOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Entities/{Identity}/Factors/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{"+"Identity"+"}", PathIdentity);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a specific Factor. This endpoint can be used to Verify a Factor if passed an `AuthPayload` param. </summary>
        /// <param name="options"> Update Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns>
        public static FactorResource Update(UpdateFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a specific Factor. This endpoint can be used to Verify a Factor if passed an `AuthPayload` param. </summary>
        /// <param name="options"> Update Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<FactorResource> UpdateAsync(UpdateFactorOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a specific Factor. This endpoint can be used to Verify a Factor if passed an `AuthPayload` param. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Factor. </param>
        /// <param name="authPayload"> The optional payload needed to verify the Factor for the first time. E.g. for a TOTP, the numeric code. </param>
        /// <param name="friendlyName"> The new friendly name of this Factor. It can be up to 64 characters. </param>
        /// <param name="configNotificationToken"> For APN, the device token. For FCM, the registration token. It is used to send the push notifications. Required when `factor_type` is `push`. If specified, this value must be between 32 and 255 characters long. </param>
        /// <param name="configSdkVersion"> The Verify Push SDK version used to configure the factor </param>
        /// <param name="configTimeStep"> Defines how often, in seconds, are TOTP codes generated. i.e, a new TOTP code is generated every time_step seconds. Must be between 20 and 60 seconds, inclusive </param>
        /// <param name="configSkew"> The number of time-steps, past and future, that are valid for validation of TOTP codes. Must be between 0 and 2, inclusive </param>
        /// <param name="configCodeLength"> Number of digits for generated TOTP codes. Must be between 3 and 8, inclusive </param>
        /// <param name="configAlg">  </param>
        /// <param name="configNotificationPlatform"> The transport technology used to generate the Notification Token. Can be `apn`, `fcm` or `none`.  Required when `factor_type` is `push`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns>
        public static FactorResource Update(
                                          string pathServiceSid,
                                          string pathIdentity,
                                          string pathSid,
                                          string authPayload = null,
                                          string friendlyName = null,
                                          string configNotificationToken = null,
                                          string configSdkVersion = null,
                                          int? configTimeStep = null,
                                          int? configSkew = null,
                                          int? configCodeLength = null,
                                          FactorResource.TotpAlgorithmsEnum configAlg = null,
                                          string configNotificationPlatform = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateFactorOptions(pathServiceSid, pathIdentity, pathSid){ AuthPayload = authPayload, FriendlyName = friendlyName, ConfigNotificationToken = configNotificationToken, ConfigSdkVersion = configSdkVersion, ConfigTimeStep = configTimeStep, ConfigSkew = configSkew, ConfigCodeLength = configCodeLength, ConfigAlg = configAlg, ConfigNotificationPlatform = configNotificationPlatform };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a specific Factor. This endpoint can be used to Verify a Factor if passed an `AuthPayload` param. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Factor. </param>
        /// <param name="authPayload"> The optional payload needed to verify the Factor for the first time. E.g. for a TOTP, the numeric code. </param>
        /// <param name="friendlyName"> The new friendly name of this Factor. It can be up to 64 characters. </param>
        /// <param name="configNotificationToken"> For APN, the device token. For FCM, the registration token. It is used to send the push notifications. Required when `factor_type` is `push`. If specified, this value must be between 32 and 255 characters long. </param>
        /// <param name="configSdkVersion"> The Verify Push SDK version used to configure the factor </param>
        /// <param name="configTimeStep"> Defines how often, in seconds, are TOTP codes generated. i.e, a new TOTP code is generated every time_step seconds. Must be between 20 and 60 seconds, inclusive </param>
        /// <param name="configSkew"> The number of time-steps, past and future, that are valid for validation of TOTP codes. Must be between 0 and 2, inclusive </param>
        /// <param name="configCodeLength"> Number of digits for generated TOTP codes. Must be between 3 and 8, inclusive </param>
        /// <param name="configAlg">  </param>
        /// <param name="configNotificationPlatform"> The transport technology used to generate the Notification Token. Can be `apn`, `fcm` or `none`.  Required when `factor_type` is `push`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns>
        public static async System.Threading.Tasks.Task<FactorResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathIdentity,
                                                                              string pathSid,
                                                                              string authPayload = null,
                                                                              string friendlyName = null,
                                                                              string configNotificationToken = null,
                                                                              string configSdkVersion = null,
                                                                              int? configTimeStep = null,
                                                                              int? configSkew = null,
                                                                              int? configCodeLength = null,
                                                                              FactorResource.TotpAlgorithmsEnum configAlg = null,
                                                                              string configNotificationPlatform = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateFactorOptions(pathServiceSid, pathIdentity, pathSid){ AuthPayload = authPayload, FriendlyName = friendlyName, ConfigNotificationToken = configNotificationToken, ConfigSdkVersion = configSdkVersion, ConfigTimeStep = configTimeStep, ConfigSkew = configSkew, ConfigCodeLength = configCodeLength, ConfigAlg = configAlg, ConfigNotificationPlatform = configNotificationPlatform };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a FactorResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FactorResource object represented by the provided JSON </returns>
        public static FactorResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<FactorResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> A 34 character string that uniquely identifies this Factor. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique SID identifier of the Service. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The unique SID identifier of the Entity. </summary> 
        [JsonProperty("entity_sid")]
        public string EntitySid { get; private set; }

        ///<summary> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> The date that this Factor was created, given in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this Factor was updated, given in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> A human readable description of this resource, up to 64 characters. For a push factor, this can be the device's name. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        
        [JsonProperty("status")]
        public FactorResource.FactorStatusesEnum Status { get; private set; }

        
        [JsonProperty("factor_type")]
        public FactorResource.FactorTypesEnum FactorType { get; private set; }

        ///<summary> An object that contains configurations specific to a `factor_type`. </summary> 
        [JsonProperty("config")]
        public object Config { get; private set; }

        ///<summary> Custom metadata associated with the factor. This is added by the Device/SDK directly to allow for the inclusion of device information. It must be a stringified JSON with only strings values eg. `{\"os\": \"Android\"}`. Can be up to 1024 characters in length. </summary> 
        [JsonProperty("metadata")]
        public object Metadata { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private FactorResource() {

        }
    }
}

