/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Sync.V1.Service.SyncList
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchSyncListItemOptions
    /// </summary>
    public class FetchSyncListItemOptions : IOptions<SyncListItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List Item resource to fetch
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List with the Sync List Item resource to fetch
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The index of the Sync List Item resource to fetch
        /// </summary>
        public int? PathIndex { get; }

        /// <summary>
        /// Construct a new FetchSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List Item resource to fetch </param>
        /// <param name="pathListSid"> The SID of the Sync List with the Sync List Item resource to fetch </param>
        /// <param name="pathIndex"> The index of the Sync List Item resource to fetch </param>
        public FetchSyncListItemOptions(string pathServiceSid, string pathListSid, int? pathIndex)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIndex = pathIndex;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteSyncListItemOptions
    /// </summary>
    public class DeleteSyncListItemOptions : IOptions<SyncListItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List Item resource to delete
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List with the Sync List Item resource to delete
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The index of the Sync List Item resource to delete
        /// </summary>
        public int? PathIndex { get; }
        /// <summary>
        /// The If-Match HTTP request header
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Construct a new DeleteSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List Item resource to delete </param>
        /// <param name="pathListSid"> The SID of the Sync List with the Sync List Item resource to delete </param>
        /// <param name="pathIndex"> The index of the Sync List Item resource to delete </param>
        public DeleteSyncListItemOptions(string pathServiceSid, string pathListSid, int? pathIndex)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIndex = pathIndex;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
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

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// CreateSyncListItemOptions
    /// </summary>
    public class CreateSyncListItemOptions : IOptions<SyncListItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service to create the List Item in
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List to add the new List Item to
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// A JSON string that represents an arbitrary, schema-less object that the List Item stores
        /// </summary>
        public object Data { get; }
        /// <summary>
        /// An alias for item_ttl
        /// </summary>
        public int? Ttl { get; set; }
        /// <summary>
        /// How long, in seconds, before the List Item expires
        /// </summary>
        public int? ItemTtl { get; set; }
        /// <summary>
        /// How long, in seconds, before the List Item's parent Sync List expires
        /// </summary>
        public int? CollectionTtl { get; set; }

        /// <summary>
        /// Construct a new CreateSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service to create the List Item in </param>
        /// <param name="pathListSid"> The SID of the Sync List to add the new List Item to </param>
        /// <param name="data"> A JSON string that represents an arbitrary, schema-less object that the List Item stores
        ///            </param>
        public CreateSyncListItemOptions(string pathServiceSid, string pathListSid, object data)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            Data = data;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            if (ItemTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("ItemTtl", ItemTtl.ToString()));
            }

            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// ReadSyncListItemOptions
    /// </summary>
    public class ReadSyncListItemOptions : ReadOptions<SyncListItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the List Item resources to read
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List with the List Items to read
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The order to return the List Items
        /// </summary>
        public SyncListItemResource.QueryResultOrderEnum Order { get; set; }
        /// <summary>
        /// The index of the first Sync List Item resource to read
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Whether to include the List Item referenced by the from parameter
        /// </summary>
        public SyncListItemResource.QueryFromBoundTypeEnum Bounds { get; set; }

        /// <summary>
        /// Construct a new ReadSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the List Item resources to read </param>
        /// <param name="pathListSid"> The SID of the Sync List with the List Items to read </param>
        public ReadSyncListItemOptions(string pathServiceSid, string pathListSid)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (Bounds != null)
            {
                p.Add(new KeyValuePair<string, string>("Bounds", Bounds.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// UpdateSyncListItemOptions
    /// </summary>
    public class UpdateSyncListItemOptions : IOptions<SyncListItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List Item resource to update
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List with the Sync List Item resource to update
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The index of the Sync List Item resource to update
        /// </summary>
        public int? PathIndex { get; }
        /// <summary>
        /// A JSON string that represents an arbitrary, schema-less object that the List Item stores
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// An alias for item_ttl
        /// </summary>
        public int? Ttl { get; set; }
        /// <summary>
        /// How long, in seconds, before the List Item expires
        /// </summary>
        public int? ItemTtl { get; set; }
        /// <summary>
        /// How long, in seconds, before the List Item's parent Sync List expires
        /// </summary>
        public int? CollectionTtl { get; set; }
        /// <summary>
        /// The If-Match HTTP request header
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Construct a new UpdateSyncListItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List Item resource to update </param>
        /// <param name="pathListSid"> The SID of the Sync List with the Sync List Item resource to update </param>
        /// <param name="pathIndex"> The index of the Sync List Item resource to update </param>
        public UpdateSyncListItemOptions(string pathServiceSid, string pathListSid, int? pathIndex)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIndex = pathIndex;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            if (ItemTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("ItemTtl", ItemTtl.ToString()));
            }

            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }

            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
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