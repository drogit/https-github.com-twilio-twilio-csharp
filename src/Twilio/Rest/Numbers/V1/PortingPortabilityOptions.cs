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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Numbers.V1
{
    /// <summary> Allows to check if a single phone number can be ported to Twilio or not. </summary>
    public class FetchPortingPortabilityOptions : IOptions<PortingPortabilityResource>
    {
    
        ///<summary> The phone number which portability is to be checked. Phone numbers are in E.164 format (e.g. +16175551212). </summary> 
        public Types.PhoneNumber PathPhoneNumber { get; }

        ///<summary> The SID of the account where the phone number(s) will be ported. </summary> 
        public string TargetAccountSid { get; set; }



        /// <summary> Construct a new FetchPortingPortabilityOptions </summary>
        /// <param name="pathPhoneNumber"> The phone number which portability is to be checked. Phone numbers are in E.164 format (e.g. +16175551212). </param>
        public FetchPortingPortabilityOptions(Types.PhoneNumber pathPhoneNumber)
        {
            PathPhoneNumber = pathPhoneNumber;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (TargetAccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetAccountSid", TargetAccountSid));
            }
            return p;
        }

        

    }


}

