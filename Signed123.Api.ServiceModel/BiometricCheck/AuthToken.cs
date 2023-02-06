using Newtonsoft.Json;
using System;
using ServiceStack;
using Signed123.Features.Api.ServiceModel.Base;
using Signed123.Features.Api.ServiceModel.BiometricCheck.Models;
using Signed123.Features.Api.ServiceModel.Converters;
using Signed123.Features.Api.ServiceModel.Interfaces;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck
{

    [Route("/mobileServices/REST/mobileControllerServices/authToken", Verbs = "POST")]
    public class AuthTokenRequest : IApiRequest<AuthTokenResponse>
    {
        [JsonProperty("authentication")] public Authentication Authentication { set; get; }
        [JsonProperty("partner")] public Partner Partner { set; get; }
    }
    public class AuthTokenResponse : IApiResponse
    {
        [JsonProperty("result")] public ResultInfo Result { get; set; }

        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd hh:mm:ss")]
        [JsonProperty("timestamp")] public DateTime Timestamp { get; set; }
        [JsonProperty("AuthToken")] public string AuthToken { get; set; }

        [JsonProperty("loginName")] public string LoginName { get; set; }
    }
}