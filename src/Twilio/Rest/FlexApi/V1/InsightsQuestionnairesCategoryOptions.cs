/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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




namespace Twilio.Rest.FlexApi.V1
{

    /// <summary> To create a category for Questions </summary>
    public class CreateInsightsQuestionnairesCategoryOptions : IOptions<InsightsQuestionnairesCategoryResource>
    {
        
        ///<summary> The name of this category. </summary> 
        public string Name { get; }

        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }


        /// <summary> Construct a new CreateInsightsQuestionnairesCategoryOptions </summary>
        /// <param name="name"> The name of this category. </param>
        public CreateInsightsQuestionnairesCategoryOptions(string name)
        {
            Name = name;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Name != null)
            {
                p.Add(new KeyValuePair<string, string>("Name", Name));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (Token != null)
        {
            p.Add(new KeyValuePair<string, string>("Token", Token));
        }
        return p;
    }

    }
    /// <summary> delete </summary>
    public class DeleteInsightsQuestionnairesCategoryOptions : IOptions<InsightsQuestionnairesCategoryResource>
    {
        
        ///<summary> The ID of the category to be deleted </summary> 
        public string PathCategoryId { get; }

        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }



        /// <summary> Construct a new DeleteInsightsQuestionnairesCategoryOptions </summary>
        /// <param name="pathCategoryId"> The ID of the category to be deleted </param>
        public DeleteInsightsQuestionnairesCategoryOptions(string pathCategoryId)
        {
            PathCategoryId = pathCategoryId;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (Token != null)
        {
            p.Add(new KeyValuePair<string, string>("Token", Token));
        }
        return p;
    }

    }


    /// <summary> To update the category for Questions </summary>
    public class UpdateInsightsQuestionnairesCategoryOptions : IOptions<InsightsQuestionnairesCategoryResource>
    {
    
        ///<summary> The ID of the category to be update </summary> 
        public string PathCategoryId { get; }

        ///<summary> The name of this category. </summary> 
        public string Name { get; }

        ///<summary> The Token HTTP request header </summary> 
        public string Token { get; set; }



        /// <summary> Construct a new UpdateInsightsQuestionnairesCategoryOptions </summary>
        /// <param name="pathCategoryId"> The ID of the category to be update </param>
        /// <param name="name"> The name of this category. </param>
        public UpdateInsightsQuestionnairesCategoryOptions(string pathCategoryId, string name)
        {
            PathCategoryId = pathCategoryId;
            Name = name;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Name != null)
            {
                p.Add(new KeyValuePair<string, string>("Name", Name));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (Token != null)
        {
            p.Add(new KeyValuePair<string, string>("Token", Token));
        }
        return p;
    }

    }


}

