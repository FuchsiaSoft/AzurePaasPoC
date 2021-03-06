﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using VisitsApp.Models;

namespace VisitsApp
{
    public partial interface IVisits
    {
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<Visit>> DeleteVisitWithOperationResponseAsync(int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<Visit>> GetVisitWithOperationResponseAsync(int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Visit>>> GetVisitsWithOperationResponseAsync(CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='visit'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<Visit>> PostVisitWithOperationResponseAsync(Visit visit, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='visit'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PutVisitWithOperationResponseAsync(int id, Visit visit, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
