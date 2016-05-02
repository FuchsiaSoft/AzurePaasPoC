﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using VisitsApp.Models;

namespace VisitsApp.Models
{
    public static partial class VisitorCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<Visitor> DeserializeJson(JToken inputObject)
        {
            IList<Visitor> deserializedObject = new List<Visitor>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                Visitor visitor = new Visitor();
                visitor.DeserializeJson(iListValue);
                deserializedObject.Add(visitor);
            }
            return deserializedObject;
        }
    }
}
