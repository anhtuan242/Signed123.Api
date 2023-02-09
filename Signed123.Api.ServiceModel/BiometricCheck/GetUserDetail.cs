using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using ServiceStack;
using Signed123.Features.Api.ServiceModel.BiometricCheck.Models;
using Signed123.Features.Api.ServiceModel.Converters;
using Signed123.Features.Api.ServiceModel.Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck
{

    [Route("/mobileServices/REST/mobileControllerServices/getUserDetail", Verbs = "POST")]
    public class GetUserDetailRequest : IApiRequest<GetUserDetailResponse>
    {
        [JsonProperty("applicationId")] public int ApplicationId { set; get; }
        [JsonProperty("customerRegId")] public int CustomerRegId { set; get; }
    }
    public class GetUserDetailResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }
        
    }
}
