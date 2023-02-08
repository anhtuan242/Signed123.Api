using Newtonsoft.Json;
using ServiceStack;
using Signed123.Features.Api.ServiceModel.BiometricCheck.Models;
using Signed123.Features.Api.ServiceModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck
{

    [Route("/mobileServices/REST/mobileControllerServices/verifyAddress", Verbs = "POST")]
    public class VerifyAddressRequest : IApiRequest<VerifyAddressResponse>
    {
        [JsonProperty("applicationId")] public int ApplicationId { set; get; }
        [JsonProperty("applicationOwnershipType")] public string ApplicationOwnershipType { set; get; }
        [JsonProperty("partnerId")] public int PartnerId { set; get; }

        [JsonProperty("addressDetail")] public AddressDetail AddressDetail { set; get; }

        [JsonProperty("documentDetail")] public DocumentDetail DocumentDetail { set; get; }


    }
    public class VerifyAddressResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }
        
    }
}
