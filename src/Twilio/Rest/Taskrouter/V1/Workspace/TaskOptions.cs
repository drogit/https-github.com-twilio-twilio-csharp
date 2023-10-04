/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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



namespace Twilio.Rest.Taskrouter.V1.Workspace
{

    /// <summary> create </summary>
    public class CreateTaskOptions : IOptions<TaskResource>
    {
        
        ///<summary> The SID of the Workspace that the new Task belongs to. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The amount of time in seconds the new task can live before being assigned. Can be up to a maximum of 2 weeks (1,209,600 seconds). The default value is 24 hours (86,400 seconds). On timeout, the `task.canceled` event will fire with description `Task TTL Exceeded`. </summary> 
        public int? Timeout { get; set; }

        ///<summary> The priority to assign the new task and override the default. When supplied, the new Task will have this priority unless it matches a Workflow Target with a Priority set. When not supplied, the new Task will have the priority of the matching Workflow Target. Value can be 0 to 2^31^ (2,147,483,647). </summary> 
        public int? Priority { get; set; }

        ///<summary> When MultiTasking is enabled, specify the TaskChannel by passing either its `unique_name` or `sid`. Default value is `default`. </summary> 
        public string TaskChannel { get; set; }

        ///<summary> The SID of the Workflow that you would like to handle routing for the new Task. If there is only one Workflow defined for the Workspace that you are posting the new task to, this parameter is optional. </summary> 
        public string WorkflowSid { get; set; }

        ///<summary> A URL-encoded JSON string with the attributes of the new task. This value is passed to the Workflow's `assignment_callback_url` when the Task is assigned to a Worker. For example: `{ \\\"task_type\\\": \\\"call\\\", \\\"twilio_call_sid\\\": \\\"CAxxx\\\", \\\"customer_ticket_number\\\": \\\"12345\\\" }`. </summary> 
        public string Attributes { get; set; }


        /// <summary> Construct a new CreateTaskOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Task belongs to. </param>
        public CreateTaskOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.ToString()));
            }
            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }
            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }
            if (WorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowSid", WorkflowSid));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            return p;
        }

        

    }
    /// <summary> delete </summary>
    public class DeleteTaskOptions : IOptions<TaskResource>
    {
        
        ///<summary> The SID of the Workspace with the Task to delete. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Task resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> If provided, deletes this Task if (and only if) the [ETag](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/ETag) header of the Task matches the provided value. This matches the semantics of (and is implemented with) the HTTP [If-Match header](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/If-Match). </summary> 
        public string IfMatch { get; set; }



        /// <summary> Construct a new DeleteTaskOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Task to delete. </param>
        /// <param name="pathSid"> The SID of the Task resource to delete. </param>
        public DeleteTaskOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (IfMatch != null)
        {
            p.Add(new KeyValuePair<string, string>("If-Match", IfMatch));
        }
        return p;
    }

    }


    /// <summary> fetch </summary>
    public class FetchTaskOptions : IOptions<TaskResource>
    {
    
        ///<summary> The SID of the Workspace with the Task to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Task resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchTaskOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Task to fetch. </param>
        /// <param name="pathSid"> The SID of the Task resource to fetch. </param>
        public FetchTaskOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> read </summary>
    public class ReadTaskOptions : ReadOptions<TaskResource>
    {
    
        ///<summary> The SID of the Workspace with the Tasks to read. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The priority value of the Tasks to read. Returns the list of all Tasks in the Workspace with the specified priority. </summary> 
        public int? Priority { get; set; }

        ///<summary> The `assignment_status` of the Tasks you want to read. Can be: `pending`, `reserved`, `assigned`, `canceled`, `wrapping`, or `completed`. Returns all Tasks in the Workspace with the specified `assignment_status`. </summary> 
        public List<string> AssignmentStatus { get; set; }

        ///<summary> The SID of the Workflow with the Tasks to read. Returns the Tasks controlled by the Workflow identified by this SID. </summary> 
        public string WorkflowSid { get; set; }

        ///<summary> The friendly name of the Workflow with the Tasks to read. Returns the Tasks controlled by the Workflow identified by this friendly name. </summary> 
        public string WorkflowName { get; set; }

        ///<summary> The SID of the TaskQueue with the Tasks to read. Returns the Tasks waiting in the TaskQueue identified by this SID. </summary> 
        public string TaskQueueSid { get; set; }

        ///<summary> The `friendly_name` of the TaskQueue with the Tasks to read. Returns the Tasks waiting in the TaskQueue identified by this friendly name. </summary> 
        public string TaskQueueName { get; set; }

        ///<summary> The attributes of the Tasks to read. Returns the Tasks that match the attributes specified in this parameter. </summary> 
        public string EvaluateTaskAttributes { get; set; }

        ///<summary> How to order the returned Task resources. y default, Tasks are sorted by ascending DateCreated. This value is specified as: `Attribute:Order`, where `Attribute` can be either `Priority` or `DateCreated` and `Order` can be either `asc` or `desc`. For example, `Priority:desc` returns Tasks ordered in descending order of their Priority. Multiple sort orders can be specified in a comma-separated list such as `Priority:desc,DateCreated:asc`, which returns the Tasks in descending Priority order and ascending DateCreated Order. </summary> 
        public string Ordering { get; set; }

        ///<summary> Whether to read Tasks with addons. If `true`, returns only Tasks with addons. If `false`, returns only Tasks without addons. </summary> 
        public bool? HasAddons { get; set; }



        /// <summary> Construct a new ListTaskOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Tasks to read. </param>
        public ReadTaskOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            AssignmentStatus = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }
            if (AssignmentStatus != null)
            {
                p.AddRange(AssignmentStatus.Select(AssignmentStatus => new KeyValuePair<string, string>("AssignmentStatus", AssignmentStatus)));
            }
            if (WorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowSid", WorkflowSid));
            }
            if (WorkflowName != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowName", WorkflowName));
            }
            if (TaskQueueSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueSid", TaskQueueSid));
            }
            if (TaskQueueName != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueName", TaskQueueName));
            }
            if (EvaluateTaskAttributes != null)
            {
                p.Add(new KeyValuePair<string, string>("EvaluateTaskAttributes", EvaluateTaskAttributes));
            }
            if (Ordering != null)
            {
                p.Add(new KeyValuePair<string, string>("Ordering", Ordering));
            }
            if (HasAddons != null)
            {
                p.Add(new KeyValuePair<string, string>("HasAddons", HasAddons.Value.ToString().ToLower()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

    /// <summary> update </summary>
    public class UpdateTaskOptions : IOptions<TaskResource>
    {
    
        ///<summary> The SID of the Workspace with the Task to update. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Task resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> If provided, applies this mutation if (and only if) the [ETag](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/ETag) header of the Task matches the provided value. This matches the semantics of (and is implemented with) the HTTP [If-Match header](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/If-Match). </summary> 
        public string IfMatch { get; set; }

        ///<summary> The JSON string that describes the custom attributes of the task. </summary> 
        public string Attributes { get; set; }

        
        public TaskResource.StatusEnum AssignmentStatus { get; set; }

        ///<summary> The reason that the Task was canceled or completed. This parameter is required only if the Task is canceled or completed. Setting this value queues the task for deletion and logs the reason. </summary> 
        public string Reason { get; set; }

        ///<summary> The Task's new priority value. When supplied, the Task takes on the specified priority unless it matches a Workflow Target with a Priority set. Value can be 0 to 2^31^ (2,147,483,647). </summary> 
        public int? Priority { get; set; }

        ///<summary> When MultiTasking is enabled, specify the TaskChannel with the task to update. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </summary> 
        public string TaskChannel { get; set; }



        /// <summary> Construct a new UpdateTaskOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Task to update. </param>
        /// <param name="pathSid"> The SID of the Task resource to update. </param>
        public UpdateTaskOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            if (AssignmentStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentStatus", AssignmentStatus.ToString()));
            }
            if (Reason != null)
            {
                p.Add(new KeyValuePair<string, string>("Reason", Reason));
            }
            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }
            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }
            return p;
        }

        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (IfMatch != null)
        {
            p.Add(new KeyValuePair<string, string>("If-Match", IfMatch));
        }
        return p;
    }

    }


}

