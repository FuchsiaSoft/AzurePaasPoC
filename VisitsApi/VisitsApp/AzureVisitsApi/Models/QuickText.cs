﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using VisitsApp.Models;

namespace VisitsApp.Models
{
    public partial class QuickText
    {
        private string _body;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private ServiceUserType _serviceUserType;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public ServiceUserType ServiceUserType
        {
            get { return this._serviceUserType; }
            set { this._serviceUserType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the QuickText class.
        /// </summary>
        public QuickText()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken bodyValue = inputObject["Body"];
                if (bodyValue != null && bodyValue.Type != JTokenType.Null)
                {
                    this.Body = ((string)bodyValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken serviceUserTypeValue = inputObject["ServiceUserType"];
                if (serviceUserTypeValue != null && serviceUserTypeValue.Type != JTokenType.Null)
                {
                    ServiceUserType serviceUserType = new ServiceUserType();
                    serviceUserType.DeserializeJson(serviceUserTypeValue);
                    this.ServiceUserType = serviceUserType;
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type QuickText
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Body != null)
            {
                outputObject["Body"] = this.Body;
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id.Value;
            }
            if (this.ServiceUserType != null)
            {
                outputObject["ServiceUserType"] = this.ServiceUserType.SerializeJson(null);
            }
            return outputObject;
        }
    }
}
