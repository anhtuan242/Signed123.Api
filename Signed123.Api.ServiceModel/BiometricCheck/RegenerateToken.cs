using Newtonsoft.Json;
using ServiceStack;
using Signed123.Features.Api.ServiceModel.Base;
using Signed123.Features.Api.ServiceModel.BiometricCheck.Models;
using Signed123.Features.Api.ServiceModel.Converters;
using Signed123.Features.Api.ServiceModel.Interfaces;
using System;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck
{
    [Route("/mobileServices/REST/mobileControllerServices/regenerateToken", Verbs = "POST")]
    public class RegenerateTokenRequest : IApiRequest<RegenerateTokenResponse>
    {
        [JsonProperty("authToken")] public string AuthToken { set; get; }
        [JsonProperty("authentication")] public Authentication Authentication { set; get; }

    }
    public class RegenerateTokenResponse : IApiResponse
    {
        [JsonProperty("result")] public ResultInfo Result { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd hh:mm:ss")]
        [JsonProperty("timestamp")] public DateTime Timestamp { get; set; }
        [JsonProperty("AuthToken")] public string AuthToken { get; set; }

        [JsonProperty("loginName")] public string LoginName { get; set; }
    }
}