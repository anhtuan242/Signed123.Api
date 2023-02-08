using Newtonsoft.Json;
using ServiceStack;
using Signed123.Features.Api.ServiceModel.Base;
using Signed123.Features.Api.ServiceModel.BiometricCheck.Models;
using Signed123.Features.Api.ServiceModel.Converters;
using Signed123.Features.Api.ServiceModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck
{
   

    [Route("/mobileServices/REST/mobileControllerServices/checkLiveliness", Verbs = "POST")]
    public class CheckLivelinessRequest : IApiRequest<CheckLivelinessResponse>
    {
        [JsonProperty("applicationId")] public int ApplicationId { set; get; }
        [JsonProperty("applicationOwnershipType")] string ApplicationOwnershipType  { set; get; }
        [JsonProperty("partnerId")] int PartnerId { set; get; }
        [JsonProperty("customerRegId")] int CustomerRegId { set; get; }

        [JsonConverter(typeof(BooleanConverter))]
        [JsonProperty("isLivelinessVerified")] bool IsLivelinessVerified { set; get; }
    }
    public class CheckLivelinessResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }

        [JsonConverter(typeof(BooleanConverter))]
        [JsonProperty("isLivelinessVerified")] bool IsLivelinessVerified { set; get; }
    }
}
