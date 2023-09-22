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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Microvisor.V1
{
    /// <summary> Delete a specific App. </summary>
    public class DeleteAppOptions : IOptions<AppResource>
    {
        
        ///<summary> A 34-character string that uniquely identifies this App. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteAppOptions </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this App. </param>
        public DeleteAppOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Fetch a specific App. </summary>
    public class FetchAppOptions : IOptions<AppResource>
    {
    
        ///<summary> A 34-character string that uniquely identifies this App. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchAppOptions </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this App. </param>
        public FetchAppOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Retrieve a list of all Apps for an Account. </summary>
    public class ReadAppOptions : ReadOptions<AppResource>
    {
    



        
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

