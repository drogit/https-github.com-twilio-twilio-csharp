/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Microvisor
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



namespace Twilio.Rest.Microvisor.V1
{
    public class AccountConfigResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateAccountConfigOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Configs";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Microvisor,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a config for an Account. </summary>
        /// <param name="options"> Create AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static AccountConfigResource Create(CreateAccountConfigOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a config for an Account. </summary>
        /// <param name="options"> Create AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        public static async System.Threading.Tasks.Task<AccountConfigResource> CreateAsync(CreateAccountConfigOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a config for an Account. </summary>
        /// <param name="key"> The config key; up to 100 characters. </param>
        /// <param name="value"> The config value; up to 4096 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static AccountConfigResource Create(
                                          string key,
                                          string value,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateAccountConfigOptions(key, value){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a config for an Account. </summary>
        /// <param name="key"> The config key; up to 100 characters. </param>
        /// <param name="value"> The config value; up to 4096 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        public static async System.Threading.Tasks.Task<AccountConfigResource> CreateAsync(
                                                                                  string key,
                                                                                  string value,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateAccountConfigOptions(key, value){  };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a config for an Account. </summary>
        /// <param name="options"> Delete AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        private static Request BuildDeleteRequest(DeleteAccountConfigOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Configs/{Key}";

            string PathKey = options.PathKey;
            path = path.Replace("{"+"Key"+"}", PathKey);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a config for an Account. </summary>
        /// <param name="options"> Delete AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static bool Delete(DeleteAccountConfigOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a config for an Account. </summary>
        /// <param name="options"> Delete AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAccountConfigOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a config for an Account. </summary>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static bool Delete(string pathKey, ITwilioRestClient client = null)
        {
            var options = new DeleteAccountConfigOptions(pathKey)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a config for an Account. </summary>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathKey, ITwilioRestClient client = null)
        {
            var options = new DeleteAccountConfigOptions(pathKey) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchAccountConfigOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Configs/{Key}";

            string PathKey = options.PathKey;
            path = path.Replace("{"+"Key"+"}", PathKey);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a Config for an Account. </summary>
        /// <param name="options"> Fetch AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static AccountConfigResource Fetch(FetchAccountConfigOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve a Config for an Account. </summary>
        /// <param name="options"> Fetch AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        public static async System.Threading.Tasks.Task<AccountConfigResource> FetchAsync(FetchAccountConfigOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve a Config for an Account. </summary>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static AccountConfigResource Fetch(
                                         string pathKey, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchAccountConfigOptions(pathKey){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a Config for an Account. </summary>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        public static async System.Threading.Tasks.Task<AccountConfigResource> FetchAsync(string pathKey, ITwilioRestClient client = null)
        {
            var options = new FetchAccountConfigOptions(pathKey){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadAccountConfigOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Configs";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Configs for an Account. </summary>
        /// <param name="options"> Read AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static ResourceSet<AccountConfigResource> Read(ReadAccountConfigOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AccountConfigResource>.FromJson("configs", response.Content);
            return new ResourceSet<AccountConfigResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Configs for an Account. </summary>
        /// <param name="options"> Read AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AccountConfigResource>> ReadAsync(ReadAccountConfigOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AccountConfigResource>.FromJson("configs", response.Content);
            return new ResourceSet<AccountConfigResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Configs for an Account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static ResourceSet<AccountConfigResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadAccountConfigOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Configs for an Account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AccountConfigResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadAccountConfigOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AccountConfigResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AccountConfigResource>.FromJson("configs", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AccountConfigResource> NextPage(Page<AccountConfigResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AccountConfigResource>.FromJson("configs", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AccountConfigResource> PreviousPage(Page<AccountConfigResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AccountConfigResource>.FromJson("configs", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateAccountConfigOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Configs/{Key}";

            string PathKey = options.PathKey;
            path = path.Replace("{"+"Key"+"}", PathKey);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Microvisor,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a config for an Account. </summary>
        /// <param name="options"> Update AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static AccountConfigResource Update(UpdateAccountConfigOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a config for an Account. </summary>
        /// <param name="options"> Update AccountConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<AccountConfigResource> UpdateAsync(UpdateAccountConfigOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a config for an Account. </summary>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="value"> The config value; up to 4096 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AccountConfig </returns>
        public static AccountConfigResource Update(
                                          string pathKey,
                                          string value,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateAccountConfigOptions(pathKey, value){  };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a config for an Account. </summary>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="value"> The config value; up to 4096 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AccountConfig </returns>
        public static async System.Threading.Tasks.Task<AccountConfigResource> UpdateAsync(
                                                                              string pathKey,
                                                                              string value,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateAccountConfigOptions(pathKey, value){  };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a AccountConfigResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AccountConfigResource object represented by the provided JSON </returns>
        public static AccountConfigResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AccountConfigResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The config key; up to 100 characters. </summary> 
        [JsonProperty("key")]
        public string Key { get; private set; }

        ///<summary> The date_updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The config value; up to 4096 characters. </summary> 
        [JsonProperty("value")]
        public string Value { get; private set; }

        ///<summary> The absolute URL of the Config. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private AccountConfigResource() {

        }
    }
}

