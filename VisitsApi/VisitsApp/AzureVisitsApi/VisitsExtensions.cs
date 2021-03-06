﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using VisitsApp;
using VisitsApp.Models;

namespace VisitsApp
{
    public static partial class VisitsExtensions
    {
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Visit DeleteVisit(this IVisits operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisits)s).DeleteVisitAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Visit> DeleteVisitAsync(this IVisits operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<VisitsApp.Models.Visit> result = await operations.DeleteVisitWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Visit GetVisit(this IVisits operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisits)s).GetVisitAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Visit> GetVisitAsync(this IVisits operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<VisitsApp.Models.Visit> result = await operations.GetVisitWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        public static IList<Visit> GetVisits(this IVisits operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisits)s).GetVisitsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Visit>> GetVisitsAsync(this IVisits operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<VisitsApp.Models.Visit>> result = await operations.GetVisitsWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        /// <param name='visit'>
        /// Required.
        /// </param>
        public static Visit PostVisit(this IVisits operations, Visit visit)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisits)s).PostVisitAsync(visit);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        /// <param name='visit'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Visit> PostVisitAsync(this IVisits operations, Visit visit, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<VisitsApp.Models.Visit> result = await operations.PostVisitWithOperationResponseAsync(visit, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='visit'>
        /// Required.
        /// </param>
        public static object PutVisit(this IVisits operations, int id, Visit visit)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisits)s).PutVisitAsync(id, visit);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisits.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='visit'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutVisitAsync(this IVisits operations, int id, Visit visit, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutVisitWithOperationResponseAsync(id, visit, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
