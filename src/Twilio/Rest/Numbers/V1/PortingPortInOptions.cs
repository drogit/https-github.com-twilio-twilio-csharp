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

    /// <summary> Allows to create a new port in request </summary>
    public class CreatePortingPortInOptions : IOptions<PortingPortInResource>
    {
        
        
        public object Body { get; set; }



        
        /// <summary> Generate the request body </summary>
        public string GetBody()
        {
            string body = "";

            if (Body != null)
            {
                body = PortingPortInResource.ToJson(Body);
            }
            return body;
        }
        

    }
}

