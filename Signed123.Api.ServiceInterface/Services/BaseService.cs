using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using RestSharp;
using ServiceStack;
using ServiceStack.Configuration;
using Signed123.Features.Api.ServiceModel.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Signed123.Api.ServiceInterface.Services
{
    public class BaseService :Service
    {
        private static readonly ILogger Logger = HostContext.Resolve<ILoggerFactory>().CreateLogger(typeof(BaseService));

        protected object ExecuteBiomatricRequest<TRequest, TResponse>(string verb
                                                                   , string resource
                                                                   , TRequest request) where TRequest : IApiRequest where TResponse : IApiResponse, new() =>
            ExecuteBiomatricRequestAsync<TRequest, TResponse>(verb, resource, request)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();


        protected async Task<object> ExecuteBiomatricRequestAsync<TRequest, TResponse>(string verb
                                                                                   , string resource
                                                                                   , TRequest request) where TRequest : IApiRequest where TResponse : IApiResponse, new()
        {
            Logger.LogDebug("-- 1");
            var methodParsed = Enum.TryParse(verb, out Method parsedMethod);

            //todo: move this into some setting?
            resource = "/service/v1/" + resource.TrimStart('/');

            var restRequest = methodParsed
                                  ? new RestRequest(resource, parsedMethod) { RequestFormat = DataFormat.Json }
                                  : new RestRequest(resource) { RequestFormat = DataFormat.Json };

            var responseContent = string.Empty;
            var body = string.Empty;

            try
            {
                if (!methodParsed) throw new InvalidEnumArgumentException($"Unable to parse http method from: '{verb}'");


                Logger.LogDebug("-- 2");
                var restClient = HostContext.Container.ResolveNamed<RestClient>("123SignedClient");


                Logger.LogDebug("-- 3");

                Logger.LogDebug("-- 4");
                var serializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    }, //CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                };

                body = JsonConvert.SerializeObject(request, serializerSettings);

                Logger.LogDebug("-- 5");
                restRequest.AddParameter("application/json", body, ParameterType.RequestBody);

                Logger.LogDebug("-- 6");
                //Log.LogDebug($"-- 7 => {restRequest.ToSafeJson()}");
                var response = await restClient.ExecuteAsync(restRequest);
                // Log.LogDebug($"-- 8 => {response.ToSafeJson()}");
                responseContent = response.Content;
                Logger.LogDebug($"-- 9 => {responseContent}");
                var responseObject = JsonConvert.DeserializeObject<TResponse>(responseContent, serializerSettings);
                Logger.LogDebug("-- 10");
                var statusCode = (int)response.StatusCode;
                Logger.LogDebug($"-- 11 => {responseObject.ToJson()}");

                //await SystemMetricManager.Record<NuvoPayMetric>($"#NUVOPAY:{DateTime.UtcNow.ToDateOnly():o}:{request.GetType().Name}", new { Request = request, Response = responseObject, RawRequest = body, RawResponse = responseContent, Resource = resource, Verb = verb }.FlattenToStringDictionary()).ConfigureAwait(false);
                return responseObject;
            }
            catch (Exception e)
            {
                //await SystemMetricManager.Record<ExceptionMetric>($"#NUVOPAY:{DateTime.UtcNow.ToDateOnly():o}:{request.GetType().Name}", e, new { Request = request, RawRequest = body, Response = responseContent, Resource = resource, Verb = verb }.FlattenToStringDictionary()).ConfigureAwait(false);
                Logger.LogWarning(e, nameof(ExecuteBiomatricRequestAsync));
                //e.LogToApplicationInsights();
                throw;
            }
        }
    }
}
