/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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




namespace Twilio.Rest.Api.V2010.Account
{
    /// <summary> fetch </summary>
    public class FetchAvailablePhoneNumberCountryOptions : IOptions<AvailablePhoneNumberCountryResource>
    {
    
        ///<summary> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country to fetch available phone number information about. </summary> 
        public string PathCountryCode { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) requesting the available phone number Country resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchAvailablePhoneNumberCountryOptions </summary>
        /// <param name="pathCountryCode"> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country to fetch available phone number information about. </param>
        public FetchAvailablePhoneNumberCountryOptions(string pathCountryCode)
        {
            PathCountryCode = pathCountryCode;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadAvailablePhoneNumberCountryOptions : ReadOptions<AvailablePhoneNumberCountryResource>
    {
    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) requesting the available phone number Country resources. </summary> 
        public string PathAccountSid { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

