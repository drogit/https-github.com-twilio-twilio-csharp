/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Studio
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




namespace Twilio.Rest.Studio.V1.Flow
{

    /// <summary> Triggers a new Execution for the Flow </summary>
    public class CreateExecutionOptions : IOptions<ExecutionResource>
    {
        
        ///<summary> The SID of the Excecution's Flow. </summary> 
        public string PathFlowSid { get; }

        ///<summary> The Contact phone number to start a Studio Flow Execution, available as variable `{{contact.channel.address}}`. </summary> 
        public Types.PhoneNumber To { get; }

        ///<summary> The Twilio phone number to send messages or initiate calls from during the Flow's Execution. Available as variable `{{flow.channel.address}}`. For SMS, this can also be a Messaging Service SID. </summary> 
        public Types.PhoneNumber From { get; }

        ///<summary> JSON data that will be added to the Flow's context and that can be accessed as variables inside your Flow. For example, if you pass in `Parameters={\\\"name\\\":\\\"Zeke\\\"}`, a widget in your Flow can reference the variable `{{flow.data.name}}`, which returns \\\"Zeke\\\". Note: the JSON value must explicitly be passed as a string, not as a hash object. Depending on your particular HTTP library, you may need to add quotes or URL encode the JSON string. </summary> 
        public object Parameters { get; set; }


        /// <summary> Construct a new CreateExecutionOptions </summary>
        /// <param name="pathFlowSid"> The SID of the Excecution's Flow. </param>
        /// <param name="to"> The Contact phone number to start a Studio Flow Execution, available as variable `{{contact.channel.address}}`. </param>
        /// <param name="from"> The Twilio phone number to send messages or initiate calls from during the Flow's Execution. Available as variable `{{flow.channel.address}}`. For SMS, this can also be a Messaging Service SID. </param>
        public CreateExecutionOptions(string pathFlowSid, Types.PhoneNumber to, Types.PhoneNumber from)
        {
            PathFlowSid = pathFlowSid;
            To = to;
            From = from;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }
            if (Parameters != null)
            {
                p.Add(new KeyValuePair<string, string>("Parameters", Serializers.JsonObject(Parameters)));
            }
            return p;
        }
        

    }
    /// <summary> Delete the Execution and all Steps relating to it. </summary>
    public class DeleteExecutionOptions : IOptions<ExecutionResource>
    {
        
        ///<summary> The SID of the Flow with the Execution resources to delete. </summary> 
        public string PathFlowSid { get; }

        ///<summary> The SID of the Execution resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteExecutionOptions </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Execution resources to delete. </param>
        /// <param name="pathSid"> The SID of the Execution resource to delete. </param>
        public DeleteExecutionOptions(string pathFlowSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve an Execution </summary>
    public class FetchExecutionOptions : IOptions<ExecutionResource>
    {
    
        ///<summary> The SID of the Flow with the Execution resource to fetch </summary> 
        public string PathFlowSid { get; }

        ///<summary> The SID of the Execution resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchExecutionOptions </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Execution resource to fetch </param>
        /// <param name="pathSid"> The SID of the Execution resource to fetch. </param>
        public FetchExecutionOptions(string pathFlowSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Executions for the Flow. </summary>
    public class ReadExecutionOptions : ReadOptions<ExecutionResource>
    {
    
        ///<summary> The SID of the Flow with the Execution resources to read. </summary> 
        public string PathFlowSid { get; }

        ///<summary> Only show Execution resources starting on or after this [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time, given as `YYYY-MM-DDThh:mm:ss-hh:mm`. </summary> 
        public DateTime? DateCreatedFrom { get; set; }

        ///<summary> Only show Execution resources starting before this [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time, given as `YYYY-MM-DDThh:mm:ss-hh:mm`. </summary> 
        public DateTime? DateCreatedTo { get; set; }



        /// <summary> Construct a new ListExecutionOptions </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Execution resources to read. </param>
        public ReadExecutionOptions(string pathFlowSid)
        {
            PathFlowSid = pathFlowSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (DateCreatedFrom != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedFrom", Serializers.DateTimeIso8601(DateCreatedFrom)));
            }
            if (DateCreatedTo != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedTo", Serializers.DateTimeIso8601(DateCreatedTo)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Update the status of an Execution to `ended`. </summary>
    public class UpdateExecutionOptions : IOptions<ExecutionResource>
    {
    
        ///<summary> The SID of the Flow with the Execution resources to update. </summary> 
        public string PathFlowSid { get; }

        ///<summary> The SID of the Execution resource to update. </summary> 
        public string PathSid { get; }

        
        public ExecutionResource.StatusEnum Status { get; }



        /// <summary> Construct a new UpdateExecutionOptions </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Execution resources to update. </param>
        /// <param name="pathSid"> The SID of the Execution resource to update. </param>
        /// <param name="status">  </param>
        public UpdateExecutionOptions(string pathFlowSid, string pathSid, ExecutionResource.StatusEnum status)
        {
            PathFlowSid = pathFlowSid;
            PathSid = pathSid;
            Status = status;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            return p;
        }
        

    }


}

