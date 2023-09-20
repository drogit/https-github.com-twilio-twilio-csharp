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




namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance.Bundle
{

    /// <summary> Creates an evaluation for a bundle </summary>
    public class CreateEvaluationOptions : IOptions<EvaluationResource>
    {
        
        ///<summary> The unique string that identifies the Bundle resource. </summary> 
        public string PathBundleSid { get; }


        /// <summary> Construct a new CreateEvaluationOptions </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle resource. </param>
        public CreateEvaluationOptions(string pathBundleSid)
        {
            PathBundleSid = pathBundleSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }
    /// <summary> Fetch specific Evaluation Instance. </summary>
    public class FetchEvaluationOptions : IOptions<EvaluationResource>
    {
    
        ///<summary> The unique string that we created to identify the Bundle resource. </summary> 
        public string PathBundleSid { get; }

        ///<summary> The unique string that identifies the Evaluation resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchEvaluationOptions </summary>
        /// <param name="pathBundleSid"> The unique string that we created to identify the Bundle resource. </param>
        /// <param name="pathSid"> The unique string that identifies the Evaluation resource. </param>
        public FetchEvaluationOptions(string pathBundleSid, string pathSid)
        {
            PathBundleSid = pathBundleSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of Evaluations associated to the Bundle resource. </summary>
    public class ReadEvaluationOptions : ReadOptions<EvaluationResource>
    {
    
        ///<summary> The unique string that identifies the Bundle resource. </summary> 
        public string PathBundleSid { get; }



        /// <summary> Construct a new ListEvaluationOptions </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle resource. </param>
        public ReadEvaluationOptions(string pathBundleSid)
        {
            PathBundleSid = pathBundleSid;
        }

        
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

