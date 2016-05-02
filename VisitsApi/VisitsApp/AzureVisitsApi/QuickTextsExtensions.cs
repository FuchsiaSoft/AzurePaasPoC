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
    public static partial class QuickTextsExtensions
    {
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static QuickText DeleteQuickText(this IQuickTexts operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IQuickTexts)s).DeleteQuickTextAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<QuickText> DeleteQuickTextAsync(this IQuickTexts operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<VisitsApp.Models.QuickText> result = await operations.DeleteQuickTextWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static QuickText GetQuickText(this IQuickTexts operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IQuickTexts)s).GetQuickTextAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<QuickText> GetQuickTextAsync(this IQuickTexts operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<VisitsApp.Models.QuickText> result = await operations.GetQuickTextWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        public static IList<QuickText> GetQuickTexts(this IQuickTexts operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IQuickTexts)s).GetQuickTextsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<QuickText>> GetQuickTextsAsync(this IQuickTexts operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<VisitsApp.Models.QuickText>> result = await operations.GetQuickTextsWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        /// <param name='quickText'>
        /// Required.
        /// </param>
        public static QuickText PostQuickText(this IQuickTexts operations, QuickText quickText)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IQuickTexts)s).PostQuickTextAsync(quickText);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        /// <param name='quickText'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<QuickText> PostQuickTextAsync(this IQuickTexts operations, QuickText quickText, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<VisitsApp.Models.QuickText> result = await operations.PostQuickTextWithOperationResponseAsync(quickText, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='quickText'>
        /// Required.
        /// </param>
        public static object PutQuickText(this IQuickTexts operations, int id, QuickText quickText)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IQuickTexts)s).PutQuickTextAsync(id, quickText);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the VisitsApp.IQuickTexts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='quickText'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutQuickTextAsync(this IQuickTexts operations, int id, QuickText quickText, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutQuickTextWithOperationResponseAsync(id, quickText, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
