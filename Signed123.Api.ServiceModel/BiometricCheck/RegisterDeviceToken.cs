using Newtonsoft.Json;
using ServiceStack;
using Signed123.Features.Api.ServiceModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck
{

    [Route("/mobileServices/REST/mobileControllerServices/registerDeviceToken", Verbs = "POST")]
    public class RegisterDeviceTokenRequest : IApiRequest<RegisterDeviceTokenResponse>
    {
        [JsonProperty("applicationId")] public int ApplicationId { set; get; }
        [JsonProperty("customerRegId")] public int CustomerRegId { set; get; }
        [JsonProperty("partnerId")] public int PartnerId { set; get; }
        [JsonProperty("deviceToken")] public string DeviceToken { set; get; }
        [JsonProperty("deviceId")] public string DeviceId { set; get; }

    }
    public class RegisterDeviceTokenResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }
    }
}
