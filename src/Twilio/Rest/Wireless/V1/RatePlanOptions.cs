/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Wireless
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
using System.Linq;



namespace Twilio.Rest.Wireless.V1
{

    /// <summary> create </summary>
    public class CreateRatePlanOptions : IOptions<RatePlanResource>
    {
        
        ///<summary> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </summary> 
        public string UniqueName { get; set; }

        ///<summary> A descriptive string that you create to describe the resource. It does not have to be unique. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Whether SIMs can use GPRS/3G/4G/LTE data connectivity. </summary> 
        public bool? DataEnabled { get; set; }

        ///<summary> The total data usage (download and upload combined) in Megabytes that the Network allows during one month on the home network (T-Mobile USA). The metering period begins the day of activation and ends on the same day in the following month. Can be up to 2TB and the default value is `1000`. </summary> 
        public int? DataLimit { get; set; }

        ///<summary> The model used to meter data usage. Can be: `payg` and `quota-1`, `quota-10`, and `quota-50`. Learn more about the available [data metering models](https://www.twilio.com/docs/wireless/api/rateplan-resource#payg-vs-quota-data-plans). </summary> 
        public string DataMetering { get; set; }

        ///<summary> Whether SIMs can make, send, and receive SMS using [Commands](https://www.twilio.com/docs/wireless/api/command-resource). </summary> 
        public bool? MessagingEnabled { get; set; }

        ///<summary> Deprecated. </summary> 
        public bool? VoiceEnabled { get; set; }

        ///<summary> Whether SIMs can roam on networks other than the home network (T-Mobile USA) in the United States. See [national roaming](https://www.twilio.com/docs/wireless/api/rateplan-resource#national-roaming). </summary> 
        public bool? NationalRoamingEnabled { get; set; }

        ///<summary> The list of services that SIMs capable of using GPRS/3G/4G/LTE data connectivity can use outside of the United States. Can contain: `data` and `messaging`. </summary> 
        public List<string> InternationalRoaming { get; set; }

        ///<summary> The total data usage (download and upload combined) in Megabytes that the Network allows during one month on non-home networks in the United States. The metering period begins the day of activation and ends on the same day in the following month. Can be up to 2TB. See [national roaming](https://www.twilio.com/docs/wireless/api/rateplan-resource#national-roaming) for more info. </summary> 
        public int? NationalRoamingDataLimit { get; set; }

        ///<summary> The total data usage (download and upload combined) in Megabytes that the Network allows during one month when roaming outside the United States. Can be up to 2TB. </summary> 
        public int? InternationalRoamingDataLimit { get; set; }



        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (DataEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("DataEnabled", DataEnabled.Value.ToString().ToLower()));
            }
            if (DataLimit != null)
            {
                p.Add(new KeyValuePair<string, string>("DataLimit", DataLimit.ToString()));
            }
            if (DataMetering != null)
            {
                p.Add(new KeyValuePair<string, string>("DataMetering", DataMetering));
            }
            if (MessagingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingEnabled", MessagingEnabled.Value.ToString().ToLower()));
            }
            if (VoiceEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceEnabled", VoiceEnabled.Value.ToString().ToLower()));
            }
            if (NationalRoamingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("NationalRoamingEnabled", NationalRoamingEnabled.Value.ToString().ToLower()));
            }
            if (InternationalRoaming != null)
            {
                p.AddRange(InternationalRoaming.Select(prop => new KeyValuePair<string, string>("InternationalRoaming", InternationalRoaming)));
            }
            if (NationalRoamingDataLimit != null)
            {
                p.Add(new KeyValuePair<string, string>("NationalRoamingDataLimit", NationalRoamingDataLimit.ToString()));
            }
            if (InternationalRoamingDataLimit != null)
            {
                p.Add(new KeyValuePair<string, string>("InternationalRoamingDataLimit", InternationalRoamingDataLimit.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteRatePlanOptions : IOptions<RatePlanResource>
    {
        
        ///<summary> The SID of the RatePlan resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteRatePlanOptions </summary>
        /// <param name="pathSid"> The SID of the RatePlan resource to delete. </param>
        public DeleteRatePlanOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchRatePlanOptions : IOptions<RatePlanResource>
    {
    
        ///<summary> The SID of the RatePlan resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchRatePlanOptions </summary>
        /// <param name="pathSid"> The SID of the RatePlan resource to fetch. </param>
        public FetchRatePlanOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadRatePlanOptions : ReadOptions<RatePlanResource>
    {
    



        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateRatePlanOptions : IOptions<RatePlanResource>
    {
    
        ///<summary> The SID of the RatePlan resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </summary> 
        public string UniqueName { get; set; }

        ///<summary> A descriptive string that you create to describe the resource. It does not have to be unique. </summary> 
        public string FriendlyName { get; set; }



        /// <summary> Construct a new UpdateRatePlanOptions </summary>
        /// <param name="pathSid"> The SID of the RatePlan resource to update. </param>
        public UpdateRatePlanOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }
        

    }


}

