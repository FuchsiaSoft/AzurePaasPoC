using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace VisitsApp
{
    public static class AzureVisitsApiAppServiceExtensions
    {
        public static AzureVisitsApi CreateAzureVisitsApi(this IAppServiceClient client)
        {
            return new AzureVisitsApi(client.CreateHandler());
        }

        public static AzureVisitsApi CreateAzureVisitsApi(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new AzureVisitsApi(client.CreateHandler(handlers));
        }

        public static AzureVisitsApi CreateAzureVisitsApi(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new AzureVisitsApi(uri, client.CreateHandler(handlers));
        }

        public static AzureVisitsApi CreateAzureVisitsApi(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new AzureVisitsApi(rootHandler, client.CreateHandler(handlers));
        }
    }
}
