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

    [Route("/mobileServices/REST/mobileControllerServices/setDeviceDetails", Verbs = "POST")]
    public class SetDeviceDetailsRequest : IApiRequest<SetDeviceDetailsResponse>
    {
        [JsonProperty("applicationId")] public int ApplicationId { set; get; }
        [JsonProperty("applicationOwnershipType")] public string ApplicationOwnershipType { set; get; }
        [JsonProperty("partnerId")] public int PartnerId { set; get; }
        [JsonProperty("customerRegId")] public int CustomerRegId { set; get; }
        [JsonProperty("latitude")] public long Latitude { set; get; }
        [JsonProperty("longitude")] public long Longitude { set; get; }
        [JsonProperty("deviceId")] public string DeviceId { set; get; }
        [JsonProperty("deviceToken")] public string DeviceToken { set; get; }
        [JsonProperty("deviceFingerprint")] public string DeviceFingerprint { set; get; }

    }
    public class SetDeviceDetailsResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }       
    }
}
