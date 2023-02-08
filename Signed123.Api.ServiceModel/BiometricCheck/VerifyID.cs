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

    [Route("/mobileServices/REST/mobileControllerServices/verifyId", Verbs = "POST")]
    public class VerifyIDRequest : IApiRequest<VerifyIDResponse>
    {
        [JsonProperty("applicationId")] public int ApplicationId { set; get; }
        [JsonProperty("partnerId")] public int PartnerId { set; get; }
        [JsonProperty("applicationOwnershipType")] public string ApplicationOwnershipType { set; get; }
        [JsonProperty("customerRegId")] public int CustomerRegId { set; get; }

        [JsonProperty("userDetail")] public UserDetail UserDetail { set; get; }
        [JsonProperty("documentDetail")] public DocumentDetail DocumentDetail { set; get; }


    }
    public class VerifyIDResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonConverter(typeof(BooleanConverter))]
        [JsonProperty("isFirstNameVerified")] public bool IsFirstNameVerified { get; set; }

        [JsonConverter(typeof(BooleanConverter))]
        [JsonProperty("isLastNameVerified")] public bool IsLastNameVerified { get; set; }


        [JsonConverter(typeof(BooleanConverter))]
        [JsonProperty("isDobVerified")] public bool IsDobVerified { get; set; }

        [JsonConverter(typeof(BooleanConverter))]
        [JsonProperty("isDocumentIdVerified")] public bool IsDocumentIdVerified { get; set; }

        [JsonConverter(typeof(BooleanConverter))]
        [JsonProperty("isIssueDateVerified")] public bool IsIssueDateVerified { get; set; }
        [JsonConverter(typeof(BooleanConverter))]
        [JsonProperty("isExpiryDateVerified")] public bool IsExpiryDateVerified { get; set; }

    }
}
