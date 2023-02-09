using Newtonsoft.Json;
using ServiceStack;
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
   
    [Route("/mobileServices/REST/mobileControllerServices/verifyUserFaces", Verbs = "POST")]
    public class VerifyUserFacesRequest : IApiRequest<VerifyUserFacesResponse>
    {
        [JsonProperty("applicationId")] public int ApplicationId { set; get; }
        [JsonProperty("partnerId")] public int PartnerId { set; get; }
        [JsonProperty("applicationOwnershipType")] public string ApplicationOwnershipType { set; get; }
        [JsonProperty("customerRegId")] public int CustomerRegId { set; get; }
        [JsonProperty("user_image")] public string UserImage { set; get; }

    }
    public class VerifyUserFacesResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }     
    }
}
