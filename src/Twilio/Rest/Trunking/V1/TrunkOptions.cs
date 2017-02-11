using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Trunking.V1 
{

    public class FetchTrunkOptions : IOptions<TrunkResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchTrunkOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public FetchTrunkOptions(string sid)
        {
            Sid = sid;
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

    public class DeleteTrunkOptions : IOptions<TrunkResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new DeleteTrunkOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public DeleteTrunkOptions(string sid)
        {
            Sid = sid;
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

    public class CreateTrunkOptions : IOptions<TrunkResource> 
    {
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The domain_name
        /// </summary>
        public string DomainName { get; set; }
        /// <summary>
        /// The disaster_recovery_url
        /// </summary>
        public Uri DisasterRecoveryUrl { get; set; }
        /// <summary>
        /// The disaster_recovery_method
        /// </summary>
        public Twilio.Http.HttpMethod DisasterRecoveryMethod { get; set; }
        /// <summary>
        /// The recording
        /// </summary>
        public string Recording { get; set; }
        /// <summary>
        /// The secure
        /// </summary>
        public bool? Secure { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (DomainName != null)
            {
                p.Add(new KeyValuePair<string, string>("DomainName", DomainName));
            }
            
            if (DisasterRecoveryUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("DisasterRecoveryUrl", DisasterRecoveryUrl.ToString()));
            }
            
            if (DisasterRecoveryMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("DisasterRecoveryMethod", DisasterRecoveryMethod.ToString()));
            }
            
            if (Recording != null)
            {
                p.Add(new KeyValuePair<string, string>("Recording", Recording));
            }
            
            if (Secure != null)
            {
                p.Add(new KeyValuePair<string, string>("Secure", Secure.Value.ToString()));
            }
            
            return p;
        }
    }

    public class ReadTrunkOptions : ReadOptions<TrunkResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    public class UpdateTrunkOptions : IOptions<TrunkResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The domain_name
        /// </summary>
        public string DomainName { get; set; }
        /// <summary>
        /// The disaster_recovery_url
        /// </summary>
        public Uri DisasterRecoveryUrl { get; set; }
        /// <summary>
        /// The disaster_recovery_method
        /// </summary>
        public Twilio.Http.HttpMethod DisasterRecoveryMethod { get; set; }
        /// <summary>
        /// The recording
        /// </summary>
        public string Recording { get; set; }
        /// <summary>
        /// The secure
        /// </summary>
        public bool? Secure { get; set; }
    
        /// <summary>
        /// Construct a new UpdateTrunkOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public UpdateTrunkOptions(string sid)
        {
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (DomainName != null)
            {
                p.Add(new KeyValuePair<string, string>("DomainName", DomainName));
            }
            
            if (DisasterRecoveryUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("DisasterRecoveryUrl", DisasterRecoveryUrl.ToString()));
            }
            
            if (DisasterRecoveryMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("DisasterRecoveryMethod", DisasterRecoveryMethod.ToString()));
            }
            
            if (Recording != null)
            {
                p.Add(new KeyValuePair<string, string>("Recording", Recording));
            }
            
            if (Secure != null)
            {
                p.Add(new KeyValuePair<string, string>("Secure", Secure.Value.ToString()));
            }
            
            return p;
        }
    }

}