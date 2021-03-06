﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Rest;
using Newtonsoft.Json.Linq;
using VisitsApp.Models;

namespace VisitsApp.Models
{
    public partial class Visitor
    {
        private IList<ServiceUser> _assignedServiceUsers;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<ServiceUser> AssignedServiceUsers
        {
            get { return this._assignedServiceUsers; }
            set { this._assignedServiceUsers = value; }
        }
        
        private string _firstname;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Firstname
        {
            get { return this._firstname; }
            set { this._firstname = value; }
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
        
        private string _jobTitle;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string JobTitle
        {
            get { return this._jobTitle; }
            set { this._jobTitle = value; }
        }
        
        private string _surname;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Surname
        {
            get { return this._surname; }
            set { this._surname = value; }
        }
        
        private IList<Visit> _visits;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<Visit> Visits
        {
            get { return this._visits; }
            set { this._visits = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Visitor class.
        /// </summary>
        public Visitor()
        {
            this.AssignedServiceUsers = new LazyList<ServiceUser>();
            this.Visits = new LazyList<Visit>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken assignedServiceUsersSequence = ((JToken)inputObject["AssignedServiceUsers"]);
                if (assignedServiceUsersSequence != null && assignedServiceUsersSequence.Type != JTokenType.Null)
                {
                    foreach (JToken assignedServiceUsersValue in ((JArray)assignedServiceUsersSequence))
                    {
                        ServiceUser serviceUser = new ServiceUser();
                        serviceUser.DeserializeJson(assignedServiceUsersValue);
                        this.AssignedServiceUsers.Add(serviceUser);
                    }
                }
                JToken firstnameValue = inputObject["Firstname"];
                if (firstnameValue != null && firstnameValue.Type != JTokenType.Null)
                {
                    this.Firstname = ((string)firstnameValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken jobTitleValue = inputObject["JobTitle"];
                if (jobTitleValue != null && jobTitleValue.Type != JTokenType.Null)
                {
                    this.JobTitle = ((string)jobTitleValue);
                }
                JToken surnameValue = inputObject["Surname"];
                if (surnameValue != null && surnameValue.Type != JTokenType.Null)
                {
                    this.Surname = ((string)surnameValue);
                }
                JToken visitsSequence = ((JToken)inputObject["Visits"]);
                if (visitsSequence != null && visitsSequence.Type != JTokenType.Null)
                {
                    foreach (JToken visitsValue in ((JArray)visitsSequence))
                    {
                        Visit visit = new Visit();
                        visit.DeserializeJson(visitsValue);
                        this.Visits.Add(visit);
                    }
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Visitor
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            JArray assignedServiceUsersSequence = null;
            if (this.AssignedServiceUsers != null)
            {
                if (this.AssignedServiceUsers is ILazyCollection<ServiceUser> == false || ((ILazyCollection<ServiceUser>)this.AssignedServiceUsers).IsInitialized)
                {
                    assignedServiceUsersSequence = new JArray();
                    outputObject["AssignedServiceUsers"] = assignedServiceUsersSequence;
                    foreach (ServiceUser assignedServiceUsersItem in this.AssignedServiceUsers)
                    {
                        if (assignedServiceUsersItem != null)
                        {
                            assignedServiceUsersSequence.Add(assignedServiceUsersItem.SerializeJson(null));
                        }
                    }
                }
            }
            if (this.Firstname != null)
            {
                outputObject["Firstname"] = this.Firstname;
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id.Value;
            }
            if (this.JobTitle != null)
            {
                outputObject["JobTitle"] = this.JobTitle;
            }
            if (this.Surname != null)
            {
                outputObject["Surname"] = this.Surname;
            }
            JArray visitsSequence = null;
            if (this.Visits != null)
            {
                if (this.Visits is ILazyCollection<Visit> == false || ((ILazyCollection<Visit>)this.Visits).IsInitialized)
                {
                    visitsSequence = new JArray();
                    outputObject["Visits"] = visitsSequence;
                    foreach (Visit visitsItem in this.Visits)
                    {
                        if (visitsItem != null)
                        {
                            visitsSequence.Add(visitsItem.SerializeJson(null));
                        }
                    }
                }
            }
            return outputObject;
        }
    }
}
