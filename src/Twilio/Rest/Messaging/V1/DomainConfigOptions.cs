/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Messaging.V1
{
    /// <summary> fetch </summary>
    public class FetchDomainConfigOptions : IOptions<DomainConfigResource>
    {
    
        ///<summary> Unique string used to identify the domain that this config should be associated with. </summary> 
        public string PathDomainSid { get; }



        /// <summary> Construct a new FetchDomainConfigOptions </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this config should be associated with. </param>
        public FetchDomainConfigOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> update </summary>
    public class UpdateDomainConfigOptions : IOptions<DomainConfigResource>
    {
    
        ///<summary> Unique string used to identify the domain that this config should be associated with. </summary> 
        public string PathDomainSid { get; }

        ///<summary> Any requests we receive to this domain that do not match an existing shortened message will be redirected to the fallback url. These will likely be either expired messages, random misdirected traffic, or intentional scraping. </summary> 
        public Uri FallbackUrl { get; set; }

        ///<summary> URL to receive click events to your webhook whenever the recipients click on the shortened links </summary> 
        public Uri CallbackUrl { get; set; }

        ///<summary> Boolean field to set customer delivery preference when there is a failure in linkShortening service </summary> 
        public bool? ContinueOnFailure { get; set; }

        ///<summary> Customer's choice to send links with/without \\\"https://\\\" attached to shortened url. If true, messages will not be sent with https:// at the beginning of the url. If false, messages will be sent with https:// at the beginning of the url. False is the default behavior if it is not specified. </summary> 
        public bool? DisableHttps { get; set; }



        /// <summary> Construct a new UpdateDomainConfigOptions </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this config should be associated with. </param>
        public UpdateDomainConfigOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackUrl", Serializers.Url(FallbackUrl)));
            }
            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }
            if (ContinueOnFailure != null)
            {
                p.Add(new KeyValuePair<string, string>("ContinueOnFailure", ContinueOnFailure.Value.ToString().ToLower()));
            }
            if (DisableHttps != null)
            {
                p.Add(new KeyValuePair<string, string>("DisableHttps", DisableHttps.Value.ToString().ToLower()));
            }
            return p;
        }

        

    }


}

