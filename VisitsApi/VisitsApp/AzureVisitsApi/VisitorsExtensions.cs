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
    public static partial class VisitorsExtensions
    {
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Visitor DeleteVisitor(this IVisitors operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisitors)s).DeleteVisitorAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Visitor> DeleteVisitorAsync(this IVisitors operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<VisitsApp.Models.Visitor> result = await operations.DeleteVisitorWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Visitor GetVisitor(this IVisitors operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisitors)s).GetVisitorAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Visitor> GetVisitorAsync(this IVisitors operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<VisitsApp.Models.Visitor> result = await operations.GetVisitorWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        public static IList<Visitor> GetVisitors(this IVisitors operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisitors)s).GetVisitorsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Visitor>> GetVisitorsAsync(this IVisitors operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<VisitsApp.Models.Visitor>> result = await operations.GetVisitorsWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        /// <param name='visitor'>
        /// Required.
        /// </param>
        public static Visitor PostVisitor(this IVisitors operations, Visitor visitor)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisitors)s).PostVisitorAsync(visitor);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        /// <param name='visitor'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Visitor> PostVisitorAsync(this IVisitors operations, Visitor visitor, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<VisitsApp.Models.Visitor> result = await operations.PostVisitorWithOperationResponseAsync(visitor, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='visitor'>
        /// Required.
        /// </param>
        public static object PutVisitor(this IVisitors operations, int id, Visitor visitor)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVisitors)s).PutVisitorAsync(id, visitor);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IVisitors.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='visitor'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutVisitorAsync(this IVisitors operations, int id, Visitor visitor, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutVisitorWithOperationResponseAsync(id, visitor, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
