using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class CreateAddressOptions : IOptions<AddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// The customer_name
        /// </summary>
        public string CustomerName { get; }
        /// <summary>
        /// The street
        /// </summary>
        public string Street { get; }
        /// <summary>
        /// The city
        /// </summary>
        public string City { get; }
        /// <summary>
        /// The region
        /// </summary>
        public string Region { get; }
        /// <summary>
        /// The postal_code
        /// </summary>
        public string PostalCode { get; }
        /// <summary>
        /// The iso_country
        /// </summary>
        public string IsoCountry { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The emergency_enabled
        /// </summary>
        public bool? EmergencyEnabled { get; set; }
    
        /// <summary>
        /// Construct a new CreateAddressOptions
        /// </summary>
        ///
        /// <param name="customerName"> The customer_name </param>
        /// <param name="street"> The street </param>
        /// <param name="city"> The city </param>
        /// <param name="region"> The region </param>
        /// <param name="postalCode"> The postal_code </param>
        /// <param name="isoCountry"> The iso_country </param>
        public CreateAddressOptions(string customerName, string street, string city, string region, string postalCode, string isoCountry)
        {
            CustomerName = customerName;
            Street = street;
            City = city;
            Region = region;
            PostalCode = postalCode;
            IsoCountry = isoCountry;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (CustomerName != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomerName", CustomerName));
            }
            
            if (Street != null)
            {
                p.Add(new KeyValuePair<string, string>("Street", Street));
            }
            
            if (City != null)
            {
                p.Add(new KeyValuePair<string, string>("City", City));
            }
            
            if (Region != null)
            {
                p.Add(new KeyValuePair<string, string>("Region", Region));
            }
            
            if (PostalCode != null)
            {
                p.Add(new KeyValuePair<string, string>("PostalCode", PostalCode));
            }
            
            if (IsoCountry != null)
            {
                p.Add(new KeyValuePair<string, string>("IsoCountry", IsoCountry.ToString()));
            }
            
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (EmergencyEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyEnabled", EmergencyEnabled.Value.ToString()));
            }
            
            return p;
        }
    }

    public class DeleteAddressOptions : IOptions<AddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new DeleteAddressOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public DeleteAddressOptions(string sid)
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

    public class FetchAddressOptions : IOptions<AddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchAddressOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public FetchAddressOptions(string sid)
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

    public class UpdateAddressOptions : IOptions<AddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The customer_name
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// The street
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// The city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// The region
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// The postal_code
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// The emergency_enabled
        /// </summary>
        public bool? EmergencyEnabled { get; set; }
    
        /// <summary>
        /// Construct a new UpdateAddressOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public UpdateAddressOptions(string sid)
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
            
            if (CustomerName != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomerName", CustomerName));
            }
            
            if (Street != null)
            {
                p.Add(new KeyValuePair<string, string>("Street", Street));
            }
            
            if (City != null)
            {
                p.Add(new KeyValuePair<string, string>("City", City));
            }
            
            if (Region != null)
            {
                p.Add(new KeyValuePair<string, string>("Region", Region));
            }
            
            if (PostalCode != null)
            {
                p.Add(new KeyValuePair<string, string>("PostalCode", PostalCode));
            }
            
            if (EmergencyEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyEnabled", EmergencyEnabled.Value.ToString()));
            }
            
            return p;
        }
    }

    public class ReadAddressOptions : ReadOptions<AddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// The customer_name
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The iso_country
        /// </summary>
        public string IsoCountry { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (CustomerName != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomerName", CustomerName));
            }
            
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (IsoCountry != null)
            {
                p.Add(new KeyValuePair<string, string>("IsoCountry", IsoCountry.ToString()));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

}